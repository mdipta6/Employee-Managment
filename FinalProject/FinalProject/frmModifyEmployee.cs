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
    public partial class frmModifyEmployee : Form
    {
        EmployeeList myEmployee = new EmployeeList();
        public frmEmployeeInfo myForm4;
        public frmModifyEmployee(frmEmployeeInfo mform)
        {
            InitializeComponent();
            myForm4 = mform;
            myEmployee = myForm4.allEmployees;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (IsValidator())
            {
                string ID = txtID.Text;
                string Name = txtName.Text;
                string SSN = txtSocialSecurity.Text;
                string HourlyRate = txtHourlyRate.Text;
                string HoursWorked = txtHoursWorked.Text;

                myEmployee.ModifyEmployee(ID, Name, SSN, HourlyRate, HoursWorked);
                dataGridModify.DataSource = null;
                dataGridModify.DataSource = myEmployee.GetList;
            }
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
