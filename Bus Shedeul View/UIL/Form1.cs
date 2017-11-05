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
    public partial class LoginForm : Form
    {
        
        // ViewAllUI obj = (ViewAllUI)Application.OpenForms["ViewAllUI"];
        //  private ViewAllUI myForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ViewAllUI obj = new ViewAllUI();
           // obj.Hide();
            obj.Show();
            // showOnMonitor2();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
           BusShediulUI obj = new BusShediulUI();
            obj.Show();
           // this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StatusUI obj = new StatusUI();
            obj.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BusUI obj = new BusUI();
            obj.Show();
           // this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogInUI obj = new LogInUI();
            obj.Show();
           // this.Hide();
        }

        private void showOnMonitor2()
        {
            Screen[] sc;
            sc = Screen.AllScreens;
            //get all the screen width and heights 
            ViewAllUI f = new ViewAllUI();
            f.FormBorderStyle = FormBorderStyle.None;
            f.Left = sc[1].Bounds.Width;
            f.Top = sc[1].Bounds.Height;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = sc[1].Bounds.Location;
            Point p = new Point(sc[1].Bounds.Location.X, sc[1].Bounds.Location.Y);
            f.Location = p;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewAllUI obj = new ViewAllUI();         
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
           ////WTEST obj = new WTEST();
           // if(obj.Visible == false)
           // {
           //     obj.Visible = true;
           // }
          // obj.Visible = false;
           //obj.Visible = true;
           // obj.Visible = false;

            //new WTEST().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           TypeOfTripUI obj = new TypeOfTripUI();
            obj.Show();
            //WTEST obj = new WTEST();
            //if (obj.Visible == true)
            //{
            //    obj.Hide();
            //}
        }
    }
}
