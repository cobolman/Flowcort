using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Flowcort
{
    public partial class Form2 : Form
    {
        private string _DBFile = "FlowcortData";
        private string _ConnectionString = @"data source=|DataDirectory|FlowcortData.fct";
        public string ConnectionString
        {
            get { return _ConnectionString; }
            set
            {
                _ConnectionString = value;
                var m = Regex.Match(_ConnectionString, @"(.*\|DataDirectory\|\\*)(.*)(.fct)");
                _DBFile = m.Groups[2].Value.ToString();

                _ImageFolder = AppDomain.CurrentDomain.BaseDirectory + _DBFile + "\\FullSize";
                _ThumbnailFolder = AppDomain.CurrentDomain.BaseDirectory + _DBFile + "\\Thumbnail";
            }
        }

        private string _ImageFolder;
        private string _ThumbnailFolder;

        private bool _portrait = false;
        private bool _pinned = false;

        public bool Pinned { 
            get { return _pinned; } 
            set { 
                _pinned = value; 
                btnPin.Image = _pinned ? Properties.Resources.Pinned : Properties.Resources.Pin;
                btnPortraitOrLandscape.Enabled = !_pinned;
                SetFormSize();
            } 
        }

        public bool Portrait {
            get { return _portrait; }
            set { _portrait = value; if (_portrait) SetPortraitMode(); else SetLandscapeMode(); }
        }

        Bitmap FlowcortYouTubeBW;
        Bitmap FlowcortYouTubeC;

        Bitmap Flowcort208x117BW;
        Bitmap Flowcort208x117C;

        // User-defined win32 event
        const int WM_USER_SIMCONNECT = 0x0402;

        // SimConnect object
        FSXConnect fsxConnection = null;

        enum EVENTS
        {
            KEY_TOGGLE_PROPELLER_DEICE,
            KEY_PRESSURIZATION_PRESSURE_ALT_INC,
            KEY_PRESSURIZATION_PRESSURE_ALT_DEC,
            KEY_PRESSURIZATION_PRESSURE_DUMP_SWITCH,
        };

        enum DATA_REQUESTS
        { 
            REQUEST_1,
        }

        private int _transparency = 0;
        private int transparency {
            get { return _transparency; }
            set 
            {
                _transparency = value;
                double trx = Convert.ToDouble(_transparency) / 10;
                this.Opacity = 1.0 - trx;

                pctrbxTransparency.Image = imglstTransparency.Images[_transparency];
            }
        }

        public Form2()
        {
            InitializeComponent();
            this.itemDataGridView1.MouseWheel += new MouseEventHandler(mousewheel);
            this.pctrbxTransparency.MouseWheel += new MouseEventHandler(transparencymousewheel);
        }

        private void transparencymousewheel(object sender, MouseEventArgs e)
        {
            if ( e.Delta > 0 )
            {
                if (transparency < 7)
                    transparency += 1;
            }
            else if (e.Delta < 0)
            {
                if (transparency > 0)
                    transparency -= 1;
            }
        }

        private void mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && itemDataGridView1.FirstDisplayedScrollingRowIndex > 0)
            {
                itemDataGridView1.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                itemDataGridView1.FirstDisplayedScrollingRowIndex++;
            }
        }

        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == WM_USER_SIMCONNECT)
            {
                if ( fsxConnection != null && fsxConnection.simconnect != null)
                {
                    fsxConnection.simconnect.ReceiveMessage();
                }
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }

        private void closeConnection()
        {
            if (fsxConnection != null)
            {
                fsxConnection.closeConnection();
                fsxConnection = null;
                btnConnectToggle.Image = Properties.Resources.Disconnected32;
            }
        } 

        private void Form2_Load(object sender, EventArgs e)
        {
            SetFormLook();
            SetFormLocation();

            pctrbxRemarks.Parent = txtbxRemarks;
            pctrbxRemarks.Location = new Point(1, 1);

            FlowcortYouTubeBW = Properties.Resources.FlowcortYouTubeBW;
            FlowcortYouTubeC = Properties.Resources.FlowcortYouTubeC;
            pictureBox2.Image = FlowcortYouTubeBW;

            Flowcort208x117BW = Properties.Resources.Flowcort208x117BW;
            Flowcort208x117C = Properties.Resources.Flowcort208x117C;
            pictureBox1.Image = Flowcort208x117BW;
        }

        private void ReturnMeToMyLastLocation()
        {
            string curLocn = ConnectionString + "CurLocn";
            string curSection = ConnectionString + "CurSection";

            if (ConfigurationManager.AppSettings[curLocn] != null && ConfigurationManager.AppSettings[curSection] != null)
            {
                int rowIndex = -1;
                Button btn = findSectionButtonByText(ConfigurationManager.AppSettings[curSection].ToString());
                MoveToSection(btn);

                foreach (DataGridViewRow row in itemDataGridView1.Rows)
                {
                    if (row.Cells["ItemID"].Value.ToString().Equals(ConfigurationManager.AppSettings[curLocn].ToString()))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }

                if (rowIndex != -1)
                {
                    itemDataGridView1.Rows[rowIndex].Selected = true;
                    MoveSelectedRowToMiddleOfGrid();
                }
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                //case 72:
                //    ShowHideFlowcort();
                //    break;
                case 74:
                    nextActionItem(false);
                    break;
                case 75:
                    toggleDoneUndone();
                    break;
                case 76:
                    nextActionItem(true);
                    break;

            }
        }

        private void toggleDoneUndone()
        {
            if (itemDataGridView1.CurrentRow != null)
            {
                using (DataGridViewRow dgv = itemDataGridView1.CurrentRow)
                {
                    DataRowView drv = dgv.DataBoundItem as DataRowView;
                    drv["Done"] = !(bool)drv["Done"];

                    itemBindingSource1.EndEdit();
                    itemTableAdapter1.Update(FlowcortDataSet.Item);

                    if (allItemsInSectionAreDone())
                        nextSection();
                    else
                    {
                        ColorizeRow(dgv);
                        nextActionItem(true);
                    }
                }
            }
        }

        private void nextSection()
        {
            sectionBindingSource1.MoveNext();
        }

        private bool allItemsInSectionAreDone()
        {
            bool result = true;

            foreach (DataGridViewRow row in itemDataGridView1.Rows)
            {
                if (!RowIsEventOrSubsection(row))
                { 
                    if (Convert.ToBoolean(row.Cells["Done"].Value) == false)
                    { 
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        private Boolean RowIsEventOrSubsection( DataGridViewRow row )
        {
            bool result = false;

            if ( row != null )
                result = (Convert.ToBoolean(row.Cells["Subsection"].Value) == true || Convert.ToBoolean(row.Cells["Event"].Value) == true);

            return result;
        }

        private bool allItemsAreDone()
        {
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT Count(*) FROM Item WHERE Done = 0 AND Subsection = 0 AND EVENT = 0;", itemTableAdapter1.Connection))
            {
                if (itemTableAdapter1.Connection.State != ConnectionState.Open)
                    itemTableAdapter1.Connection.Open();

                return (Convert.ToInt16(cmd.ExecuteScalar()) == 0);
            }
        }

        private bool allItemsAreUndone()
        {
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT Count(*) FROM Item WHERE Done = 1 AND Subsection = 0 AND Event = 0;", itemTableAdapter1.Connection))
            {
                if (itemTableAdapter1.Connection.State != ConnectionState.Open)
                    itemTableAdapter1.Connection.Open();

                return( Convert.ToInt16(cmd.ExecuteScalar()) == 0);
            }
        }

        private bool sectionIsPartiallyDone()
        {
            bool result = true;

            foreach (DataGridViewRow row in itemDataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Subsection"].Value) == false &&
                    Convert.ToBoolean(row.Cells["Event"].Value) == false)
                {
                    if (Convert.ToBoolean(row.Cells["Done"].Value) != result)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        private bool listIsPartiallyDone()
        {
            return !(allItemsAreDone() ^ allItemsAreUndone());
        }

        private void ShowHideFlowcort()
        {
            Visible = !Visible;
        }

        private void itemBindingSource_PositionChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Flowcort208x117BW;
            pictureBox2.Image = FlowcortYouTubeBW;
            pctrbxRemarks.Visible = true;

            if (itemBindingSource1.Current != null)
            {
                string img1Locn = ((DataRowView)itemBindingSource1.Current).Row["Image1"].ToString();
                string img2Locn = ((DataRowView)itemBindingSource1.Current).Row["Image2"].ToString();

                pictureBox1.ImageLocation = qualifyFileName(img1Locn);
                pictureBox2.ImageLocation = qualifyFileName(img2Locn);

                SetPictureBoxToolTip(pictureBox1);
                SetPictureBoxToolTip(pictureBox2);

                if (((DataRowView)itemBindingSource1.Current).Row["Remarks"].ToString() != "")
                    pctrbxRemarks.Visible = false;

            }
        }

        private void SetPictureBoxToolTip(PictureBox pb)
        {
            if (pb.ImageLocation == "")
            {
                if (pb.Image == Flowcort208x117BW)
                    toolTip1.SetToolTip(pb, "Click to visit the site");
                else
                    toolTip1.SetToolTip(pb, "Click to visit the channel");
            }
            else
                toolTip1.SetToolTip(pb, "Click for full-size image");
        }

        private string qualifyFileName(string fname)
        {
            fname = _ThumbnailFolder + "\\" + fname;

            if (File.Exists(fname))
                return fname;
            else
                return "";
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == Flowcort208x117C)
            {
                System.Diagnostics.Process.Start("http://www.flowcort.com");
            }
            else
            {
                showImage("Image1");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if ( pictureBox2.Image == FlowcortYouTubeC )
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCEvh0d135xV0qnuR8BwnDvw");
            }
            else
            {
               showImage("Image2");
            }
        }

        private void showImage(string columnName)
        {
            string fname = _ImageFolder + "\\" + ((DataRowView)itemBindingSource1.Current).Row[columnName].ToString();

            if (File.Exists(fname))
            {
                showImageFullSize(fname);
            }
        }

        private void showImageFullSize(string imgLocn)
        {
            using (Form form = new Form())
            {
                Bitmap img = new Bitmap(imgLocn);

                form.StartPosition = FormStartPosition.CenterScreen;
                form.Text = "Click or close to continue ...";
                form.ClientSize = img.Size;

                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.Click += pb_Click;
                pb.Image = img;

                form.Controls.Add(pb);
                form.TopMost = true;
                form.ShowDialog();
            }

            TopMost = true;
        }

        void pb_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).FindForm().Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUserSettings();
        }

        private string GetCurrentLocation()
        {
            string result = "1";
            DataGridViewRow dgvr = itemDataGridView1.CurrentRow;

            if (dgvr != null)
                result = dgvr.Cells["ItemID"].Value.ToString();

            return result;
        }

        static void AddUpdateAppSetting(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        private string ReadAppSetting(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;
            return appSettings[key] ?? "100";
        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            FlowcortDataSet.EnforceConstraints = false;
            this.sectionTableAdapter1.Fill(this.FlowcortDataSet.Section);
            this.itemTableAdapter1.Fill(this.FlowcortDataSet.Item);
            FlowcortDataSet.EnforceConstraints = true;
        }

        private void itemDataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in itemDataGridView1.Rows)
            {
                ColorizeRow(row);
            }

        }

        private void nextActionItem(Boolean directionNext)
        {
            if (itemDataGridView1.SelectedRows.Count > 0)
            {
                int curLocn = itemDataGridView1.SelectedRows[0].Index;
                int rowCount = itemDataGridView1.Rows.Count;

                if (directionNext)
                {
                    for (int n = curLocn + 1; n < rowCount; n++)
                    {
                        DataGridViewRow row = itemDataGridView1.Rows[n];
                        if (!(Convert.ToBoolean(row.Cells["Event"].Value) || Convert.ToBoolean(row.Cells["Subsection"].Value)))
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
                else
                {
                    for (int n = curLocn - 1; n >= 0; n--)
                    {
                        DataGridViewRow row = itemDataGridView1.Rows[n];
                        if (!(Convert.ToBoolean(row.Cells["Event"].Value) || Convert.ToBoolean(row.Cells["Subsection"].Value)))
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }

                MoveSelectedRowToMiddleOfGrid();
            }
        }

        private void MoveSelectedRowToMiddleOfGrid()
        {
            int x = itemDataGridView1.SelectedRows[0].Index;
            int middle = itemDataGridView1.DisplayedRowCount(false) / 2;

            itemDataGridView1.CurrentCell = itemDataGridView1.SelectedRows[0].Cells[3];

            if (x > middle)
                itemDataGridView1.FirstDisplayedScrollingRowIndex = x - middle;
        }

        private void btnConnectToggle_Click(object sender, EventArgs e)
        {
            if (fsxConnection == null)
            {
                fsxConnection = new FSXConnect(this);
                fsxConnection.openConnection();
                fsxConnection.ConnectionOpenEventHandler += new EventHandler(fsxConnectionOpened);

                // todo need a way to ensure that Flowcort is shown when FSX quits

                fsxConnection.FSXActionEventHandler += new EventHandler<FSXConnect.FSXActionEventArgs>(fsxAction);
                fsxConnection.AltitudeChangedEventHandler += new EventHandler<FSXConnect.AltitudeChangedEventArgs>(fsxAltitudeChanged);
            }
            else
            {
                closeConnection();
            }
        }

        private void fsxAltitudeChanged(object sender, FSXConnect.AltitudeChangedEventArgs e)
        {
            txtbxRemarks.Text = e.altitude.ToString();
        }

        private void fsxAction(object sender, FSXConnect.FSXActionEventArgs e)
        {
            switch (e.Action)
            {
                //KEY_PRESSURIZATION_PRESSURE_ALT_INC,
                //KEY_PRESSURIZATION_PRESSURE_ALT_DEC,
                //KEY_PRESSURIZATION_PRESSURE_DUMP_SWITCH,

                case (uint)EVENTS.KEY_TOGGLE_PROPELLER_DEICE:

                    ShowHideFlowcort();
                    break;

                case (uint)EVENTS.KEY_PRESSURIZATION_PRESSURE_ALT_INC:

                    nextActionItem(true);
                    break;

                case (uint)EVENTS.KEY_PRESSURIZATION_PRESSURE_ALT_DEC:

                    nextActionItem(false);
                    break;

                case (uint)EVENTS.KEY_PRESSURIZATION_PRESSURE_DUMP_SWITCH:

                    toggleDoneUndone();
                    break;

            }
        }

        private void fsxConnectionOpened(Object sender, EventArgs e)
        {
            btnConnectToggle.Image = Flowcort.Properties.Resources.Connected32;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeConnection();
        }

        private void btnAltitude_Click(object sender, EventArgs e)
        {
            if ( fsxConnection != null )
                fsxConnection.pollFSXData();
        }

        private Button findSectionButtonByText(String buttonText)
        {
            Button result = null;
            buttonText = buttonText.ToUpper();

            for (int i = 0; i < buttonBar1.Buttons.Count; i++)
            {
                Button btn = buttonBar1.Buttons[i];

                if (btn.Text == buttonText)
                {
                    result = btn;
                    break;
                }
            }

            return result;
        }

        private void btnSection(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            {
                MoveToSection(btn);
            }
        }


        private void MoveToSection(Button sender)
        {
            int section = sectionBindingSource1.Find("Description", sender.Text);
            if (section != -1)
            {
                sectionBindingSource1.Position = section;
                itemDataGridView1.Focus();
                // setSelectedSectionButton(sender);
            }

        }

        private void setSelectedSectionButton(Button sender)
        {
            if (sender != null)
            {
                resetSectionButtons();
                Button btn = sender as Button;
                {
                    btn.BackColor = SystemColors.Highlight;
                    btn.ForeColor = SystemColors.HighlightText;
                }
            }
        }

        private string GetSelectedSectionText()
        {
            string result = "No selected section found";

            for (int i = 0; i < buttonBar1.Buttons.Count; i++)
            {
                Button btn = buttonBar1.Buttons[i];
                if (btn.BackColor == System.Drawing.SystemColors.Highlight)
                {
                    result = btn.Text;
                }
            }

            return result;
        }

        private void resetSectionButtons()
        {
            for (int i = 0; i < buttonBar1.Buttons.Count; i++)
            {
                Button btn = buttonBar1.Buttons[i];
                resetButton(btn);
            }
        }

        private void resetButton(Button sender)
        {
            sender.BackColor = SystemColors.Control;
            sender.ForeColor = SystemColors.ControlText;
        }

        private void btnLandscapeOrPortrait(object sender, EventArgs e)
        {
            Portrait = !Portrait;
        }

        private void SetLandscapeMode()
        {
            try
            {
                pnlDetail.Location = new Point(600, 3);
                pnlDetail.Size = new Size(391, 278);
                txtbxRemarks.Size = new Size(179, 275);

                pictureBox1.Location = new Point(181, 0);
                pictureBox2.Location = new Point(181, 161);

                SetFormSize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetPortraitMode()
        {
            try
            {
                pnlDetail.Location = new Point(0, 282);
                pnlDetail.Size = new Size(601, 319);
                txtbxRemarks.Size = new Size(596, 95);

                pictureBox1.Location = new Point(46, 100);
                pictureBox2.Location = new Point(346, 100);

                SetFormSize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // ColorizeRow(itemDataGridView1.CurrentRow);
        }

        private void ColorizeRow(DataGridViewRow row)
        {
            if (row != null)
            {
                bool evnt = Convert.ToBoolean(row.Cells["Event"].Value);
                bool subSection = Convert.ToBoolean(row.Cells["SubSection"].Value);
                bool done = Convert.ToBoolean(row.Cells["Done"].Value);

                if (evnt || subSection)
                {
                    row.DefaultCellStyle.ForeColor = SystemColors.WindowText;

                    if (evnt)
                    {
                        row.DefaultCellStyle.BackColor = Color.PapayaWhip;
                    }

                    if (subSection)
                    {
                        row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
                else
                {
                    if (done)
                    {
                        row.DefaultCellStyle.ForeColor = SystemColors.ControlDark;
                        row.DefaultCellStyle.SelectionForeColor = SystemColors.ControlDark;
                        row.DefaultCellStyle.SelectionBackColor = SystemColors.InactiveCaption;
                    }
                    else
                    {
                        row.DefaultCellStyle.ForeColor = SystemColors.WindowText;
                        row.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
                        row.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                    }
                }
            }

        }

        private void sectionBindingSource1_PositionChanged(object sender, EventArgs e)
        {
            DataRowView current = (DataRowView)sectionBindingSource1.Current;

            if (current != null)
            {
                String newSection = current["Description"].ToString().ToUpper();

                Button sectionButton = findSectionButtonByText(newSection);
                setSelectedSectionButton(sectionButton);

                if (RowIsEventOrSubsection(itemDataGridView1.CurrentRow))
                    nextActionItem(true);
            }
        }

        private void btnResetSection_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in itemDataGridView1.Rows)
            {
                dgvr.Cells["Done"].Value = false;
            }

            itemBindingSource1.EndEdit();
            itemTableAdapter1.Update(FlowcortDataSet.Item);

            if (itemDataGridView1.Rows.Count > 0)
            {
                itemDataGridView1.Rows[0].Selected = true;
                itemDataGridView1.Rows[0].Cells[2].Selected = true;
            }

            itemDataGridView1.Focus();
        }

        private void btnResetList_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand sqlcmd = con.CreateCommand();
                sqlcmd.CommandText = "UPDATE Item SET Done = 0";

                con.Open();
                int rowsAffected = sqlcmd.ExecuteNonQuery();
            }

            RefreshData();
        }

        private void pctrbxTransparency_MouseDown(object sender, MouseEventArgs e)
        {
            if ( e.Button == MouseButtons.Left )
            {
                if (transparency > 0)
                    transparency -= 1;
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (transparency < 7)
                    transparency += 1;
            }
        }

        private void pctrbxTransparency_MouseEnter(object sender, EventArgs e)
        {
            pctrbxTransparency.Focus();
        }

        private void pctrbxTransparency_MouseLeave(object sender, EventArgs e)
        {
            itemDataGridView1.Focus();
        }

        private void itemDataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            flwButtonPanel.Visible = ( e.Y > 200 );
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (pictureBox2.Image == FlowcortYouTubeBW)
                pictureBox2.Image = FlowcortYouTubeC;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (pictureBox1.Image == Flowcort208x117BW)
            pictureBox1.Image = Flowcort208x117C;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (pictureBox2.Image == FlowcortYouTubeC)
                pictureBox2.Image = FlowcortYouTubeBW;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (pictureBox1.Image == Flowcort208x117C)
                pictureBox1.Image = Flowcort208x117BW;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            GetData();
            CreateSectionTabs();
            ApplyUserSettings();
        }

        private void CreateSectionTabs()
        {
            using (DataTableReader dtrdr = FlowcortDataSet.Section.CreateDataReader())
            {
                while (dtrdr.Read())
                {
                    string desc = dtrdr["Description"].ToString();
                    buttonBar1.Add(desc);
                }
            }

            // Mark first button as selected
            if (buttonBar1.Count > 0)
                setSelectedSectionButton(buttonBar1.GetButton(0));

            itemDataGridView1.ScrollBars = ScrollBars.None;
            this.TopMost = true;
        }

        private void GetData()
        {
            sectionTableAdapter1.Connection.ConnectionString = ConnectionString;
            itemTableAdapter1.Connection.ConnectionString = ConnectionString;

            this.sectionTableAdapter1.Fill(this.FlowcortDataSet.Section);
            this.itemTableAdapter1.Fill(this.FlowcortDataSet.Item);
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            Pinned = !Pinned;
        }

        private void SetFormSize()
        {
            if (Pinned)
                this.ClientSize = new Size(601, 283);
            else
            {
                if (Portrait)
                    this.ClientSize = new Size(601, 501);
                else
                    this.ClientSize = new Size(995, 283);
            }
        }

        private void ApplyUserSettings()
        {
            if (ConfigurationManager.AppSettings["Col0"] != null)
            {
                for (int n = 0; n < itemDataGridView1.ColumnCount - 1; n++)
                {
                    string width = ReadAppSetting("Col" + n.ToString());
                    itemDataGridView1.Columns[n].Width = int.Parse(width);
                }
            }

            ReturnMeToMyLastLocation();
        }

        private void SetFormLook()
        {
            if (ReadAppSetting("Portrait") != "100")
                Portrait = Convert.ToBoolean(ReadAppSetting("Portrait"));

            if (ReadAppSetting("Pinned") != "100")
                Pinned = Convert.ToBoolean(ReadAppSetting("Pinned"));
        }

        private void SetFormLocation()
        {
            if (ReadAppSetting("FormLocnX") != "100" && ReadAppSetting("FormLocnY") != "100")
            {
                int x = Convert.ToInt32(ReadAppSetting("FormLocnX"));
                int y = Convert.ToInt32(ReadAppSetting("FormLocnY"));
                this.Location = new Point(x, y);
            }
        }

        private void SaveUserSettings()
        {
            for (int n = 0; n < itemDataGridView1.ColumnCount - 1; n++)
            {
                AddUpdateAppSetting("Col" + n.ToString(), itemDataGridView1.Columns[n].Width.ToString());
            }

            AddUpdateAppSetting( ConnectionString + "CurLocn", GetCurrentLocation());
            AddUpdateAppSetting( ConnectionString + "CurSection", GetSelectedSectionText());

            AddUpdateAppSetting("FormLocnX", this.Location.X.ToString());
            AddUpdateAppSetting("FormLocnY", this.Location.Y.ToString());

            AddUpdateAppSetting("Portrait", Portrait.ToString());
            AddUpdateAppSetting("Pinned", Pinned.ToString());
        }

    }

}
