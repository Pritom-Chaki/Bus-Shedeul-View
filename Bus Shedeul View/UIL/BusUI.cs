using Bus_Shedeul_View.BLL;
using Bus_Shedeul_View.DAL.DAO;
using Bus_Shedeul_View.UIL;
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
    public partial class BusUI : Form
    {
        private string BusNo = "";
        public BusUI()
        {
            InitializeComponent();
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            DataTable dt = new DataTable();
            BusBL busBLOBj = new BusBL();
            dt = busBLOBj.GetExistingdBusBL();
            busDataGridView.DataSource = dt;
        }

        private void SAVEButton_Click(object sender, EventArgs e)
        {
            Bus aBus = new Bus();
            aBus.BusNO = busNoTextBox.Text;
            aBus.BusName = busNameTextBox.Text;
            aBus.NoOfSeat = noOfSeatTextBox.Text;
            BusBL busBLOBj = new BusBL();
            bool result = busBLOBj.SaveNewBusBL(aBus);

            if (result)
            {
                MessageBox.Show("Successfully added new Bus!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            Bus aBus = new Bus();
            aBus.BusNO = busNoTextBox.Text;
            aBus.BusName = busNameTextBox.Text;
            aBus.NoOfSeat = noOfSeatTextBox.Text;
            BusBL busBLOBj = new BusBL();
            bool result = busBLOBj.UpdateNewBusBL(aBus);

            if (result)
            {
                MessageBox.Show("Successfully Updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                this.PopulateGridView();
                IntitialButtonMood();
                CleanTextBar();
            }

            else
            {
                MessageBox.Show("Something went Wrong!", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            Bus aBus = new Bus();
            aBus.BusNO = busNoTextBox.Text;
            aBus.BusName = busNameTextBox.Text;
            aBus.NoOfSeat = noOfSeatTextBox.Text;
            BusBL busBLOBj = new BusBL();
            bool result = busBLOBj.DeleteABusBL(aBus);

            if (result)
            {
                MessageBox.Show("Successfully Delete", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.PopulateGridView();
                IntitialButtonMood();
                CleanTextBar();
            }

            else
            {
                MessageBox.Show("Something went Wrong!", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            busNoTextBox.Text = "";
            busNameTextBox.Text = "";
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

        private void busDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (busDataGridView.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = busDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow SelectedRow = busDataGridView.Rows[SelectedRowIndex];

                BusNo = Convert.ToString(SelectedRow.Cells["BusNo"].Value);
                string Name = Convert.ToString(SelectedRow.Cells["BusName"].Value);
                string Seat = Convert.ToString(SelectedRow.Cells["NoOfSeat"].Value);
                busNoTextBox.Text = BusNo;
                busNameTextBox.Text = Name;
                noOfSeatTextBox.Text = Seat;
                
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
                cancelButton.Enabled = true;
                SAVEButton.Enabled = false;
                BackButton.Enabled = false;

            }
        }

        private void busDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            busDataGridView.ClearSelection();
              IntitialButtonMood();
               CleanTextBar();
        }

        private void BusUI_Load(object sender, EventArgs e)
        {

        }

        private void infoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
