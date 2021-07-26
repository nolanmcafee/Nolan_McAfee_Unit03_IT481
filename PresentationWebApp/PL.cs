using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using PresentationWebApp;
//using System.Configuration.Assemblies;

namespace PresentationWebApp
{
    public class PL
    {
        private BLL busLogic;
        private List<string> results;
        private int customerCount;
        private string connection;
        
        

        //private string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True"; //KNOWN GOOD CONFIGURATION
        //private string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;User ID=User_Sales;Password=User_Sales";
        //connection = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

        public PL(string UserID, string Password, string Table)
        {
            connection = BuildConnectionString(UserID, Password);

            try
            {
                busLogic = new BLL(connection, Table);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }


            results = busLogic.getResultsTable();
        }
        


        public List<string> Results()
        {
            return results;
        }

        public int Count()
        {
            return customerCount;
        }

        private string BuildConnectionString(string UserID, string Password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder["Data Source"] = "localhost\\SQLEXPRESS";
            builder["Initial Catalog"] = "Northwind";
            builder["User ID"] = UserID;
            builder["Password"] = Password;

            return builder.ConnectionString;
        }
    }
}
