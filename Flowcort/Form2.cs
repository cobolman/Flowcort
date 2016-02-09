using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flowcort
{
    public partial class Form2 : Form
    {
        // Form Variables

        bool portrait = true;

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

        public Form2()
        {
            InitializeComponent();
            this.itemDataGridView1.MouseWheel += new MouseEventHandler(mousewheel);
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
                btnConnectToggle.Image = Flowcort.Properties.Resources.Disconnected32;
            }
        } 

        private void Form2_Load(object sender, EventArgs e)
        {
            this.sectionTableAdapter1.Fill(this.fSXSE_A321_TutorialDataSet.Section);
            this.itemTableAdapter1.Fill(this.fSXSE_A321_TutorialDataSet.Item);

            // Populate button bar with section names
            using (DataTableReader dtrdr = fSXSE_A321_TutorialDataSet.Section.CreateDataReader())
            {
                while (dtrdr.Read())
                {
                    buttonBar1.Add(dtrdr.GetString(2));
                }
            }

            itemDataGridView1.ScrollBars = ScrollBars.None;
            lblFSEvents.Text = "";
            this.TopMost = true;

            if (ConfigurationManager.AppSettings["Col0"] != null)
            {
                for (int n = 0; n < itemDataGridView1.ColumnCount - 1; n++)
                {
                    string width = ReadAppSetting("Col" + n.ToString());
                    itemDataGridView1.Columns[n].Width = int.Parse(width);
                }
            }
        }

        private void hUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hUDToolStripMenuItem.Checked)
            {
                int y = Screen.GetWorkingArea(this).Height - 132;
                this.Location = new Point(0, y);

                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Width = Screen.GetWorkingArea(this).Width;
            }
            else
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 72:
                    ShowHideFlowcort();
                    break;
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
            using (DataGridViewRow dgv = itemDataGridView1.CurrentRow)
            {
                DataRowView drv = itemDataGridView1.CurrentRow.DataBoundItem as DataRowView;
                drv["Done"] = !(bool)drv["Done"];

                if (allItemsAreDone())
                    nextSection();
                else
                    nextActionItem(true);
            }
        }

        private void nextSection()
        {
            sectionBindingSource1.MoveNext();
        }

        private bool allItemsAreDone()
        {
            bool result = true;

            foreach (DataGridViewRow row in itemDataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Done"].Value) == false)
                { 
                    result = false;
                    break;
                }
            }

            return result;
        }

        private void ShowHideFlowcort()
        {
            if (this.Visible)
            {
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
            }
        }

        private void itemBindingSource_PositionChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "";
            pictureBox2.ImageLocation = "";

            if (itemBindingSource1.Current != null)
            {
                string img1Locn = ((DataRowView)itemBindingSource1.Current).Row["Image1"].ToString() + ".jpg";
                string img2Locn = ((DataRowView)itemBindingSource1.Current).Row["Image2"].ToString() + ".jpg";

                pictureBox1.ImageLocation = qualifyFileName(img1Locn);
                pictureBox2.ImageLocation = qualifyFileName(img2Locn);
            }
        }

        private string qualifyFileName(string fname)
        {
            if (fname != ".jpg")
            {
                return "ImagesTN\\" + fname;
            }
            else
            {
                return "";
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            showImage("Image1", ".png");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            showImage("Image2", ".png");
        }

        private void showImage(string columnName, string imgType)
        {
            string fname = "Images\\" + ((DataRowView)itemBindingSource1.Current).Row[columnName].ToString() + imgType;

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
                form.ShowDialog();
            }
        }

        void pb_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).FindForm().Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int n = 0; n < itemDataGridView1.ColumnCount - 1; n++)
            {
                AddUpdateAppSettings("Col" + n.ToString(), itemDataGridView1.Columns[n].Width.ToString());
            }
        }

        static void AddUpdateAppSettings(string key, string value)
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

        private void dataEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastDataEntry frmFDE = new FastDataEntry();
            frmFDE.Show();

        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSXSE_A321_TutorialDataSet.EnforceConstraints = false;
            this.sectionTableAdapter1.Fill(this.fSXSE_A321_TutorialDataSet.Section);
            this.itemTableAdapter1.Fill(this.fSXSE_A321_TutorialDataSet.Item);
            fSXSE_A321_TutorialDataSet.EnforceConstraints = true;
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
            int curLocn = itemDataGridView1.SelectedRows[0].Index;
            int rowCount = itemDataGridView1.Rows.Count;
            
            if (directionNext)
            {
                for (int n = curLocn + 1; n < rowCount; n++)
                {
                    DataGridViewRow row = itemDataGridView1.Rows[n];
                    if ( !(Convert.ToBoolean(row.Cells["Event"].Value) || Convert.ToBoolean(row.Cells["Subsection"].Value) ))
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

            int x = itemDataGridView1.SelectedRows[0].Index;
            int middle = itemDataGridView1.DisplayedRowCount(false) / 2;

            itemDataGridView1.CurrentCell = itemDataGridView1.SelectedRows[0].Cells[2];

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

                    lblFSEvents.Text = "Hide";
                    ShowHideFlowcort();
                    break;

                case (uint)EVENTS.KEY_PRESSURIZATION_PRESSURE_ALT_INC:

                    lblFSEvents.Text = "Next Item";
                    nextActionItem(true);
                    break;

                case (uint)EVENTS.KEY_PRESSURIZATION_PRESSURE_ALT_DEC:

                    lblFSEvents.Text = "Prior Item";
                    nextActionItem(false);
                    break;

                case (uint)EVENTS.KEY_PRESSURIZATION_PRESSURE_DUMP_SWITCH:

                    lblFSEvents.Text = "Done/Undone Toggle";
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

        private void button4_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double transparency = Convert.ToDouble(numericUpDown1.Value) / 10;
            this.Opacity = 1.0 - transparency;
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

                setSelectedSectionButton(sender);
            }

        }

        private void setSelectedSectionButton(Button sender)
        {
            if (sender != null)
            {
                resetSectionButtons();
                Button btn = sender as Button;
                {
                    btn.BackColor = System.Drawing.SystemColors.Highlight;
                    btn.ForeColor = System.Drawing.SystemColors.HighlightText;
                }
            }
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
            sender.BackColor = System.Drawing.SystemColors.Control;
            sender.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void btnLandscapeOrPortrait(object sender, EventArgs e)
        {
            if (portrait)
            {
                SetLandscapeMode();
                portrait = false;
            }
            else
            {
                SetPortraitMode();
            }
        }

        private void SetPortraitMode()
        {
            try
            {
                this.Size = new Size(1024, 360);

                pnlDetail.Location = new Point(605, 3);
                pnlDetail.Size = new Size(400, 316);
                txtbxRemarks.Size = new Size(179, 200);

                pictureBox1.Location = new Point(188, 73);
                pictureBox2.Location = new Point(188, 199);
                numericUpDown1.Location = new Point(360, 8);

                btnAltitude.Location = new Point(58, 276);
                portrait = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetLandscapeMode()
        {
            try
            {
                this.Size = new Size(622, 685);

                pnlDetail.Location = new Point(3, 325);
                pnlDetail.Size = new Size(600, 319);
                txtbxRemarks.Size = new Size(587, 120);

                pictureBox1.Location = new Point(4, 199);
                pictureBox2.Location = new Point(388, 199);
                numericUpDown1.Location = new Point(567, 3);

                btnAltitude.Location = new Point(259, 199);
                portrait = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ColorizeRow(itemDataGridView1.CurrentRow);

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
            String newSection = current["Description"].ToString().ToUpper();

            Button sectionButton = findSectionButtonByText(newSection);
            setSelectedSectionButton(sectionButton);
        }

        private void btnResetSection_Click(object sender, EventArgs e)
        {
            if (allItemsAreDone())
            {
                foreach (DataGridViewRow dgvr in itemDataGridView1.Rows)
                {
                    dgvr.Cells["Done"].Value = false;
                }
            }
            else
            {
                foreach (DataGridViewRow dgvr in itemDataGridView1.Rows)
                {
                    dgvr.Cells["Done"].Value = true;
                }
            }
        }


    }
}
