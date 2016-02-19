using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flowcort
{
    public partial class ListSelector : Form
    {
        string flowcortTemplate = "FlowcortData";
        string rndFilename = "";

        public ListSelector()
        {
            InitializeComponent();
        }

        private void ListSelector_Load(object sender, EventArgs e)
        {
            ListOfLists();
        }

        private void ListOfLists()
        {
            lstbxFiles.Items.Clear();
            string[] flowcortFiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.fct");

            foreach (String file in flowcortFiles)
                lstbxFiles.Items.Add(Path.GetFileNameWithoutExtension(file));

            int locn = lstbxFiles.FindString(flowcortTemplate);
            if (locn != -1)
                lstbxFiles.Items.RemoveAt(locn);

            lstbxFiles.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                CreateNewDb();
                MakeTextBoxesEditable();
                btnSave.Visible = true;
                nameTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Creation failed with message : " + ex.Message);
            }
        }

        private void CreateNewDb()
        {
            rndFilename = Path.GetRandomFileName();
            File.Copy("FlowcortData.fct", rndFilename);
            listTableAdapter.Connection.ConnectionString = MakeConnectionString(rndFilename);
            this.listTableAdapter.Fill(this.flowcortDataDataSet.List);
            listBindingSource.AddNew();
        }

        private void MakeTextBoxesEditable()
        {
            TextBox a;

            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    a = (TextBox)c;
                    a.ReadOnly = false;
                    a.TabStop = true;
                }
            }
            nameTextBox.Focus();
        }

        private void lstbxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string simAc = lstbxFiles.Items[lstbxFiles.SelectedIndex].ToString();
            listTableAdapter.Connection.ConnectionString = MakeConnectionString(simAc + ".fct");
            LoadListData();
        }

        private string MakeConnectionString(string p)
        {
            return ("data source=|DataDirectory|\\" + p);
        }

        private void LoadListData()
        {
            try
            {
                this.listTableAdapter.Fill(this.flowcortDataDataSet.List);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading data failed with message : " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.listBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.flowcortDataDataSet);

                File.Move(rndFilename, nameTextBox.Text + ".fct");
                File.Delete(rndFilename);
                ListOfLists();

                btnSave.Visible = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Save failed with : " + ex.Message);
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Set the forms ConnectionString and then close down (meaning the data entry form needs to load first)
            this.Hide();
            var de = new Form2();
            de.Closed += (s, args) => this.Close();
            de.ConnectionString = MakeConnectionString(lstbxFiles.SelectedItem.ToString() + ".fct");
            de.Show();
        }
    }
}
