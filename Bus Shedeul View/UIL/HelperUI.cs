using Bus_Shedeul_View.BLL;
using Bus_Shedeul_View.DAL.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Shedeul_View.UIL
{
    public partial class HelperUI : Form
    {
        private string HelperNo = "";
        public HelperUI()
        {
            InitializeComponent();
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            DataTable dt = new DataTable();
            HelperBL helperBLOBj = new HelperBL();
            dt = helperBLOBj.GetExistingdDriverBL();
            helperDataGridView.DataSource = dt;
        }

        private void SAVEButton_Click(object sender, EventArgs e)
        {

            Helper aHelper = new Helper();
            aHelper.HelperNo = helperNoTextBox.Text;
            aHelper.Name = helperNameTextBox.Text;
            aHelper.ContactNo = contactNoTextBox.Text;

            HelperBL helperBLOBj = new HelperBL();
            bool result = helperBLOBj.SaveNewHelperBL(aHelper);

            if (result)
            {
                MessageBox.Show("Successfully added new Driver information.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.PopulateGridView();
                IntitialButtonMood();
                CleanTextBar();
            }

            else
            {

                DialogResult dialog = MessageBox.Show("Please fill all the text.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                if (dialog == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Helper aHelper = new Helper();
            aHelper.HelperNo = helperNoTextBox.Text;
            aHelper.Name = helperNameTextBox.Text;
            aHelper.ContactNo = contactNoTextBox.Text;

            HelperBL helperBLOBj = new HelperBL();
            bool result = helperBLOBj.UpdateNewHelperBL(aHelper);

            if (result)
            {
                MessageBox.Show("Successfully Updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.PopulateGridView();
                IntitialButtonMood();
                CleanTextBar();
            }

            else
            {
                MessageBox.Show("Something went wrong!", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Helper aHelper = new Helper();
            aHelper.HelperNo = helperNoTextBox.Text;
            aHelper.Name = helperNameTextBox.Text;
            aHelper.ContactNo = contactNoTextBox.Text;

            HelperBL helperBLOBj = new HelperBL();
            bool result = helperBLOBj.DeleteHelperBL(aHelper);
            if (result)
            {
                MessageBox.Show("Successfully Deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.PopulateGridView();
                IntitialButtonMood();
                CleanTextBar();
            }

            else
            {
                MessageBox.Show("Something went wrong!", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            IntitialButtonMood();
            CleanTextBar();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CleanTextBar()
        {
            helperNoTextBox.Text = "";
            helperNameTextBox.Text = "";
            contactNoTextBox.Text = "";
        }

        public void IntitialButtonMood()
        {
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            cancelButton.Enabled = false;
            SAVEButton.Enabled = true;
            BackButton.Enabled = true;
        }

        private void helperDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (helperDataGridView.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = helperDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow SelectedRow = helperDataGridView.Rows[SelectedRowIndex];

                HelperNo = Convert.ToString(SelectedRow.Cells["HelperNo"].Value);
                string Name = Convert.ToString(SelectedRow.Cells["HelperName"].Value);
                string Contact = Convert.ToString(SelectedRow.Cells["ContactNo"].Value);
                helperNoTextBox.Text = HelperNo;
                helperNameTextBox.Text = Name;
                contactNoTextBox.Text = Contact;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
                cancelButton.Enabled = true;
                SAVEButton.Enabled = false;
                BackButton.Enabled = false;

            }
        }

        private void helperDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            helperDataGridView.ClearSelection();
            IntitialButtonMood();
            CleanTextBar();
        }
    }
}
