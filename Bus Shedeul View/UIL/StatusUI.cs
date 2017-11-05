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
    public partial class StatusUI : Form
    {
        private string StatusNo = "";
        public StatusUI()
        {
            InitializeComponent();
            PopulateGridView();
        }
        private void PopulateGridView()
        {
            DataTable dt = new DataTable();
            StatusBL statusBLOBj = new StatusBL();
            dt = statusBLOBj.GetExistingdStatusBL();
            statusDataGridView.DataSource = dt;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Status aStatus = new Status();
            aStatus.StatusNo = textBox1.Text;
            aStatus.StatusPosition = statusPositionTextBox.Text;
            aStatus.Statusdetails = richTextBox.Text;
            StatusBL statusBLOBj = new StatusBL();
            bool result = statusBLOBj.UpdateNewStatusBL(aStatus);

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
    

        private void cancelButton_Click(object sender, EventArgs e)
        {
        IntitialButtonMood();
        CleanTextBar();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }

    public void CleanTextBar()
    {
         textBox1.Text = "";
        statusPositionTextBox.Text = "";
            richTextBox.Text = "";
    }

    public void IntitialButtonMood()
    {
        updateButton.Enabled = false;
        //deleteButton.Enabled = false;
        cancelButton.Enabled = false;
        //SAVEButton.Enabled = true;
        BackButton.Enabled = true;
    }


        private void statusDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            statusDataGridView.ClearSelection();
            IntitialButtonMood();
            CleanTextBar();
        }

        private void statusDataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            if (statusDataGridView.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = statusDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow SelectedRow = statusDataGridView.Rows[SelectedRowIndex];

                StatusNo = Convert.ToString(SelectedRow.Cells["No"].Value);
                string Possition = Convert.ToString(SelectedRow.Cells["Possition"].Value);
                string Status = Convert.ToString(SelectedRow.Cells["Status"].Value);
                 textBox1.Text = StatusNo;
                statusPositionTextBox.Text = Possition;
                richTextBox.Text = Status;

                updateButton.Enabled = true;
               // deleteButton.Enabled = true;
                cancelButton.Enabled = true;
                //SAVEButton.Enabled = false;
                BackButton.Enabled = false;
            }
        }

       
    }
}
