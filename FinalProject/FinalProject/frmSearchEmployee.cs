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
    public partial class frmSearchEmployee : Form
    {
        EmployeeList myEmpoloyee = new EmployeeList ();
        public frmEmployeeInfo myForm3;
        public frmSearchEmployee(frmEmployeeInfo tform)
        {
            InitializeComponent();
            myForm3 = tform;
            myEmpoloyee = myForm3.allEmployees;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Please enter the ID");
            }
            else
            {
                List<Employee> search = new List<Employee>();
                int searchID = Convert.ToInt32(txtID.Text);
                search.Add(myForm3.allEmployees.GetEmployee(searchID));
                dataGridSearch.DataSource = null;
                dataGridSearch.DataSource = search;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
