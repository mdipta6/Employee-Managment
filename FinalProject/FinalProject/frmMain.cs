using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmMain : Form
    {
        UserList login = new UserList();
        public frmMain()
        {
            InitializeComponent();
        }

        public UserList allUsers = new UserList();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UN = Convert.ToString(txtUsername.Text);
            string PW = Convert.ToString(txtPassword.Text);
            if(login.UserLogin(UN, PW))
            {
                frmEmployeeInfo form = new frmEmployeeInfo();
                form.Show();
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }

        }
    }
}
