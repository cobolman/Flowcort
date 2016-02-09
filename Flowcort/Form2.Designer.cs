namespace Flowcort
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.buttonBar1 = new ButtonBar.ButtonBar();
            this.btnResetSection = new System.Windows.Forms.Button();
            this.itemDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValToSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Subsection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fSXSE_A321_TutorialDataSet = new Flowcort.FSXSE_A321_TutorialDataSet();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblFSEvents = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtbxRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.btnAltitude = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConnectToggle = new System.Windows.Forms.Button();
            this.sectionTableAdapter1 = new Flowcort.FSXSE_A321_TutorialDataSetTableAdapters.SectionTableAdapter();
            this.tableAdapterManager1 = new Flowcort.FSXSE_A321_TutorialDataSetTableAdapters.TableAdapterManager();
            this.itemTableAdapter1 = new Flowcort.FSXSE_A321_TutorialDataSetTableAdapters.ItemTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSXSE_A321_TutorialDataSet)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hUDToolStripMenuItem,
            this.dataEntryToolStripMenuItem,
            this.refreshDataToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 70);
            // 
            // hUDToolStripMenuItem
            // 
            this.hUDToolStripMenuItem.Checked = true;
            this.hUDToolStripMenuItem.CheckOnClick = true;
            this.hUDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hUDToolStripMenuItem.Name = "hUDToolStripMenuItem";
            this.hUDToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.hUDToolStripMenuItem.Text = "HUD";
            this.hUDToolStripMenuItem.Click += new System.EventHandler(this.hUDToolStripMenuItem_Click);
            // 
            // dataEntryToolStripMenuItem
            // 
            this.dataEntryToolStripMenuItem.Name = "dataEntryToolStripMenuItem";
            this.dataEntryToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.dataEntryToolStripMenuItem.Text = "Data Entry";
            this.dataEntryToolStripMenuItem.Click += new System.EventHandler(this.dataEntryToolStripMenuItem_Click);
            // 
            // refreshDataToolStripMenuItem
            // 
            this.refreshDataToolStripMenuItem.Name = "refreshDataToolStripMenuItem";
            this.refreshDataToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.refreshDataToolStripMenuItem.Text = "Refresh Data";
            this.refreshDataToolStripMenuItem.Click += new System.EventHandler(this.refreshDataToolStripMenuItem_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.buttonBar1);
            this.pnlGrid.Controls.Add(this.btnResetSection);
            this.pnlGrid.Controls.Add(this.itemDataGridView1);
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(600, 316);
            this.pnlGrid.TabIndex = 17;
            // 
            // buttonBar1
            // 
            this.buttonBar1.Location = new System.Drawing.Point(0, 0);
            this.buttonBar1.Name = "buttonBar1";
            this.buttonBar1.Size = new System.Drawing.Size(600, 38);
            this.buttonBar1.TabIndex = 11;
            this.buttonBar1.ButtonPush += new System.EventHandler(this.btnSection);
            // 
            // btnResetSection
            // 
            this.btnResetSection.Location = new System.Drawing.Point(4, 276);
            this.btnResetSection.Name = "btnResetSection";
            this.btnResetSection.Size = new System.Drawing.Size(75, 36);
            this.btnResetSection.TabIndex = 10;
            this.btnResetSection.Text = "Reset Section";
            this.btnResetSection.UseVisualStyleBackColor = true;
            this.btnResetSection.Click += new System.EventHandler(this.btnResetSection_Click);
            // 
            // itemDataGridView1
            // 
            this.itemDataGridView1.AllowUserToAddRows = false;
            this.itemDataGridView1.AllowUserToDeleteRows = false;
            this.itemDataGridView1.AllowUserToResizeRows = false;
            this.itemDataGridView1.AutoGenerateColumns = false;
            this.itemDataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.itemDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.itemDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.itemDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.ValToSet,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.Event,
            this.Subsection,
            this.Done,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.itemDataGridView1.DataSource = this.itemBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemDataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.itemDataGridView1.EnableHeadersVisualStyles = false;
            this.itemDataGridView1.Location = new System.Drawing.Point(4, 46);
            this.itemDataGridView1.MultiSelect = false;
            this.itemDataGridView1.Name = "itemDataGridView1";
            this.itemDataGridView1.ReadOnly = true;
            this.itemDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.itemDataGridView1.RowHeadersVisible = false;
            this.itemDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itemDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemDataGridView1.Size = new System.Drawing.Size(596, 224);
            this.itemDataGridView1.TabIndex = 0;
            this.itemDataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.itemDataGridView1_DataBindingComplete);
            this.itemDataGridView1.SelectionChanged += new System.EventHandler(this.itemDataGridView1_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn10.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SectionID";
            this.dataGridViewTextBoxColumn11.HeaderText = "SectionID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn12.HeaderText = "Location";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn12.Width = 126;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Area";
            this.dataGridViewTextBoxColumn13.HeaderText = "Area";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn13.Width = 191;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Part";
            this.dataGridViewTextBoxColumn14.HeaderText = "Part";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn14.Width = 120;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Action";
            this.dataGridViewTextBoxColumn15.HeaderText = "Action";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn15.Width = 60;
            // 
            // ValToSet
            // 
            this.ValToSet.DataPropertyName = "ValToSet";
            this.ValToSet.HeaderText = "Value";
            this.ValToSet.Name = "ValToSet";
            this.ValToSet.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "CoP";
            this.dataGridViewCheckBoxColumn3.HeaderText = "CoP";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Visible = false;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Turnaround";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Turnaround";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            this.dataGridViewCheckBoxColumn4.Visible = false;
            // 
            // Event
            // 
            this.Event.DataPropertyName = "Event";
            this.Event.HeaderText = "Event";
            this.Event.Name = "Event";
            this.Event.ReadOnly = true;
            this.Event.Visible = false;
            // 
            // Subsection
            // 
            this.Subsection.DataPropertyName = "Subsection";
            this.Subsection.HeaderText = "Subsection";
            this.Subsection.Name = "Subsection";
            this.Subsection.ReadOnly = true;
            this.Subsection.Visible = false;
            // 
            // Done
            // 
            this.Done.DataPropertyName = "Done";
            this.Done.HeaderText = "Done";
            this.Done.Name = "Done";
            this.Done.ReadOnly = true;
            this.Done.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Image1";
            this.dataGridViewTextBoxColumn16.HeaderText = "Image1";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Image2";
            this.dataGridViewTextBoxColumn17.HeaderText = "Image2";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Image3";
            this.dataGridViewTextBoxColumn18.HeaderText = "Image3";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Audio";
            this.dataGridViewTextBoxColumn19.HeaderText = "Audio";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Video";
            this.dataGridViewTextBoxColumn20.HeaderText = "Video";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn21.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "FK_Item_0_0";
            this.itemBindingSource1.DataSource = this.sectionBindingSource1;
            this.itemBindingSource1.PositionChanged += new System.EventHandler(this.itemBindingSource_PositionChanged);
            // 
            // sectionBindingSource1
            // 
            this.sectionBindingSource1.DataMember = "Section";
            this.sectionBindingSource1.DataSource = this.fSXSE_A321_TutorialDataSet;
            this.sectionBindingSource1.PositionChanged += new System.EventHandler(this.sectionBindingSource1_PositionChanged);
            // 
            // fSXSE_A321_TutorialDataSet
            // 
            this.fSXSE_A321_TutorialDataSet.DataSetName = "FSXSE_A321_TutorialDataSet";
            this.fSXSE_A321_TutorialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.lblFSEvents);
            this.pnlDetail.Controls.Add(this.button1);
            this.pnlDetail.Controls.Add(this.numericUpDown1);
            this.pnlDetail.Controls.Add(this.txtbxRemarks);
            this.pnlDetail.Controls.Add(this.lblRemarks);
            this.pnlDetail.Controls.Add(this.btnAltitude);
            this.pnlDetail.Controls.Add(this.button4);
            this.pnlDetail.Controls.Add(this.pictureBox2);
            this.pnlDetail.Controls.Add(this.pictureBox1);
            this.pnlDetail.Controls.Add(this.btnConnectToggle);
            this.pnlDetail.Location = new System.Drawing.Point(605, 3);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(400, 316);
            this.pnlDetail.TabIndex = 18;
            // 
            // lblFSEvents
            // 
            this.lblFSEvents.AutoSize = true;
            this.lblFSEvents.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFSEvents.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFSEvents.Location = new System.Drawing.Point(127, 8);
            this.lblFSEvents.Name = "lblFSEvents";
            this.lblFSEvents.Size = new System.Drawing.Size(131, 29);
            this.lblFSEvents.TabIndex = 27;
            this.lblFSEvents.Text = "FS Events";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Flowcort.Properties.Resources.Rotate32;
            this.button1.Location = new System.Drawing.Point(43, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 26;
            this.toolTip1.SetToolTip(this.button1, "Connect to flight sim");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnLandscapeOrPortrait);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numericUpDown1.Location = new System.Drawing.Point(360, 8);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(30, 29);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtbxRemarks
            // 
            this.txtbxRemarks.BackColor = System.Drawing.SystemColors.Control;
            this.txtbxRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxRemarks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource1, "Remarks", true));
            this.txtbxRemarks.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtbxRemarks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbxRemarks.Location = new System.Drawing.Point(4, 73);
            this.txtbxRemarks.Multiline = true;
            this.txtbxRemarks.Name = "txtbxRemarks";
            this.txtbxRemarks.ReadOnly = true;
            this.txtbxRemarks.Size = new System.Drawing.Size(179, 197);
            this.txtbxRemarks.TabIndex = 22;
            this.txtbxRemarks.Text = "This is test text";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRemarks.Location = new System.Drawing.Point(3, 51);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(60, 13);
            this.lblRemarks.TabIndex = 21;
            this.lblRemarks.Text = "REMARKS";
            // 
            // btnAltitude
            // 
            this.btnAltitude.Location = new System.Drawing.Point(58, 276);
            this.btnAltitude.Name = "btnAltitude";
            this.btnAltitude.Size = new System.Drawing.Size(75, 37);
            this.btnAltitude.TabIndex = 21;
            this.btnAltitude.Text = "ALT";
            this.btnAltitude.UseVisualStyleBackColor = true;
            this.btnAltitude.Click += new System.EventHandler(this.btnAltitude_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Image = global::Flowcort.Properties.Resources.Settings24;
            this.button4.Location = new System.Drawing.Point(83, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 38);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(188, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(188, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // btnConnectToggle
            // 
            this.btnConnectToggle.BackColor = System.Drawing.SystemColors.Control;
            this.btnConnectToggle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnConnectToggle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConnectToggle.Image = global::Flowcort.Properties.Resources.Disconnected32;
            this.btnConnectToggle.Location = new System.Drawing.Point(3, 3);
            this.btnConnectToggle.Name = "btnConnectToggle";
            this.btnConnectToggle.Size = new System.Drawing.Size(38, 38);
            this.btnConnectToggle.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnConnectToggle, "Connect to flight sim");
            this.btnConnectToggle.UseVisualStyleBackColor = false;
            this.btnConnectToggle.Click += new System.EventHandler(this.btnConnectToggle_Click);
            // 
            // sectionTableAdapter1
            // 
            this.sectionTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ItemTableAdapter = this.itemTableAdapter1;
            this.tableAdapterManager1.ListTableAdapter = null;
            this.tableAdapterManager1.SectionTableAdapter = this.sectionTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Flowcort.FSXSE_A321_TutorialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 323);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlGrid);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Flowcort";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSXSE_A321_TutorialDataSet)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hUDToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRemarks;
        private FSXSE_A321_TutorialDataSet fSXSE_A321_TutorialDataSet;
        private System.Windows.Forms.BindingSource sectionBindingSource1;
        private FSXSE_A321_TutorialDataSetTableAdapters.SectionTableAdapter sectionTableAdapter1;
        private FSXSE_A321_TutorialDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private FSXSE_A321_TutorialDataSetTableAdapters.ItemTableAdapter itemTableAdapter1;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.DataGridView itemDataGridView1;
        private System.Windows.Forms.TextBox txtbxRemarks;
        private System.Windows.Forms.ToolStripMenuItem dataEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDataToolStripMenuItem;
        private System.Windows.Forms.Button btnConnectToggle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAltitude;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFSEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValToSet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Event;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Subsection;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Done;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.Button btnResetSection;
        private ButtonBar.ButtonBar buttonBar1;
    }
}