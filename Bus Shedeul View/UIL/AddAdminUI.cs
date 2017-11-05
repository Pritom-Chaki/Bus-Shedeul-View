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
    public partial class AddAdminUI : Form
    {
        public AddAdminUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddAdmin aAddAdmin = new AddAdmin();
            aAddAdmin.UserName = nameTextBox.Text;
            aAddAdmin.Password = passwordTextBox.Text;
            aAddAdmin.Role = rollTextBox.Text;

            AddAdminBL AddAdminBLOBj = new AddAdminBL();
            bool result = AddAdminBLOBj.AddAdminToDB(aAddAdmin);

            if (result)
            {
                MessageBox.Show("Successfully Added new User!", "DONE");
                nameTextBox.Clear();
                passwordTextBox.Clear();
                rollTextBox.Clear();
            }
            else
            {
               DialogResult dialog = MessageBox.Show("Please fill all the text","ERROR",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                if(dialog == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void rollLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
