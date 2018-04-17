using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace FinalProject
{
    public class Employee
    {
        ///this contains properties and attributes of a product
        private int id;
        private string name;
        private string ssn;
        private decimal hourlyRate;
        private decimal hoursWorked;
        private decimal grossPay;
        private decimal netPay;
        //Default Constructor
        public Employee() { }

        //overload constructor
        public Employee(int id, string name, string ssn, decimal hourlyRate, decimal hoursWorked, decimal grossPay, decimal netPay)
        {
          
            this.ID = id;
            this.Name = name;
            this.SSN = ssn;
            this.HourlyRate = hourlyRate;
            this.HoursWorked = hoursWorked;
            this.GrossPay = grossPay;
            this.NetPay = netPay;
            Console.WriteLine(this.NetPay);
           
            calcNetPay();
            Console.WriteLine(this.NetPay);
        }

        public decimal NetPay
        {
            get
            {
                return netPay;
            }
            set
            {
                netPay = value;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string SSN
        {
            get
            {
                return ssn;
            }
            set
            {
                ssn = value;
            }
        }
        public decimal HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                hourlyRate = value;
            }
        }
        public decimal HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                hoursWorked = value;
            }
        }
        public decimal GrossPay
        {
            get
            {
                return grossPay;
            }
            set
            {
                
                grossPay = hourlyRate * hoursWorked * 52;
                calcNetPay();
            }
        }

        public decimal calcNetPay()
        {
            if (grossPay > 0 && grossPay <= 9275)
            {
                netPay = grossPay * Convert.ToDecimal(0.90);
            }
            else if (grossPay >= 9276 && grossPay <= 37650)
            {
                netPay = grossPay * Convert.ToDecimal(0.85);
            }
            else if (grossPay >= 37651 && grossPay <= 91150)
            {
                netPay = grossPay * Convert.ToDecimal(0.75);
            }
            else if (grossPay >= 91151 && grossPay <= 190150)
            {
                netPay = grossPay * Convert.ToDecimal(0.72);
            }
            else if (grossPay >= 190151 && grossPay <= 413350)
            {
                netPay = grossPay * Convert.ToDecimal(0.67);
            }
            else if (grossPay >= 413351 && grossPay <= 415050)
            {
                netPay = grossPay * Convert.ToDecimal(0.65);
            }
            else 
            {
                netPay = grossPay * Convert.ToDecimal(0.60);
            }
            return netPay;
        }

        public static Employee LoadEmployee(SqlDataReader EmployeeSqlDataReader)
        {
            int EmployeeIdColPos = EmployeeSqlDataReader.GetOrdinal("EmployeeId");
            int NameColPos = EmployeeSqlDataReader.GetOrdinal("Name");
            int SSNColPos = EmployeeSqlDataReader.GetOrdinal("SocialSecurity");
            int HourlyRateColPos = EmployeeSqlDataReader.GetOrdinal("HourlyRate");
            int HoursWorkedColPos = EmployeeSqlDataReader.GetOrdinal("HoursWorked");
            int GrossPayColPos = EmployeeSqlDataReader.GetOrdinal("GrossPay");
            int NetPayPayColPos = EmployeeSqlDataReader.GetOrdinal("NetPay");

            int ID = EmployeeSqlDataReader.GetInt32((EmployeeIdColPos));

            SqlString Name = EmployeeSqlDataReader.GetSqlString(NameColPos);

            SqlString SSN = EmployeeSqlDataReader.GetSqlString(SSNColPos);

            decimal HourlyRate = EmployeeSqlDataReader.GetDecimal((HourlyRateColPos));

            decimal HoursWorked = EmployeeSqlDataReader.GetDecimal(HoursWorkedColPos);

            decimal GrossPay = EmployeeSqlDataReader.GetDecimal(GrossPayColPos);

            decimal NetPay = EmployeeSqlDataReader.GetDecimal(NetPayPayColPos);

            Employee a = new Employee(ID, Convert.ToString(Name), Convert.ToString(SSN), HourlyRate, HoursWorked, GrossPay, NetPay);
            return a;
        }
    }
}
