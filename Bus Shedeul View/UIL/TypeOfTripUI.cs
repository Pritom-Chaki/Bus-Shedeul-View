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
    public partial class TypeOfTripUI : Form
    {
        private string TypeNo = "";
        public TypeOfTripUI()
        {
            InitializeComponent();
            PopulateGridView();
        }
        private void PopulateGridView()
        {
            DataTable dt = new DataTable();
            TypeOfTripBL typeBLOBj = new TypeOfTripBL();
            dt = typeBLOBj.GetExistingdTypeBL();
            typeOfTripDataGridView.DataSource = dt;
        }
        private void typeNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void SAVEButton_Click(object sender, EventArgs e)
        {
            TypeOfTrip aType = new TypeOfTrip();
            aType.TypeNo = typeNoTextBox.Text;
            aType.TypeName = typeNameTextBox.Text;
            TypeOfTripBL typeBLOBj = new TypeOfTripBL();
            bool result = typeBLOBj.SaveNewTypeBL(aType);

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

        private void updateButton_Click(object sender, EventArgs e)
        {
            TypeOfTrip aType = new TypeOfTrip();
            aType.TypeNo = typeNoTextBox.Text;
            aType.TypeName = typeNameTextBox.Text;
            TypeOfTripBL typeBLOBj = new TypeOfTripBL();
            bool result = typeBLOBj.UpdateNewTypeBL(aType);
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            TypeOfTrip aType = new TypeOfTrip();
            aType.TypeNo = typeNoTextBox.Text;
            aType.TypeName = typeNameTextBox.Text;
            TypeOfTripBL typeBLOBj = new TypeOfTripBL();
            bool result = typeBLOBj.DeleteTypeBL(aType);

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
           typeNameTextBox.Text = "";
            typeNoTextBox.Text = "";
           // noOfSeatTextBox.Text = "";
        }

        public void IntitialButtonMood()
        {
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            cancelButton.Enabled = false;
            SAVEButton.Enabled = true;
            BackButton.Enabled = true;
        }

        private void typeOfTripDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            typeOfTripDataGridView.ClearSelection();
            IntitialButtonMood();
            CleanTextBar();
        }

        private void typeOfTripDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (typeOfTripDataGridView.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = typeOfTripDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow SelectedRow = typeOfTripDataGridView.Rows[SelectedRowIndex];

                TypeNo = Convert.ToString(SelectedRow.Cells["TypeNo"].Value);
                string TypeName = Convert.ToString(SelectedRow.Cells["TypeName"].Value);
                 typeNoTextBox.Text = TypeNo;
                typeNameTextBox.Text = TypeName;

                updateButton.Enabled = true;
                deleteButton.Enabled = true;
                cancelButton.Enabled = true;
                SAVEButton.Enabled = false;
                BackButton.Enabled = false;

            }
        }
    }
}
