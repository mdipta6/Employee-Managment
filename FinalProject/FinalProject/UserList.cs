using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;

namespace FinalProject
{
    public class UserList
    {
        private List<User> Users = new List<User>();
        dbConnection login = new dbConnection();
        public List<User> GetList
        {
            get
            {
                return Users;
            }
            set
            {
                Users = value;
            }
        }

        public void Clear()
        {
            
            Users.Clear();
        }

        public bool UserLogin(string Username, string Password)
        {
            SqlConnection mySqlConnection = new SqlConnection(login.ConnectionString);

            SqlCommand commandDatabase = new SqlCommand("", mySqlConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                commandDatabase.CommandText = "SELECT * FROM Users " +
                                              "WHERE username = @username " +
                                              "AND password = @password";

                commandDatabase.Parameters.AddWithValue("@username", Username);
                commandDatabase.Parameters.AddWithValue("@password", Password);
                
                mySqlConnection.Open();
                SqlDataReader read = commandDatabase.ExecuteReader();  

                if (read.Read() != false)
                {
                    mySqlConnection.Close();
                    return true;
                  
                }
                else
                {
                    mySqlConnection.Close();
                    return false;
                   
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
