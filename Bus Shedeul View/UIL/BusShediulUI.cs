using Bus_Shedeul_View.BLL;
using Bus_Shedeul_View.DAL.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Shedeul_View.UIL
{
    public partial class BusShediulUI : Form
    {
        private string BusName = "";
        public BusShediulUI()
        {
            InitializeComponent();
            PopulateGridView();
            BusCmBoxGetData();
            DriverCmBoxGetData();
            HelperCmBoxGetData();
            LocationCmBoxGetData();
            TypeCmBoxGetData();
        }

        private void PopulateGridView()
        {
            DataTable dt = new DataTable();
            BusShedulBL busBLOBj = new BusShedulBL();
            dt = busBLOBj.GetExistingdBusShedulBL();
            busShedulDataGridView.DataSource = dt;
        }



        private void SAVEButton_Click(object sender, EventArgs e)
        {

            BusShedul aShedul = new BusShedul();

            aShedul.BusName = busTextBox.Text;
            aShedul.NoOfSeat = seatTextBox.Text;
            aShedul.TypeOfTrip = typeTextBox.Text;
            aShedul.StartFrom = locate1TextBox.Text;
            aShedul.ArriveTo = locate2TextBox.Text;
            aShedul.DriverName = driverNameTextBox.Text;
            aShedul.DriverContact = contactTextBox.Text;
            aShedul.HelperName = helperNameTextBox.Text;
            aShedul.HelperContact = contact2TextBox.Text;
            aShedul.Time = timePicker.Text;

            BusShedulBL busBLOBj = new BusShedulBL();
            bool result = busBLOBj.SaveNewBusShedulBL(aShedul);

            if (result)
            {
                MessageBox.Show("Successfully added new Schedule!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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
            BusShedul aShedul = new BusShedul();
            aShedul.BusName = busTextBox.Text;
            aShedul.NoOfSeat = seatTextBox.Text;
            aShedul.TypeOfTrip = typeTextBox.Text;
            aShedul.StartFrom = locate1TextBox.Text;
            aShedul.ArriveTo = locate2TextBox.Text;
            aShedul.DriverName = driverNameTextBox.Text;
            aShedul.DriverContact = contactTextBox.Text;
            aShedul.HelperName = helperNameTextBox.Text;
            aShedul.HelperContact = contact2TextBox.Text;
            aShedul.Time = timePicker.Text;

            BusShedulBL busBLOBj = new BusShedulBL();
            bool result = busBLOBj.UpdateNewBusShedulBL(aShedul);

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
            BusShedul aShedul = new BusShedul();
            aShedul.BusName = busTextBox.Text;
            aShedul.NoOfSeat = seatTextBox.Text;
            aShedul.TypeOfTrip = typeTextBox.Text;
            aShedul.StartFrom = locate1TextBox.Text;
            aShedul.ArriveTo = locate2TextBox.Text;
            aShedul.DriverName = driverNameTextBox.Text;
            aShedul.DriverContact = contactTextBox.Text;
            aShedul.HelperName = helperNameTextBox.Text;
            aShedul.HelperContact = contact2TextBox.Text;
            aShedul.Time = timePicker.Text;

            BusShedulBL busBLOBj = new BusShedulBL();
            bool result = busBLOBj.DeleteBusShedulBL(aShedul);

            if (result)
            {
                MessageBox.Show("Successfully Deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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
            this.Hide();
        }

        public void CleanTextBar()
        {
            busTextBox.Text = "";
            locate1TextBox.Text = "";
            locate2TextBox.Text = "";
            driverNameTextBox.Text = "";
            contactTextBox.Text = "";
            typeTextBox.Text = "";
            helperNameTextBox.Text = "";
            contact2TextBox.Text = "";
            seatTextBox.Text = "";
        }

        public void IntitialButtonMood()
        {
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            cancelButton.Enabled = false;
            SAVEButton.Enabled = true;
            BackButton.Enabled = true;
        }

        private void busShedulDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            busShedulDataGridView.ClearSelection();
            IntitialButtonMood();
            CleanTextBar();
        }

        private void busShedulDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (busShedulDataGridView.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = busShedulDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow SelectedRow = busShedulDataGridView.Rows[SelectedRowIndex];

                BusName = Convert.ToString(SelectedRow.Cells["BusName"].Value);
                string StartFrom = Convert.ToString(SelectedRow.Cells["StartFrom"].Value);
                string ArriveTo = Convert.ToString(SelectedRow.Cells["ArriveTo"].Value);
                string Time = Convert.ToString(SelectedRow.Cells["Time"].Value);
                string DriverName = Convert.ToString(SelectedRow.Cells["DriverName"].Value);
                string Contact = Convert.ToString(SelectedRow.Cells["DriverContact"].Value);

                string HelperName = Convert.ToString(SelectedRow.Cells["HelperName"].Value);
                string Contact2 = Convert.ToString(SelectedRow.Cells["HelperContact"].Value);
                string NoOfSeat = Convert.ToString(SelectedRow.Cells["SeatCapacity"].Value);
                string Type = Convert.ToString(SelectedRow.Cells["TypeOfTrip"].Value);

                busTextBox.Text = BusName;
                locate1TextBox.Text = StartFrom;
                locate2TextBox.Text = ArriveTo;
                timePicker.Text = Time;
                driverNameTextBox.Text = DriverName;
                contactTextBox.Text = Contact;
                helperNameTextBox.Text = HelperName;
                contact2TextBox.Text = Contact2;
                seatTextBox.Text = NoOfSeat;
                typeTextBox.Text = Type;

                updateButton.Enabled = true;
                deleteButton.Enabled = true;
                cancelButton.Enabled = true;
                SAVEButton.Enabled = false;
                BackButton.Enabled = false;

            }
        }


        public void BusCmBoxGetData()
        {
            busComboBox.Items.Clear();
            locate1ComboBox.Items.Clear();
            SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
            string query = "SELECT * from BusTable";
            //string query2 = "SELECT * from LocationTable";
            SqlCommand command = new SqlCommand(query, con);
            // SqlCommand command2 = new SqlCommand(query2, con);
            command.ExecuteNonQuery();
            // command2.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                busComboBox.Items.Add(dr["BusName"].ToString());
                // locate1ComboBox.Items.Add(dr["BusNo"].ToString());
                // locate1TextBox.Text = ;
            }

        }


        public void DriverCmBoxGetData()
        {
            driverNameComboBox.Items.Clear();
            SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
            string query = "SELECT * from DriverTable";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                driverNameComboBox.Items.Add(dr["DriverName"].ToString());
            }

        }

        public void HelperCmBoxGetData()
        {
            helperNameComboBox.Items.Clear();
            SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
            string query = "SELECT * from HelperTable";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                helperNameComboBox.Items.Add(dr["HelperName"].ToString());
            }

        }
        public void LocationCmBoxGetData()
        {
            locate1ComboBox.Items.Clear();
            locate2ComboBox.Items.Clear();
            SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
            string query = "SELECT * from LocationTable";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                 locate1ComboBox.Items.Add(dr["Location"].ToString());
                locate2ComboBox.Items.Add(dr["Location"].ToString());
            }

        }

        public void TypeCmBoxGetData()
        {
            typeComboBox.Items.Clear();
            SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
            string query = "SELECT * from TypeTable";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                typeComboBox.Items.Add(dr["TypeName"].ToString());
            }
        }
        private void busComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
            string query = "SELECT * from BusTable WHERE BusName = '"+busComboBox.SelectedItem.ToString()+"'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                busTextBox.Text = dr["BusName"].ToString();
                seatTextBox.Text = dr["NoOfSeat"].ToString();
            }
        }


        private void driverNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
            string query = "SELECT * from DriverTable WHERE DriverName = '" + driverNameComboBox.SelectedItem.ToString() + "'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                driverNameTextBox.Text = dr["DriverName"].ToString();
                contactTextBox.Text = dr["ContactNo"].ToString();
            }
        }

        private void helperNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
            string query = "SELECT * from HelperTable WHERE HelperName = '" + helperNameComboBox.SelectedItem.ToString() + "'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                helperNameTextBox.Text = dr["HelperName"].ToString();
                contact2TextBox.Text = dr["ContactNo"].ToString();
            }
        }

        private void locate1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
            string query = "SELECT * from LocationTable WHERE Location = '" + locate1ComboBox.SelectedItem.ToString() + "'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                locate1TextBox.Text = dr["Location"].ToString();
            }
        }

        private void locate2omboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
            string query = "SELECT * from LocationTable WHERE Location = '" + locate2ComboBox.SelectedItem.ToString() + "'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                locate2TextBox.Text = dr["Location"].ToString();
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
            string query = "SELECT * from TypeTable WHERE  TypeName = '" + typeComboBox.SelectedItem.ToString() + "'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                typeTextBox.Text = dr["TypeName"].ToString();
            }
        }

        private void BusShediulUI_Load(object sender, EventArgs e)
        {

        }

        private void busTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void locate1Label_Click(object sender, EventArgs e)
        {

        }

        private void locate1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void locate2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void locate2Label_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buisLabel_Click(object sender, EventArgs e)
        {

        }

        private void driverNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void driverNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void driverContactLabel_Click(object sender, EventArgs e)
        {

        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
