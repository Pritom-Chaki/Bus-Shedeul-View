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
    public partial class WelcomeUI : Form
    {
       

        public WelcomeUI()
        {
            //label1.Text =;
              InitializeComponent();
        }



        private void addNewAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdminUI OBJ = new AddAdminUI();
            OBJ.MdiParent = this;
            OBJ.Show();
        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusUI OBJ = new BusUI();
            OBJ.MdiParent = this;
            OBJ.Show();
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverUI OBJ = new DriverUI();
            OBJ.MdiParent = this;
            OBJ.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocationUi OBJ = new LocationUi();
            OBJ.MdiParent = this;
            OBJ.Show();
        }

        private void updateShedulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusShediulUI OBJ = new BusShediulUI();
            OBJ.MdiParent = this;
            OBJ.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Realy Want to Logout!", "LOGOUT", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {

            }

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangedPasswordUI OBJ = new ChangedPasswordUI();
            OBJ.MdiParent = this;
            OBJ.Show();
        }

      

        private void WelcomeUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Realy Want to Exit!", "EXIT", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
               // e.Cancel = true;
            }
        }

        private void addStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusUI OBJ = new StatusUI();
            OBJ.MdiParent = this;
            OBJ.Show();
        }

        private void viewScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showOnMonitor2();
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

        private void helperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperUI OBJ = new HelperUI();
            OBJ.MdiParent = this;
            OBJ.Show();
        }

        private void typeOfTripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeOfTripUI OBJ = new TypeOfTripUI();
            OBJ.MdiParent = this;
            OBJ.Show();
        }
    }
}
