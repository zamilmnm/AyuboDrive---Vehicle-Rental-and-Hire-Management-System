using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string UserName = UserNameBox.Text;
            string Password = PasswordBox.Text;

            if (UserName == "z" && Password == "123")
            {


                this.Hide();

                //create object for DashBoard
                Dashboard obj = new Dashboard();
                obj.Show();
            }

            else
            {
                MessageBox.Show("login failed!");
            }
        }

        private void loginExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
