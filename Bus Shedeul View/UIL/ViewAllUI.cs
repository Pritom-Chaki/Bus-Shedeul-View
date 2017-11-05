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
    public partial class ViewAllUI : Form
    {
        public ViewAllUI()
        {
            InitializeComponent();
            timer1.Start();
            BottomLabelGetData();
            TopLeftLabelGetData();
            TopRightLabelGetData();
            lebelTimer.Start();
            //PopulateGridView();
            //refreshhjh()
        }
        public void PopulateGridView()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = DataBaseConnection.OpenAnSqlConnection();
            string query = "select * from ScheduleTable ORDER BY Time";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            adapter.Dispose();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.timeLabel.Text = dateTime.ToLongTimeString();
            this.dateLabel.Text = dateTime.ToLongDateString();
        }

        private void bottomLabel_Click(object sender, EventArgs e)
        {

        }


        public void BottomLabelGetData()
        {
            bottomLabel.Text = "";
            SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
            string query = "SELECT * FROM statusTable WHERE No ='3'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                bottomLabel.Text = (dr["Status"].ToString());
            }

        }

        public void TopRightLabelGetData()
        {
            topRightRichTextBox.Text = "";
            SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
            string query = "SELECT * FROM statusTable WHERE No ='2'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                topRightRichTextBox.Text = (dr["Status"].ToString());
            }

        }



        public void TopLeftLabelGetData()
        {
            topLeftRichTextBox.Text = "";
            SqlConnection con = DataBaseConnection.OpenAnSqlConnection();
            string query = "SELECT * FROM statusTable WHERE No ='1'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                topLeftRichTextBox.Text = (dr["Status"].ToString());
            }

        }


        private void lebelTimer_Tick(object sender, EventArgs e)
        {
            bottomLabel.Location = new Point(bottomLabel.Location.X - 5, bottomLabel.Location.Y);

            if (bottomLabel.Location.X <= 0)
            {
                bottomLabel.Location = new Point(this.Width, bottomLabel.Location.Y);
            }
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void ViewAllUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'busSheduleDataSet.ShedulTable' table. You can move, or remove it, as needed.
            //this.shedulTableTableAdapter1.Fill(this.busSheduleDataSet.ShedulTable);
            // TODO: This line of code loads data into the 'busSheduleDataSet2.ScheduleTable' table. You can move, or remove it, as needed.
            scheduleTableTableAdapter.Fill(busSheduleDataSet2.ScheduleTable);

        }
    }

}