namespace Flowcort
{
    partial class ListSelector
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label flightSimLabel;
            System.Windows.Forms.Label flightSimVersionLabel;
            System.Windows.Forms.Label aircraftManufacturerLabel;
            System.Windows.Forms.Label aircraftModelLabel;
            System.Windows.Forms.Label simManufacturerLabel;
            System.Windows.Forms.Label simModelLabel;
            System.Windows.Forms.Label simVersionLabel;
            System.Windows.Forms.Label flowcortVersionLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label versionLabel;
            this.flowcortDataDataSet = new Flowcort.FlowcortDataSet();
            this.listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listTableAdapter = new Flowcort.FlowcortDataSetTableAdapters.ListTableAdapter();
            this.tableAdapterManager = new Flowcort.FlowcortDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.flightSimTextBox = new System.Windows.Forms.TextBox();
            this.flightSimVersionTextBox = new System.Windows.Forms.TextBox();
            this.aircraftManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.aircraftModelTextBox = new System.Windows.Forms.TextBox();
            this.simManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.simModelTextBox = new System.Windows.Forms.TextBox();
            this.simVersionTextBox = new System.Windows.Forms.TextBox();
            this.flowcortVersionTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.lstbxFiles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            flightSimLabel = new System.Windows.Forms.Label();
            flightSimVersionLabel = new System.Windows.Forms.Label();
            aircraftManufacturerLabel = new System.Windows.Forms.Label();
            aircraftModelLabel = new System.Windows.Forms.Label();
            simManufacturerLabel = new System.Windows.Forms.Label();
            simModelLabel = new System.Windows.Forms.Label();
            simVersionLabel = new System.Windows.Forms.Label();
            flowcortVersionLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            versionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flowcortDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(239, 28);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // flightSimLabel
            // 
            flightSimLabel.AutoSize = true;
            flightSimLabel.Location = new System.Drawing.Point(239, 54);
            flightSimLabel.Name = "flightSimLabel";
            flightSimLabel.Size = new System.Drawing.Size(55, 13);
            flightSimLabel.TabIndex = 5;
            flightSimLabel.Text = "Flight Sim:";
            // 
            // flightSimVersionLabel
            // 
            flightSimVersionLabel.AutoSize = true;
            flightSimVersionLabel.Location = new System.Drawing.Point(239, 80);
            flightSimVersionLabel.Name = "flightSimVersionLabel";
            flightSimVersionLabel.Size = new System.Drawing.Size(93, 13);
            flightSimVersionLabel.TabIndex = 7;
            flightSimVersionLabel.Text = "Flight Sim Version:";
            // 
            // aircraftManufacturerLabel
            // 
            aircraftManufacturerLabel.AutoSize = true;
            aircraftManufacturerLabel.Location = new System.Drawing.Point(239, 106);
            aircraftManufacturerLabel.Name = "aircraftManufacturerLabel";
            aircraftManufacturerLabel.Size = new System.Drawing.Size(109, 13);
            aircraftManufacturerLabel.TabIndex = 9;
            aircraftManufacturerLabel.Text = "Aircraft Manufacturer:";
            // 
            // aircraftModelLabel
            // 
            aircraftModelLabel.AutoSize = true;
            aircraftModelLabel.Location = new System.Drawing.Point(239, 132);
            aircraftModelLabel.Name = "aircraftModelLabel";
            aircraftModelLabel.Size = new System.Drawing.Size(75, 13);
            aircraftModelLabel.TabIndex = 11;
            aircraftModelLabel.Text = "Aircraft Model:";
            // 
            // simManufacturerLabel
            // 
            simManufacturerLabel.AutoSize = true;
            simManufacturerLabel.Location = new System.Drawing.Point(239, 158);
            simManufacturerLabel.Name = "simManufacturerLabel";
            simManufacturerLabel.Size = new System.Drawing.Size(93, 13);
            simManufacturerLabel.TabIndex = 13;
            simManufacturerLabel.Text = "Sim Manufacturer:";
            // 
            // simModelLabel
            // 
            simModelLabel.AutoSize = true;
            simModelLabel.Location = new System.Drawing.Point(239, 184);
            simModelLabel.Name = "simModelLabel";
            simModelLabel.Size = new System.Drawing.Size(59, 13);
            simModelLabel.TabIndex = 15;
            simModelLabel.Text = "Sim Model:";
            // 
            // simVersionLabel
            // 
            simVersionLabel.AutoSize = true;
            simVersionLabel.Location = new System.Drawing.Point(239, 210);
            simVersionLabel.Name = "simVersionLabel";
            simVersionLabel.Size = new System.Drawing.Size(65, 13);
            simVersionLabel.TabIndex = 17;
            simVersionLabel.Text = "Sim Version:";
            // 
            // flowcortVersionLabel
            // 
            flowcortVersionLabel.AutoSize = true;
            flowcortVersionLabel.Location = new System.Drawing.Point(239, 236);
            flowcortVersionLabel.Name = "flowcortVersionLabel";
            flowcortVersionLabel.Size = new System.Drawing.Size(88, 13);
            flowcortVersionLabel.TabIndex = 19;
            flowcortVersionLabel.Text = "Flowcort Version:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(239, 262);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 21;
            typeLabel.Text = "Type:";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new System.Drawing.Point(239, 288);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new System.Drawing.Size(64, 13);
            versionLabel.TabIndex = 23;
            versionLabel.Text = "List Version:";
            // 
            // flowcortDataDataSet
            // 
            this.flowcortDataDataSet.DataSetName = "FlowcortDataDataSet";
            this.flowcortDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBindingSource
            // 
            this.listBindingSource.DataMember = "List";
            this.listBindingSource.DataSource = this.flowcortDataDataSet;
            // 
            // listTableAdapter
            // 
            this.listTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.ListTableAdapter = this.listTableAdapter;
            this.tableAdapterManager.SectionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Flowcort.FlowcortDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(354, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(186, 20);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TabStop = false;
            // 
            // flightSimTextBox
            // 
            this.flightSimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listBindingSource, "FlightSim", true));
            this.flightSimTextBox.Location = new System.Drawing.Point(354, 51);
            this.flightSimTextBox.Name = "flightSimTextBox";
            this.flightSimTextBox.ReadOnly = true;
            this.flightSimTextBox.Size = new System.Drawing.Size(186, 20);
            this.flightSimTextBox.TabIndex = 6;
            this.flightSimTextBox.TabStop = false;
            // 
            // flightSimVersionTextBox
            // 
            this.flightSimVersionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listBindingSource, "FlightSimVersion", true));
            this.flightSimVersionTextBox.Location = new System.Drawing.Point(354, 77);
            this.flightSimVersionTextBox.Name = "flightSimVersionTextBox";
            this.flightSimVersionTextBox.ReadOnly = true;
            this.flightSimVersionTextBox.Size = new System.Drawing.Size(50, 20);
            this.flightSimVersionTextBox.TabIndex = 8;
            this.flightSimVersionTextBox.TabStop = false;
            // 
            // aircraftManufacturerTextBox
            // 
            this.aircraftManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listBindingSource, "AircraftManufacturer", true));
            this.aircraftManufacturerTextBox.Location = new System.Drawing.Point(354, 103);
            this.aircraftManufacturerTextBox.Name = "aircraftManufacturerTextBox";
            this.aircraftManufacturerTextBox.ReadOnly = true;
            this.aircraftManufacturerTextBox.Size = new System.Drawing.Size(186, 20);
            this.aircraftManufacturerTextBox.TabIndex = 10;
            this.aircraftManufacturerTextBox.TabStop = false;
            // 
            // aircraftModelTextBox
            // 
            this.aircraftModelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listBindingSource, "AircraftModel", true));
            this.aircraftModelTextBox.Location = new System.Drawing.Point(354, 129);
            this.aircraftModelTextBox.Name = "aircraftModelTextBox";
            this.aircraftModelTextBox.ReadOnly = true;
            this.aircraftModelTextBox.Size = new System.Drawing.Size(186, 20);
            this.aircraftModelTextBox.TabIndex = 12;
            this.aircraftModelTextBox.TabStop = false;
            // 
            // simManufacturerTextBox
            // 
            this.simManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listBindingSource, "SimManufacturer", true));
            this.simManufacturerTextBox.Location = new System.Drawing.Point(354, 155);
            this.simManufacturerTextBox.Name = "simManufacturerTextBox";
            this.simManufacturerTextBox.ReadOnly = true;
            this.simManufacturerTextBox.Size = new System.Drawing.Size(186, 20);
            this.simManufacturerTextBox.TabIndex = 14;
            this.simManufacturerTextBox.TabStop = false;
            // 
            // simModelTextBox
            // 
            this.simModelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listBindingSource, "SimModel", true));
            this.simModelTextBox.Location = new System.Drawing.Point(354, 181);
            this.simModelTextBox.Name = "simModelTextBox";
            this.simModelTextBox.ReadOnly = true;
            this.simModelTextBox.Size = new System.Drawing.Size(186, 20);
            this.simModelTextBox.TabIndex = 16;
            this.simModelTextBox.TabStop = false;
            // 
            // simVersionTextBox
            // 
            this.simVersionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listBindingSource, "SimVersion", true));
            this.simVersionTextBox.Location = new System.Drawing.Point(354, 207);
            this.simVersionTextBox.Name = "simVersionTextBox";
            this.simVersionTextBox.ReadOnly = true;
            this.simVersionTextBox.Size = new System.Drawing.Size(100, 20);
            this.simVersionTextBox.TabIndex = 18;
            this.simVersionTextBox.TabStop = false;
            // 
            // flowcortVersionTextBox
            // 
            this.flowcortVersionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listBindingSource, "FlowcortVersion", true));
            this.flowcortVersionTextBox.Location = new System.Drawing.Point(354, 233);
            this.flowcortVersionTextBox.Name = "flowcortVersionTextBox";
            this.flowcortVersionTextBox.ReadOnly = true;
            this.flowcortVersionTextBox.Size = new System.Drawing.Size(100, 20);
            this.flowcortVersionTextBox.TabIndex = 20;
            this.flowcortVersionTextBox.TabStop = false;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(354, 259);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(186, 20);
            this.typeTextBox.TabIndex = 22;
            this.typeTextBox.TabStop = false;
            // 
            // versionTextBox
            // 
            this.versionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listBindingSource, "Version", true));
            this.versionTextBox.Location = new System.Drawing.Point(354, 285);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.ReadOnly = true;
            this.versionTextBox.Size = new System.Drawing.Size(186, 20);
            this.versionTextBox.TabIndex = 24;
            this.versionTextBox.TabStop = false;
            // 
            // lstbxFiles
            // 
            this.lstbxFiles.FormattingEnabled = true;
            this.lstbxFiles.Location = new System.Drawing.Point(15, 25);
            this.lstbxFiles.Name = "lstbxFiles";
            this.lstbxFiles.Size = new System.Drawing.Size(212, 277);
            this.lstbxFiles.TabIndex = 27;
            this.lstbxFiles.SelectedIndexChanged += new System.EventHandler(this.lstbxFiles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "My Flowcort Files";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(15, 311);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 29;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(152, 311);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 30;
            this.btnCreate.Text = "Create New";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(354, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ListSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 340);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbxFiles);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(flightSimLabel);
            this.Controls.Add(this.flightSimTextBox);
            this.Controls.Add(flightSimVersionLabel);
            this.Controls.Add(this.flightSimVersionTextBox);
            this.Controls.Add(aircraftManufacturerLabel);
            this.Controls.Add(this.aircraftManufacturerTextBox);
            this.Controls.Add(aircraftModelLabel);
            this.Controls.Add(this.aircraftModelTextBox);
            this.Controls.Add(simManufacturerLabel);
            this.Controls.Add(this.simManufacturerTextBox);
            this.Controls.Add(simModelLabel);
            this.Controls.Add(this.simModelTextBox);
            this.Controls.Add(simVersionLabel);
            this.Controls.Add(this.simVersionTextBox);
            this.Controls.Add(flowcortVersionLabel);
            this.Controls.Add(this.flowcortVersionTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(versionLabel);
            this.Controls.Add(this.versionTextBox);
            this.Name = "ListSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Selector";
            this.Load += new System.EventHandler(this.ListSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flowcortDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowcortDataSet flowcortDataDataSet;
        private System.Windows.Forms.BindingSource listBindingSource;
        private FlowcortDataSetTableAdapters.ListTableAdapter listTableAdapter;
        private FlowcortDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox flightSimTextBox;
        private System.Windows.Forms.TextBox flightSimVersionTextBox;
        private System.Windows.Forms.TextBox aircraftManufacturerTextBox;
        private System.Windows.Forms.TextBox aircraftModelTextBox;
        private System.Windows.Forms.TextBox simManufacturerTextBox;
        private System.Windows.Forms.TextBox simModelTextBox;
        private System.Windows.Forms.TextBox simVersionTextBox;
        private System.Windows.Forms.TextBox flowcortVersionTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.ListBox lstbxFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSave;
    }
}