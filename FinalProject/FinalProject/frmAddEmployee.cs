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
    public partial class frmAddEmployee : Form
    {
      
        public frmEmployeeInfo firstForm;
        public frmAddEmployee(frmEmployeeInfo helper)
        {
            InitializeComponent();
            firstForm = helper;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidator())
            {
                Employee newE = new Employee();
                int t1 = Convert.ToInt32(txtID.Text);
                string s1 = Convert.ToString(txtName.Text);
                string s2 = Convert.ToString(txtSocialSecurity.Text);
                decimal t2 = Convert.ToDecimal(txtHourlyRate.Text);
                decimal t3 = Convert.ToDecimal(txtHoursWorked.Text);

                firstForm.allEmployees.AddEmployee(t1, s1, s2, t2, t3);
                firstForm.EmployeeView.DataSource = null;
                firstForm.EmployeeView.DataSource = firstForm.allEmployees.GetList;

            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValidator()
        {
            return Validator.IsPresent(txtID) &&
                   Validator.IsPresent(txtName) &&
                   Validator.IsPresent(txtSocialSecurity) &&
                   Validator.IsPresent(txtHourlyRate) &&
                   Validator.IsPresent(txtHoursWorked) &&
                   Validator.IsInt32(txtID) &&
                   Validator.IsDecimal(txtHourlyRate) &&
                   Validator.IsDecimal(txtHoursWorked);
                    
        }
    }
}
