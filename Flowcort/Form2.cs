using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using Microsoft.FlightSimulator.SimConnect;
using System.Runtime.InteropServices;
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
        SimConnect simconnect = null;

        enum EVENTS
        {
            KEY_TOGGLE_PROPELLER_DEICE,
            KEY_PRESSURIZATION_PRESSURE_ALT_INC,
            KEY_PRESSURIZATION_PRESSURE_ALT_DEC,
            KEY_PRESSURIZATION_PRESSURE_DUMP_SWITCH,
        };

        enum NOTIFICATION_GROUPS
        {
            GROUP0,
        }

        enum DEFINITIONS
        {
            Struct1,
        }

        enum DATA_REQUESTS
        { 
            REQUEST_1,
        }

        // this is how you declare a data structure so that 
        // simconnect knows how to fill it/read it. 
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct Struct1
        {
            // this is how you declare a fixed size string 
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public String title;
            public double latitude;
            public double longitude;
            public double altitude;
        }; 

        public Form2()
        {
            InitializeComponent();
        }

        //TODO Set this to point at the FSXConnect object I'll be creating
        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == WM_USER_SIMCONNECT)
            {
                if (simconnect != null)
                {
                    simconnect.ReceiveMessage();
                }
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }

        //TODO Re-work this to use my FXSConnect object
        private void closeConnection()
        {
            if (simconnect != null)
            {
                // Dispose serves the same purpose as SimConnect_Close() 
                simconnect.Dispose();
                simconnect = null;
                btnConnectToggle.Image = Flowcort.Properties.Resources.Disconnected32;
            }
        } 

        private void initClientEvent()
        {
            try
            {
                // listen to connect and quit msgs 
                simconnect.OnRecvOpen += new SimConnect.RecvOpenEventHandler(simconnect_OnRecvOpen);
                simconnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(simconnect_OnRecvQuit);

                // listen to exceptions 
                simconnect.OnRecvException += new SimConnect.RecvExceptionEventHandler(simconnect_OnRecvException);

                // listen to events 
                simconnect.OnRecvEvent += new SimConnect.RecvEventEventHandler(simconnect_OnRecvEvent);

                // subscribe to Flowcort Prior Item, Next Item and Done/Undone Toggle events 
                simconnect.MapClientEventToSimEvent(EVENTS.KEY_PRESSURIZATION_PRESSURE_ALT_INC, "PRESSURIZATION_PRESSURE_ALT_INC");
                simconnect.AddClientEventToNotificationGroup(NOTIFICATION_GROUPS.GROUP0, EVENTS.KEY_PRESSURIZATION_PRESSURE_ALT_INC, false);

                simconnect.MapClientEventToSimEvent(EVENTS.KEY_PRESSURIZATION_PRESSURE_ALT_DEC, "PRESSURIZATION_PRESSURE_ALT_DEC");
                simconnect.AddClientEventToNotificationGroup(NOTIFICATION_GROUPS.GROUP0, EVENTS.KEY_PRESSURIZATION_PRESSURE_ALT_DEC, false);

                simconnect.MapClientEventToSimEvent(EVENTS.KEY_PRESSURIZATION_PRESSURE_DUMP_SWITCH, "PRESSURIZATION_PRESSURE_DUMP_SWITCH");
                simconnect.AddClientEventToNotificationGroup(NOTIFICATION_GROUPS.GROUP0, EVENTS.KEY_PRESSURIZATION_PRESSURE_DUMP_SWITCH, false);

                simconnect.MapClientEventToSimEvent(EVENTS.KEY_TOGGLE_PROPELLER_DEICE, "TOGGLE_PROPELLER_DEICE");
                simconnect.AddClientEventToNotificationGroup(NOTIFICATION_GROUPS.GROUP0, EVENTS.KEY_TOGGLE_PROPELLER_DEICE, false);            

                // set the group priority 
                simconnect.SetNotificationGroupPriority(NOTIFICATION_GROUPS.GROUP0, SimConnect.SIMCONNECT_GROUP_PRIORITY_HIGHEST);

                // define a data structure 
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Title", null, SIMCONNECT_DATATYPE.STRING256, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Latitude", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Longitude", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Altitude", "feet", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                // IMPORTANT: register it with the simconnect managed wrapper marshaller 
                // if you skip this step, you will only receive a uint in the .dwData field. 
                simconnect.RegisterDataDefineStruct<Struct1>(DEFINITIONS.Struct1);

                // catch a simobject data request 
                simconnect.OnRecvSimobjectDataBytype += new SimConnect.RecvSimobjectDataBytypeEventHandler(simconnect_OnRecvSimobjectDataBytype);

            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void simconnect_OnRecvSimobjectDataBytype(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
        {

            switch ((DATA_REQUESTS)data.dwRequestID)
            {
                case DATA_REQUESTS.REQUEST_1:
                    Struct1 s1 = (Struct1)data.dwData[0];
                    txtbxRemarks.Text = "";

                    txtbxRemarks.Text += "\r\nTitle: " + s1.title;
                    txtbxRemarks.Text += "\r\nLat:   " + s1.latitude;
                    txtbxRemarks.Text += "\r\nLon:   " + s1.longitude;
                    txtbxRemarks.Text += "\r\nAlt:   " + s1.altitude;
                    break;

                default:
                    txtbxRemarks.Text += "Unknown request ID: " + data.dwRequestID;
                    break;
            }
        } 

        void simconnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            // MessageBox.Show("Connected to your Flight Sim");
        }

        // The case where the user closes Prepar3D 
        void simconnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            btnConnectToggle.Image = Flowcort.Properties.Resources.Disconnected32;
            closeConnection();
        }

        void simconnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {
            MessageBox.Show("Exception received: " + data.dwException);
        }

        void simconnect_OnRecvEvent(SimConnect sender, SIMCONNECT_RECV_EVENT recEvent)
        {
            switch (recEvent.uEventID)
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
                    nextActionItem(true);
                    break;

            }
        } 

        private void sectionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sectionBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.fSXSE_A321_TutorialDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.sectionTableAdapter1.Fill(this.fSXSE_A321_TutorialDataSet.Section);
            this.itemTableAdapter1.Fill(this.fSXSE_A321_TutorialDataSet.Item);

            itemDataGridView1.ScrollBars = ScrollBars.None;
            lblFSEvents.Text = "";
            this.TopMost = true;

            if (this.FormBorderStyle != System.Windows.Forms.FormBorderStyle.None)
            {
                // btnSettings.Visible = false;
                // btnExit.Visible = false;
            }

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

        //TODO Rework this method to use the FSXConnect object
        private void btnConnectToggle_Click(object sender, EventArgs e)
        {
            if (simconnect == null)
            {
                try
                {
                    // the constructor is similar to SimConnect_Open in the native API 
                    simconnect = new SimConnect("Managed Client Events", this.Handle, WM_USER_SIMCONNECT, null, 0);
                    btnConnectToggle.Image = Flowcort.Properties.Resources.Connected32;
                    initClientEvent();

                }
                catch (COMException ex)
                {
                    MessageBox.Show("Unable to connect to your Flight Simulator " + ex.Message);
                }
            }
            else
            {
                closeConnection();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            simconnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_1, DEFINITIONS.Struct1, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
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

            for (int i = 0; i < pnlSectionButtons.Controls.Count; i++)
            {
                Button btn = pnlSectionButtons.Controls[i] as Button;

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
            for (int i = 0; i < pnlSectionButtons.Controls.Count; i++)
            {
                Button btn = pnlSectionButtons.Controls[i] as Button;
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

                button3.Location = new Point(58, 276);
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

                button3.Location = new Point(259, 199);
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
