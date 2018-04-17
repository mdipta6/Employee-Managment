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
    public partial class frmFireEmployee : Form
    {
        EmployeeList myEmployee = new EmployeeList();
        public frmEmployeeInfo myForm2;
        public frmFireEmployee(frmEmployeeInfo fForm)
        {
            InitializeComponent();
            myForm2 = fForm;
            myEmployee = myForm2.allEmployees;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            if (IsValidator())
            {
                int deleteID = Convert.ToInt32(txtEmployeeID.Text);

                myForm2.allEmployees.FireEmployee(deleteID);
                myForm2.EmployeeView.DataSource = null;
                myForm2.EmployeeView.DataSource = myForm2.allEmployees.GetList;
            }
        }

        private bool IsValidator()
        {
            return Validator.IsPresent(txtEmployeeID) &&
                   Validator.IsInt32(txtEmployeeID);
        }
    }
}
