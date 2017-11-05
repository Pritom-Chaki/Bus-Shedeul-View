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
    public partial class LocationUi : Form
    {
        private string LocationName = "";
        public LocationUi()
        {
            InitializeComponent();
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            DataTable dt = new DataTable();
            LocationBL locationBLOBj = new LocationBL();
            dt = locationBLOBj.GetExistingdBusBL();
            locationDataGridView.DataSource = dt;
        }

        private void SAVEButton_Click(object sender, EventArgs e)
        {
            Location aLocation = new Location();
            aLocation.LocationName = locationNameTextBox.Text;
            aLocation.Details = detailsTextBox.Text;
           // aBus.NoOfSeat = int.Parse(noOfSeatTextBox.Text);
            LocationBL locationBLOBj = new LocationBL();
            bool result = locationBLOBj.SaveNewLocationBL(aLocation);

            if (result)
            {
                MessageBox.Show("Succesfuly added new Location!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.PopulateGridView();
                IntitialButtonMood();
                CleanTextBar();
            }

            else
            {
                DialogResult dialog = MessageBox.Show("Please fill all the text", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                if (dialog == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }



        public void CleanTextBar()
        {
            locationNameTextBox.Text = "";
            detailsTextBox.Text = "";
            noOfSeatTextBox.Text = "";
        }

        public void IntitialButtonMood()
        {
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            cancelButton.Enabled = false;
            SAVEButton.Enabled = true;
            BackButton.Enabled = true;
        }

      

        private void locationDataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            if (locationDataGridView.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = locationDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow SelectedRow = locationDataGridView.Rows[SelectedRowIndex];

                LocationName = Convert.ToString(SelectedRow.Cells["Location"].Value);
                // string Name = Convert.ToString(SelectedRow.Cells["BusName"].Value);
                string Details = Convert.ToString(SelectedRow.Cells["Details"].Value);
                locationNameTextBox.Text = LocationName;
                detailsTextBox.Text = Details;
                //noOfSeatTextBox.Text = Seat;

                updateButton.Enabled = true;
                deleteButton.Enabled = true;
                cancelButton.Enabled = true;
                SAVEButton.Enabled = false;
                BackButton.Enabled = false;

            }
        }

        private void locationDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            locationDataGridView.ClearSelection();
            IntitialButtonMood();
            CleanTextBar();
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {

            Location aLocation = new Location();
            aLocation.LocationName = locationNameTextBox.Text;
            aLocation.Details = detailsTextBox.Text;
            // aBus.NoOfSeat = int.Parse(noOfSeatTextBox.Text);
            LocationBL locationBLOBj = new LocationBL();
            bool result = locationBLOBj.UpdateNewLocationBL(aLocation);

            if (result)
            {
                MessageBox.Show("Succesfuly Updated", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.PopulateGridView();
                IntitialButtonMood();
                CleanTextBar();
            }

            else
            {
                MessageBox.Show("Something wrong!", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            Location aLocation = new Location();
            aLocation.LocationName = locationNameTextBox.Text;
            aLocation.Details = detailsTextBox.Text;
            // aBus.NoOfSeat = int.Parse(noOfSeatTextBox.Text);
            LocationBL locationBLOBj = new LocationBL();
            bool result = locationBLOBj.DeleteALocationBL(aLocation);

            if (result)
            {
                MessageBox.Show("Succesfuly Deleted", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.PopulateGridView();
                IntitialButtonMood();
                CleanTextBar();
            }

            else
            {
                MessageBox.Show("Something wrong!", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {

            IntitialButtonMood();
            CleanTextBar();
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
