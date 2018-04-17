using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace FinalProject
{
    public partial class frmEmployeeInfo : Form
    {
        public frmEmployeeInfo()
        {
            InitializeComponent();
        }
        
        public EmployeeList allEmployees = new EmployeeList();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEmployee form = new frmAddEmployee(this);
            form.ShowDialog();
        }
        public DataGridView EmployeeView
        {
            get
            {
                return dataGridEmployeeInfo;
            }
            set
            {
                dataGridEmployeeInfo = value;
            }
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            frmFireEmployee form = new frmFireEmployee(this);
            form.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchEmployee form = new frmSearchEmployee(this);
            form.ShowDialog();
        }

        private void btnCurrentEmp_Click(object sender, EventArgs e)
        {
            allEmployees.TableName = "Employee";
            allEmployees.loadEmployees();
            EmployeeView.DataSource = null;
            EmployeeView.DataSource = allEmployees.GetList;
        }

        private void btnPreviousEmp_Click(object sender, EventArgs e)
        {
            allEmployees.TableName = "PreviousEmployee";
            allEmployees.loadEmployees();
            EmployeeView.DataSource = null;
            EmployeeView.DataSource = allEmployees.GetList;
        }

        private void frmEmployeeInfo_Load(object sender, EventArgs e)
        {
            EmployeeView.AutoGenerateColumns = true;
        }

        private void btnAllEmp_Click(object sender, EventArgs e)
        {
            allEmployees.allEmployee();
            EmployeeView.DataSource = null;
            EmployeeView.DataSource = allEmployees.GetList;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmModifyEmployee form = new frmModifyEmployee(this);
            form.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
