using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace FinalProject
{
    public class EmployeeList
    {
        private List<Employee> Employees = new List<Employee>();
        dbConnection login = new dbConnection();
        private string tableName;
        public string TableName
        {
            get
            {
                return tableName;
            }
            set
            {
                tableName = value;
            }
        }

        public List<Employee> GetList
        {
            get
            {
                return Employees;
            }
            set
            {
                Employees = value;
            }
        }
       
        public void Clear()
        {
            Employees.Clear();
        }
        
        //Adds employee to the list
        public void AddEmployee(Employee e)
        {
            Employees.Add(e);
        }

        public void loadEmployees()
        {
            Employees.Clear();
            SqlConnection connect = new SqlConnection(login.ConnectionString);
            SqlCommand commandName = new SqlCommand("", connect);
            commandName.CommandText = "SELECT * " +
                                      "FROM " + tableName;
          
            try
            {
                connect.Open();
               
                SqlDataReader EmployeeSqlDataReader = commandName.ExecuteReader();
                while (EmployeeSqlDataReader.Read()!=false)
                {
                    //sqlreader is null and is trying to store null inside of the values of each employee
                    Employees.Add(Employee.LoadEmployee(EmployeeSqlDataReader));
                    
                }
                Console.WriteLine("ITS CLOSING");
                EmployeeSqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            finally
            {   
                connect.Close();
            }
        }

        //Adds the employee information to the sql database
        public void AddEmployee(int ID, string Name, string SSN, decimal HourlyRate, decimal HoursWorked)
        {

            Employee e = new Employee(ID, Name, SSN, HourlyRate, HoursWorked, 0,0);
            e.GrossPay = 0;
            
            Employees.Add(e);

            SqlConnection mySqlConnection = new SqlConnection(login.ConnectionString);

            SqlCommand commandDatabase = new SqlCommand("", mySqlConnection);
            commandDatabase.CommandTimeout = 60;
            SqlTransaction transaction;

            // Start a local transaction.
            mySqlConnection.Open();
            transaction = mySqlConnection.BeginTransaction("SampleTransaction");
            commandDatabase.Transaction = transaction;

            try
            {
                commandDatabase.CommandText =
                    "INSERT INTO Employee " + "(EmployeeId, Name, SocialSecurity, HourlyRate, HoursWorked, GrossPay, NetPay)"
                + String.Format("VALUES({0},'{1}','{2}',{3},{4},{5},{6})", ID, Name, SSN, HourlyRate, HoursWorked, e.GrossPay, e.NetPay);
                commandDatabase.ExecuteNonQuery();
                

                // Attempt to commit the transaction.
                transaction.Commit();

            }
            catch (Exception ex)
            {
                Console.WriteLine("This Means commit FAILED");
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);

                // Attempt to roll back the transaction.
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred
                    // on the server that would cause the rollback to fail, such as
                    // a closed connection.
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                    Console.WriteLine("THIS MEANS TRANSACTION RollBACK FAILED");
                }
            }
            transaction = null;
        }

        public Employee GetEmployee(int ID)
        {
            Employee newEmployee = null;
            foreach (var person in Employees)
            {
                if (person.ID.Equals(ID))
                {
                    newEmployee = person;
                }
            }
            return newEmployee;
        }

        public void fireEmployee(int ID)
        {
            SqlConnection mySqlConnection = new SqlConnection(login.ConnectionString);

            SqlCommand commandDatabase = new SqlCommand("", mySqlConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {
                mySqlConnection.Open();

                commandDatabase.CommandText = "INSERT INTO PreviousEmployee " +
                                              "SELECT * " +
                                              "FROM Employee " +
                                              "WHERE EmployeeId = @EmployeeId";
                commandDatabase.Parameters.AddWithValue("@EmployeeId", ID);
                commandDatabase.ExecuteNonQuery();

                commandDatabase.CommandText = "DELETE FROM Employee " +
                                              "WHERE EmployeeId = @EmployeeId";
               
                commandDatabase.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("  Message: {0}", ex.Message);
            }

        }
        
        public void FireEmployee(int id)
        {
            Employee helper = new Employee();
            bool found = false;
            foreach (var person in Employees)
            {
                if (person.ID == id)
                {
                    helper = person;
                    found = true;
                    break;

                }
            }
            if (found == true)
            {
                fireEmployee(id);
                Employees.Remove(helper);
            }
        }

        //this is another required method for this project, to save inventory to csv file
        public void ModifyEmployee(string id, string name, string ssn, string hourlyRate, string hoursWorked)
        {
            Employee helper = new Employee();
            // bool found = false;
            foreach (var person in Employees)
            {
                if (person.ID == Convert.ToInt32(id))
                {
                    person.ID = Convert.ToInt32(id);
                    person.Name = name;
                    person.SSN = ssn;
                    person.HourlyRate = Convert.ToDecimal(hourlyRate);
                    person.HoursWorked = Convert.ToDecimal(hoursWorked);

                    // found = true;
                    break;
                }
            }
            modifyEmployee(id, name, ssn, hourlyRate, hoursWorked);
        }

        public void modifyEmployee(string id, string name, string ssn, string hourlyRate, string hoursWorked)
        {
            SqlConnection mySqlConnection = new SqlConnection(login.ConnectionString);

            SqlCommand commandDatabase = new SqlCommand("", mySqlConnection);
            commandDatabase.CommandTimeout = 60;
            mySqlConnection.Open();
          
            try
            {
                string full = "UPDATE Employee ";
                string s = "SET ";
                string w = " WHERE EmployeeId = " + id;
                bool hasComma = false;

                if (name != "")
                {
                    if (hasComma != false)
                    {
                        s = s + " ,";

                    }

                    s = s + "Name = '" + name + "'";
                    hasComma = true;

                }
                if (ssn != "")
                {

                    if (hasComma != false)
                    {
                        s = s + " ,";

                    }
                    s = s + " SocialSecurity = '" + ssn + "'";
                    hasComma = true;
                }
                if (hourlyRate != "")
                {
                    if (hasComma != false)
                    {
                        s = s + " ,";

                    }
                    s = s + " HourlyRate = " + hourlyRate;
                    hasComma = true;
                }
                if (hoursWorked != "")
                {
                    if (hasComma != false)
                    {
                        s = s + " ,";

                    }
                    s = s + " HoursWorked = " + hoursWorked;
                    hasComma = true;
                }

                full = full + s + w;
                Console.WriteLine(full);
                commandDatabase.CommandText = full;
                commandDatabase.ExecuteNonQuery();
                ModifyEmployee(id, name, ssn, hourlyRate, hoursWorked);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);

                // Attempt to roll back the transaction.
                try
                {

                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred
                    // on the server that would cause the rollback to fail, such as
                    // a closed connection.
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
            }
            Console.WriteLine("FLAG3");
            mySqlConnection.Close();
        }

        public void allEmployee()
        {
            Employees.Clear();
            SqlConnection connect = new SqlConnection(login.ConnectionString);
            SqlCommand commandName = new SqlCommand("", connect);
            commandName.CommandText = "SELECT * FROM Employee " +
                                      "UNION ALL " +
                                      "SELECT * FROM PreviousEmployee";
            try
            {
                connect.Open();

                SqlDataReader EmployeeSqlDataReader = commandName.ExecuteReader();
                
                while (EmployeeSqlDataReader.Read() != false)
                {
                    Employees.Add(Employee.LoadEmployee(EmployeeSqlDataReader));
                }
                
                EmployeeSqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
    }   
}
