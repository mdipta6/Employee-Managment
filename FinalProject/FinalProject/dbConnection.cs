using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace FinalProject
{
    public class dbConnection
    {
        private string connectionString = //"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dipta Majumder\\Desktop\\CS391Projects\\FinalProject\\FinalProject\\DB.mdf;Integrated Security = True";
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB.mdf;Integrated Security=True";

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }
    }
}
