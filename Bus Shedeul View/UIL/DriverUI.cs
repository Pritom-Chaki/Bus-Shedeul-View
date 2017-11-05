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

namespace Bus_Shedeul_View
{
    public partial class DriverUI : Form
    {
        private string DriverNo = "";
        public DriverUI()
        {
            InitializeComponent();
            PopulateGridView();
        }

        

        private void PopulateGridView()
        {
            DataTable dt = new DataTable();
            DriverBL driverBLOBj = new DriverBL();
            dt = driverBLOBj.GetExistingdDriverBL();
            driverDataGridView.DataSource = dt;
        }

        private void SAVEButton_Click(object sender, EventArgs e)
        {
            Driver aDriver = new Driver();
            aDriver.DriverNo = driverNoTextBox.Text;
            aDriver.Name = driverNameTextBox.Text;
            aDriver.ContactNo = contactNoTextBox.Text;
            DriverBL driverBLOBj = new DriverBL();
            bool result = driverBLOBj.SaveNewDriverBL(aDriver);

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
            Driver aDriver = new Driver();
            aDriver.DriverNo = driverNoTextBox.Text;
            aDriver.Name = driverNameTextBox.Text;
            aDriver.ContactNo = contactNoTextBox.Text;
            DriverBL driverBLOBj = new DriverBL();
            bool result = driverBLOBj.UpdateNewDriverBL(aDriver);

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

            Driver aDriver = new Driver();
            aDriver.DriverNo = driverNoTextBox.Text;
            aDriver.Name = driverNameTextBox.Text;
            aDriver.ContactNo = contactNoTextBox.Text;
            DriverBL driverBLOBj = new DriverBL();
            bool result = driverBLOBj.DeleteADriverBL(aDriver);

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
            driverNoTextBox.Text = "";
            driverNameTextBox.Text = "";
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

        private void driverDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (driverDataGridView.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = driverDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow SelectedRow = driverDataGridView.Rows[SelectedRowIndex];

                DriverNo = Convert.ToString(SelectedRow.Cells["DriverNo"].Value);
                string Name = Convert.ToString(SelectedRow.Cells["DriverName"].Value);
                string Contact = Convert.ToString(SelectedRow.Cells["ContactNo"].Value);
                driverNoTextBox.Text = DriverNo;
                driverNameTextBox.Text = Name;
                contactNoTextBox.Text = Contact;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
                cancelButton.Enabled = true;
                SAVEButton.Enabled = false;
                BackButton.Enabled = false;

            }
        }

        private void driverDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           driverDataGridView.ClearSelection();
            IntitialButtonMood();
            CleanTextBar();
        }
    }
}
