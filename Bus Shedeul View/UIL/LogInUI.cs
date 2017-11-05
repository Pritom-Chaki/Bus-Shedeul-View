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
    public partial class LogInUI : Form
    {
        public LogInUI()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            LogIn aLogIn = new LogIn();
            aLogIn.UserName = userNameTextBox.Text;
            aLogIn.Password = passwordTextBox.Text;

            LogInBL logInBLOBj = new LogInBL();
            bool result = logInBLOBj.ValidateLogInAndSendToDA(aLogIn);

            if (result)
            {
                DialogResult dialog = MessageBox.Show("Welcome!  "+userNameTextBox.Text+"", "Successfuly Login",MessageBoxButtons.OK);
                if(dialog == DialogResult.OK)
                {
                    
                    WelcomeUI mainObject = new WelcomeUI();
                    mainObject.Show();
                    this.Hide();
                    // MessageBox.Show("Succesful!!!!");
                }
            }

            else
            {
                DialogResult dialog = MessageBox.Show("Wrong Username or Password!!","ERROR!!",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);

                if (dialog == DialogResult.Retry)
                {
                    userNameTextBox.Clear();
                    passwordTextBox.Clear();
                }
                else if (dialog == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }

        }
  

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogInUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
