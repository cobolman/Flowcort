namespace Flowcort
{
    partial class FastDataEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastDataEntry));
            this.sectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fSXSE_A321_TutorialDataSet = new Flowcort.FSXSE_A321_TutorialDataSet();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sectionTableAdapter1 = new Flowcort.FSXSE_A321_TutorialDataSetTableAdapters.SectionTableAdapter();
            this.tableAdapterManager1 = new Flowcort.FSXSE_A321_TutorialDataSetTableAdapters.TableAdapterManager();
            this.itemTableAdapter1 = new Flowcort.FSXSE_A321_TutorialDataSetTableAdapters.ItemTableAdapter();
            this.txtbxSection = new System.Windows.Forms.TextBox();
            this.itemDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValToSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Subsection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteImage1 = new System.Windows.Forms.Button();
            this.btnDeleteImage2 = new System.Windows.Forms.Button();
            this.btnPrior = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtbxRemarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSXSE_A321_TutorialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sectionBindingSource1
            // 
            this.sectionBindingSource1.DataMember = "Section";
            this.sectionBindingSource1.DataSource = this.fSXSE_A321_TutorialDataSet;
            this.sectionBindingSource1.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.sectionBindingSource1_AddingNew);
            // 
            // fSXSE_A321_TutorialDataSet
            // 
            this.fSXSE_A321_TutorialDataSet.DataSetName = "FSXSE_A321_TutorialDataSet";
            this.fSXSE_A321_TutorialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "FK_Item_0_0";
            this.itemBindingSource1.DataSource = this.sectionBindingSource1;
            this.itemBindingSource1.PositionChanged += new System.EventHandler(this.itemBindingSource1_PositionChanged);
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
            // txtbxSection
            // 
            this.txtbxSection.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionBindingSource1, "Description", true));
            this.txtbxSection.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSection.Location = new System.Drawing.Point(49, 4);
            this.txtbxSection.Name = "txtbxSection";
            this.txtbxSection.Size = new System.Drawing.Size(498, 37);
            this.txtbxSection.TabIndex = 14;
            // 
            // itemDataGridView1
            // 
            this.itemDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemDataGridView1.AutoGenerateColumns = false;
            this.itemDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Position,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.ValToSet,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.Event,
            this.Subsection,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.itemDataGridView1.DataSource = this.itemBindingSource1;
            this.itemDataGridView1.Location = new System.Drawing.Point(5, 47);
            this.itemDataGridView1.Name = "itemDataGridView1";
            this.itemDataGridView1.RowHeadersVisible = false;
            this.itemDataGridView1.Size = new System.Drawing.Size(706, 274);
            this.itemDataGridView1.TabIndex = 15;
            this.itemDataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.itemDataGridView1_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SectionID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SectionID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Posn";
            this.Position.Name = "Position";
            this.Position.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn3.HeaderText = "Location";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 126;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Area";
            this.dataGridViewTextBoxColumn13.HeaderText = "Area";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 191;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Part";
            this.dataGridViewTextBoxColumn14.HeaderText = "Part";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 141;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Action";
            this.dataGridViewTextBoxColumn15.HeaderText = "Action";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 60;
            // 
            // ValToSet
            // 
            this.ValToSet.DataPropertyName = "ValToSet";
            this.ValToSet.HeaderText = "Value";
            this.ValToSet.Name = "ValToSet";
            this.ValToSet.Width = 50;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "CoP";
            this.dataGridViewCheckBoxColumn3.HeaderText = "CoP";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Visible = false;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Turnaround";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Turnaround";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Visible = false;
            // 
            // Event
            // 
            this.Event.DataPropertyName = "Event";
            this.Event.HeaderText = "Event";
            this.Event.Name = "Event";
            this.Event.Width = 40;
            // 
            // Subsection
            // 
            this.Subsection.DataPropertyName = "Subsection";
            this.Subsection.HeaderText = "Sub";
            this.Subsection.Name = "Subsection";
            this.Subsection.Width = 40;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Image1";
            this.dataGridViewTextBoxColumn16.HeaderText = "Image1";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Image2";
            this.dataGridViewTextBoxColumn17.HeaderText = "Image2";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Image3";
            this.dataGridViewTextBoxColumn18.HeaderText = "Image3";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Audio";
            this.dataGridViewTextBoxColumn19.HeaderText = "Audio";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Video";
            this.dataGridViewTextBoxColumn20.HeaderText = "Video";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn21.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Visible = false;
            this.dataGridViewTextBoxColumn21.Width = 245;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(970, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox2_DragDrop);
            this.pictureBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox2_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(970, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(970, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Image 1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(970, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Image 2";
            // 
            // btnDeleteImage1
            // 
            this.btnDeleteImage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteImage1.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteImage1.Image")));
            this.btnDeleteImage1.Location = new System.Drawing.Point(1152, 21);
            this.btnDeleteImage1.Name = "btnDeleteImage1";
            this.btnDeleteImage1.Size = new System.Drawing.Size(26, 23);
            this.btnDeleteImage1.TabIndex = 22;
            this.btnDeleteImage1.UseVisualStyleBackColor = true;
            this.btnDeleteImage1.Click += new System.EventHandler(this.btnDeleteImage1_Click);
            // 
            // btnDeleteImage2
            // 
            this.btnDeleteImage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteImage2.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteImage2.Image")));
            this.btnDeleteImage2.Location = new System.Drawing.Point(1152, 178);
            this.btnDeleteImage2.Name = "btnDeleteImage2";
            this.btnDeleteImage2.Size = new System.Drawing.Size(26, 23);
            this.btnDeleteImage2.TabIndex = 23;
            this.btnDeleteImage2.UseVisualStyleBackColor = true;
            this.btnDeleteImage2.Click += new System.EventHandler(this.btnDeleteImage2_Click);
            // 
            // btnPrior
            // 
            this.btnPrior.Image = global::Flowcort.Properties.Resources.Prior32;
            this.btnPrior.Location = new System.Drawing.Point(5, 4);
            this.btnPrior.Name = "btnPrior";
            this.btnPrior.Size = new System.Drawing.Size(38, 38);
            this.btnPrior.TabIndex = 24;
            this.btnPrior.UseVisualStyleBackColor = true;
            this.btnPrior.Click += new System.EventHandler(this.btnPrior_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::Flowcort.Properties.Resources.Next32;
            this.btnNext.Location = new System.Drawing.Point(553, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 38);
            this.btnNext.TabIndex = 25;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Flowcort.Properties.Resources.Add32;
            this.btnAdd.Location = new System.Drawing.Point(593, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 38);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Flowcort.Properties.Resources.Delete32;
            this.btnDelete.Location = new System.Drawing.Point(633, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(38, 38);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Flowcort.Properties.Resources.Save32;
            this.btnSave.Location = new System.Drawing.Point(673, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(38, 38);
            this.btnSave.TabIndex = 28;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtbxRemarks
            // 
            this.txtbxRemarks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource1, "Remarks", true));
            this.txtbxRemarks.Location = new System.Drawing.Point(752, 47);
            this.txtbxRemarks.Multiline = true;
            this.txtbxRemarks.Name = "txtbxRemarks";
            this.txtbxRemarks.Size = new System.Drawing.Size(212, 274);
            this.txtbxRemarks.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Remarks";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Image = global::Flowcort.Properties.Resources.Delete32;
            this.btnDeleteItem.Location = new System.Drawing.Point(712, 86);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(38, 38);
            this.btnDeleteItem.TabIndex = 32;
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Image = global::Flowcort.Properties.Resources.Add32;
            this.btnAddItem.Location = new System.Drawing.Point(712, 46);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(38, 38);
            this.btnAddItem.TabIndex = 31;
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // FastDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 327);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxRemarks);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrior);
            this.Controls.Add(this.btnDeleteImage2);
            this.Controls.Add(this.btnDeleteImage1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.itemDataGridView1);
            this.Controls.Add(this.txtbxSection);
            this.Name = "FastDataEntry";
            this.Text = "Fast Data Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FastDataEntry_FormClosing);
            this.Load += new System.EventHandler(this.FastDataEntry_Load);
            this.Shown += new System.EventHandler(this.FastDataEntry_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSXSE_A321_TutorialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FSXSE_A321_TutorialDataSet fSXSE_A321_TutorialDataSet;
        private System.Windows.Forms.BindingSource sectionBindingSource1;
        private FSXSE_A321_TutorialDataSetTableAdapters.SectionTableAdapter sectionTableAdapter1;
        private FSXSE_A321_TutorialDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private FSXSE_A321_TutorialDataSetTableAdapters.ItemTableAdapter itemTableAdapter1;
        private System.Windows.Forms.TextBox txtbxSection;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.DataGridView itemDataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteImage1;
        private System.Windows.Forms.Button btnDeleteImage2;
        private System.Windows.Forms.Button btnPrior;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValToSet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Event;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Subsection;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.TextBox txtbxRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnAddItem;

    }
}