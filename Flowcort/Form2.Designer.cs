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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.flwButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConnectToggle = new System.Windows.Forms.Button();
            this.btnPortraitOrLandscape = new System.Windows.Forms.Button();
            this.btnResetList = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pctrbxTransparency = new System.Windows.Forms.PictureBox();
            this.btnPin = new System.Windows.Forms.Button();
            this.buttonBar1 = new ButtonBar.ButtonBar();
            this.itemDataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.FlowcortDataSet = new Flowcort.FlowcortDataSet();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.pctrbxRemarks = new System.Windows.Forms.PictureBox();
            this.txtbxRemarks = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imglstTransparency = new System.Windows.Forms.ImageList(this.components);
            this.sectionTableAdapter1 = new Flowcort.FlowcortDataSetTableAdapters.SectionTableAdapter();
            this.tableAdapterManager1 = new Flowcort.FlowcortDataSetTableAdapters.TableAdapterManager();
            this.itemTableAdapter1 = new Flowcort.FlowcortDataSetTableAdapters.ItemTableAdapter();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValToSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Subsection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.flwButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxTransparency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlowcortDataSet)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshDataToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 26);
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
            this.pnlGrid.Controls.Add(this.flwButtonPanel);
            this.pnlGrid.Controls.Add(this.buttonBar1);
            this.pnlGrid.Controls.Add(this.itemDataGridView1);
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(600, 281);
            this.pnlGrid.TabIndex = 17;
            // 
            // flwButtonPanel
            // 
            this.flwButtonPanel.Controls.Add(this.btnConnectToggle);
            this.flwButtonPanel.Controls.Add(this.btnPortraitOrLandscape);
            this.flwButtonPanel.Controls.Add(this.btnResetList);
            this.flwButtonPanel.Controls.Add(this.button2);
            this.flwButtonPanel.Controls.Add(this.pictureBox3);
            this.flwButtonPanel.Controls.Add(this.pctrbxTransparency);
            this.flwButtonPanel.Controls.Add(this.btnPin);
            this.flwButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwButtonPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.flwButtonPanel.Name = "flwButtonPanel";
            this.flwButtonPanel.Size = new System.Drawing.Size(44, 281);
            this.flwButtonPanel.TabIndex = 29;
            this.flwButtonPanel.Visible = false;
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
            // btnPortraitOrLandscape
            // 
            this.btnPortraitOrLandscape.BackColor = System.Drawing.SystemColors.Control;
            this.btnPortraitOrLandscape.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnPortraitOrLandscape.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPortraitOrLandscape.Image = global::Flowcort.Properties.Resources.Rotate32;
            this.btnPortraitOrLandscape.Location = new System.Drawing.Point(3, 47);
            this.btnPortraitOrLandscape.Name = "btnPortraitOrLandscape";
            this.btnPortraitOrLandscape.Size = new System.Drawing.Size(38, 38);
            this.btnPortraitOrLandscape.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnPortraitOrLandscape, "Select portrait or landscape mode");
            this.btnPortraitOrLandscape.UseVisualStyleBackColor = false;
            this.btnPortraitOrLandscape.Click += new System.EventHandler(this.btnLandscapeOrPortrait);
            // 
            // btnResetList
            // 
            this.btnResetList.Image = global::Flowcort.Properties.Resources.StartFromBeginning;
            this.btnResetList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetList.Location = new System.Drawing.Point(3, 91);
            this.btnResetList.Name = "btnResetList";
            this.btnResetList.Size = new System.Drawing.Size(38, 38);
            this.btnResetList.TabIndex = 10;
            this.btnResetList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnResetList, "Restart the entire list from the very beginning");
            this.btnResetList.UseVisualStyleBackColor = true;
            this.btnResetList.Click += new System.EventHandler(this.btnResetList_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Flowcort.Properties.Resources.RestartSection;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 38);
            this.button2.TabIndex = 12;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button2, "Restart just this section");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnResetSection_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 179);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 10);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pctrbxTransparency
            // 
            this.pctrbxTransparency.Image = global::Flowcort.Properties.Resources.rotate0;
            this.pctrbxTransparency.Location = new System.Drawing.Point(3, 195);
            this.pctrbxTransparency.Name = "pctrbxTransparency";
            this.pctrbxTransparency.Size = new System.Drawing.Size(38, 38);
            this.pctrbxTransparency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctrbxTransparency.TabIndex = 27;
            this.pctrbxTransparency.TabStop = false;
            this.toolTip1.SetToolTip(this.pctrbxTransparency, "Rotate to Increase / Decrease");
            this.pctrbxTransparency.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctrbxTransparency_MouseDown);
            this.pctrbxTransparency.MouseEnter += new System.EventHandler(this.pctrbxTransparency_MouseEnter);
            this.pctrbxTransparency.MouseLeave += new System.EventHandler(this.pctrbxTransparency_MouseLeave);
            // 
            // btnPin
            // 
            this.btnPin.Image = global::Flowcort.Properties.Resources.Pin;
            this.btnPin.Location = new System.Drawing.Point(3, 239);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(38, 38);
            this.btnPin.TabIndex = 29;
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // buttonBar1
            // 
            this.buttonBar1.Location = new System.Drawing.Point(0, 0);
            this.buttonBar1.Name = "buttonBar1";
            this.buttonBar1.Size = new System.Drawing.Size(600, 38);
            this.buttonBar1.TabIndex = 11;
            this.toolTip1.SetToolTip(this.buttonBar1, "Select phase of flight");
            this.buttonBar1.ButtonPush += new System.EventHandler(this.btnSection);
            // 
            // itemDataGridView1
            // 
            this.itemDataGridView1.AllowUserToAddRows = false;
            this.itemDataGridView1.AllowUserToDeleteRows = false;
            this.itemDataGridView1.AllowUserToResizeRows = false;
            this.itemDataGridView1.AutoGenerateColumns = false;
            this.itemDataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.itemDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.itemDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.SectionID1,
            this.Position,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.ValToSet,
            this.dataGridViewTextBoxColumn15,
            this.Event,
            this.Subsection,
            this.Done,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.itemDataGridView1.DataSource = this.itemBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemDataGridView1.EnableHeadersVisualStyles = false;
            this.itemDataGridView1.Location = new System.Drawing.Point(2, 44);
            this.itemDataGridView1.MultiSelect = false;
            this.itemDataGridView1.Name = "itemDataGridView1";
            this.itemDataGridView1.ReadOnly = true;
            this.itemDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.itemDataGridView1.RowHeadersVisible = false;
            this.itemDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itemDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemDataGridView1.Size = new System.Drawing.Size(596, 234);
            this.itemDataGridView1.TabIndex = 0;
            this.itemDataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.itemDataGridView1_DataBindingComplete);
            this.itemDataGridView1.SelectionChanged += new System.EventHandler(this.itemDataGridView1_SelectionChanged);
            this.itemDataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.itemDataGridView1_MouseMove);
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
            this.sectionBindingSource1.DataSource = this.FlowcortDataSet;
            this.sectionBindingSource1.PositionChanged += new System.EventHandler(this.sectionBindingSource1_PositionChanged);
            // 
            // FlowcortDataSet
            // 
            this.FlowcortDataSet.DataSetName = "FlowcortDataSet";
            this.FlowcortDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDetail.Controls.Add(this.pctrbxRemarks);
            this.pnlDetail.Controls.Add(this.txtbxRemarks);
            this.pnlDetail.Controls.Add(this.pictureBox2);
            this.pnlDetail.Controls.Add(this.pictureBox1);
            this.pnlDetail.Location = new System.Drawing.Point(600, 3);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(391, 278);
            this.pnlDetail.TabIndex = 18;
            // 
            // pctrbxRemarks
            // 
            this.pctrbxRemarks.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxRemarks.Image")));
            this.pctrbxRemarks.Location = new System.Drawing.Point(1, 1);
            this.pctrbxRemarks.Name = "pctrbxRemarks";
            this.pctrbxRemarks.Size = new System.Drawing.Size(45, 14);
            this.pctrbxRemarks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctrbxRemarks.TabIndex = 23;
            this.pctrbxRemarks.TabStop = false;
            // 
            // txtbxRemarks
            // 
            this.txtbxRemarks.BackColor = System.Drawing.SystemColors.Control;
            this.txtbxRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxRemarks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource1, "Remarks", true));
            this.txtbxRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtbxRemarks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbxRemarks.Location = new System.Drawing.Point(2, 0);
            this.txtbxRemarks.Multiline = true;
            this.txtbxRemarks.Name = "txtbxRemarks";
            this.txtbxRemarks.ReadOnly = true;
            this.txtbxRemarks.Size = new System.Drawing.Size(179, 275);
            this.txtbxRemarks.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Flowcort.Properties.Resources.FlowcortYouTubeBW;
            this.pictureBox2.Location = new System.Drawing.Point(181, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Click for larger version");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flowcort.Properties.Resources.Flowcort208x117BW;
            this.pictureBox1.Location = new System.Drawing.Point(181, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Click for larger version");
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // imglstTransparency
            // 
            this.imglstTransparency.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstTransparency.ImageStream")));
            this.imglstTransparency.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstTransparency.Images.SetKeyName(0, "rotate0.png");
            this.imglstTransparency.Images.SetKeyName(1, "rotate1.png");
            this.imglstTransparency.Images.SetKeyName(2, "rotate2.png");
            this.imglstTransparency.Images.SetKeyName(3, "rotate3.png");
            this.imglstTransparency.Images.SetKeyName(4, "rotate4.png");
            this.imglstTransparency.Images.SetKeyName(5, "rotate5.png");
            this.imglstTransparency.Images.SetKeyName(6, "rotate6.png");
            this.imglstTransparency.Images.SetKeyName(7, "rotate7.png");
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
            this.tableAdapterManager1.UpdateOrder = Flowcort.FlowcortDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Visible = false;
            // 
            // SectionID1
            // 
            this.SectionID1.DataPropertyName = "SectionID1";
            this.SectionID1.HeaderText = "SectionID";
            this.SectionID1.Name = "SectionID1";
            this.SectionID1.ReadOnly = true;
            this.SectionID1.Visible = false;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Visible = false;
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
            // ValToSet
            // 
            this.ValToSet.DataPropertyName = "ValToSet";
            this.ValToSet.HeaderText = "Value";
            this.ValToSet.Name = "ValToSet";
            this.ValToSet.ReadOnly = true;
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
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn10.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(995, 283);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlGrid);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Flowcort";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.flwButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxTransparency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlowcortDataSet)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlowcortDataSet FlowcortDataSet;
        private System.Windows.Forms.BindingSource sectionBindingSource1;
        private FlowcortDataSetTableAdapters.SectionTableAdapter sectionTableAdapter1;
        private FlowcortDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private FlowcortDataSetTableAdapters.ItemTableAdapter itemTableAdapter1;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.DataGridView itemDataGridView1;
        private System.Windows.Forms.TextBox txtbxRemarks;
        private System.Windows.Forms.ToolStripMenuItem refreshDataToolStripMenuItem;
        private System.Windows.Forms.Button btnConnectToggle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnPortraitOrLandscape;
        private System.Windows.Forms.Button btnResetList;
        private ButtonBar.ButtonBar buttonBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pctrbxTransparency;
        private System.Windows.Forms.ImageList imglstTransparency;
        private System.Windows.Forms.FlowLayoutPanel flwButtonPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pctrbxRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValToSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Event;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Subsection;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Done;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    }
}