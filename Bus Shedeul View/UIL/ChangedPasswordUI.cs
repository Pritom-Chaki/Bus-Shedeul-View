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
    public partial class ChangedPasswordUI : Form
    {
        public ChangedPasswordUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ChangedPassword aPass = new ChangedPassword();
            aPass.UserName = nameTextBox.Text;
            aPass.OldPassword = oldPasswordTextBox.Text;
            aPass.NewPassword = newPasswordTextBox.Text;

            ChangedPasswordBL changPassBLobj = new ChangedPasswordBL();
            bool result = changPassBLobj.ChangePasswordToDB(aPass);

            if (result)
            {
                MessageBox.Show("Successfully Updated Password!", "DONE");
                nameTextBox.Clear();
                oldPasswordTextBox.Clear();
                newPasswordTextBox.Clear();
            }
            else
            {
               DialogResult dialog = MessageBox.Show("Please enter valid Username and Password.","ERROR",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);

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
    }
}
