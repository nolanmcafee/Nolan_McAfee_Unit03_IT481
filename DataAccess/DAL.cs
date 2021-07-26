using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DataObjects;
using System.Dynamic;
using System.Xml.Linq;
using System.Xml;

namespace DataAccess
{
    public class DAL
    {
        private string connectionString;
        private string table;


        public DAL (string ConnectionString, string Table)
        {
            connectionString = ConnectionString;
            table = Table;


        }

        public List<CustomerObject> getAllCustomerData()
        {
            string queryString = "select * from " + table;
            List<CustomerObject> customers = new List<CustomerObject>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                string errorMsg;
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);

                    SqlDataReader reader;
                    try
                    {
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string customerID = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                            string companyName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                            string contactName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                            string contactTitle = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                            string address = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                            string city = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                            string region = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                            string postalCode = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                            string country = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                            string phone = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
                            string fax = reader.IsDBNull(10) ? string.Empty : reader.GetString(10);

                            CustomerObject customer = new CustomerObject(customerID, companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax);

                            customers.Add(customer);
                        }
                        reader.Close();
                    }
                    catch (Exception e)
                    {
                        errorMsg = e.Message;
                        Console.WriteLine(errorMsg);
                        throw;
                    }

                    connection.Close();
                }
                catch (Exception e)
                {
                    errorMsg = e.Message;
                    Console.WriteLine(errorMsg);
                    throw;
                }
            }

            return customers;
        }

        public List<EmployeeObject> getAllEmployeeData()
        {
            string queryString = "select * from " + table;
            List<EmployeeObject> employees = new List<EmployeeObject>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                string errorMsg;
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);

                    SqlDataReader reader;
                    try
                    {
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int employeeID          = reader.IsDBNull (0) ? 0            : reader.GetInt32    (0);
                            string lastName         = reader.IsDBNull (1) ? string.Empty : reader.GetString   (1);
                            string firstName        = reader.IsDBNull (2) ? string.Empty : reader.GetString   (2);
                            string title            = reader.IsDBNull (3) ? string.Empty : reader.GetString   (3);
                            string titleOfCourtesy  = reader.IsDBNull (4) ? string.Empty : reader.GetString   (4);
                            DateTime? birthDate     = reader.IsDBNull (5) ? null         : reader.GetDateTime (5);
                            DateTime? hireDate      = reader.IsDBNull (6) ? null         : reader.GetDateTime (6);
                            string address          = reader.IsDBNull (7) ? string.Empty : reader.GetString   (7);
                            string city             = reader.IsDBNull (8) ? string.Empty : reader.GetString   (8);
                            string region           = reader.IsDBNull (9) ? string.Empty : reader.GetString   (9);
                            string postalCode       = reader.IsDBNull(10) ? string.Empty : reader.GetString  (10);
                            string country          = reader.IsDBNull(11) ? string.Empty : reader.GetString  (11);
                            string homePhone        = reader.IsDBNull(12) ? string.Empty : reader.GetString  (12);
                            decimal salary          = reader.IsDBNull(13) ? 0            : reader.GetDecimal (13);
                            string extension        = reader.IsDBNull(14) ? string.Empty : reader.GetString  (14);
                            //byte[] photo          = reader.IsDBNull(15) ? null         : reader.GetSqlBytes(15);
                            string notes            = reader.IsDBNull(16) ? string.Empty : reader.GetString  (16);
                            int reportsTo           = reader.IsDBNull(17) ? 0            : reader.GetInt32   (17);
                            //string photoPath      = reader.IsDBNull(18) ? string.Empty : reader.GetString  (18);

                            EmployeeObject employee = new EmployeeObject(employeeID, lastName, firstName, title, 
                                titleOfCourtesy, (DateTime)birthDate, (DateTime)hireDate, address, city, region, postalCode, country, homePhone, salary, extension, 
                                /*photo*/ notes, reportsTo/*, photoPath*/);

                            employees.Add(employee);
                        }
                        reader.Close();
                    }
                    catch (Exception e)
                    {
                        errorMsg = e.Message;
                        Console.WriteLine(errorMsg);
                        throw;
                    }

                    connection.Close();
                }
                catch (Exception e)
                {
                    errorMsg = e.Message;
                    Console.WriteLine(errorMsg);
                    throw;
                }
            }

            return employees;
        }

        public List<OrderObject> getAllOrderData()
        {
            string queryString = "select * from " + table;
            List<OrderObject> orders = new List<OrderObject>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                string errorMsg;
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);

                    SqlDataReader reader;
                    try
                    {
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int orderID             = reader.IsDBNull (0) ? 0            : reader.GetInt32   (0);
                            string customerID       = reader.IsDBNull (1) ? string.Empty : reader.GetString  (1);
                            int employeeID          = reader.IsDBNull (2) ? 0            : reader.GetInt32   (2);
                            DateTime? orderDate     = reader.IsDBNull (3) ? DateTime.MinValue         : reader.GetDateTime(3);
                            DateTime? requiredDate  = reader.IsDBNull (4) ? DateTime.MinValue         : reader.GetDateTime(4);
                            DateTime? shippedDate   = reader.IsDBNull (5) ? DateTime.MinValue         : reader.GetDateTime(5);
                            int shipVia             = reader.IsDBNull (6) ? 0            : reader.GetInt32   (6);
                            decimal freight         = reader.IsDBNull (7) ? 0            : reader.GetDecimal (7);
                            string shipName         = reader.IsDBNull (8) ? string.Empty : reader.GetString  (8);
                            string shipAddress      = reader.IsDBNull (9) ? string.Empty : reader.GetString  (9);
                            string shipCity         = reader.IsDBNull(10) ? string.Empty : reader.GetString (10);
                            string shipRegion       = reader.IsDBNull(11) ? string.Empty : reader.GetString (11);
                            string shipPostalCode   = reader.IsDBNull(12) ? string.Empty : reader.GetString (12);
                            string shipCountry      = reader.IsDBNull(13) ? string.Empty : reader.GetString (13);

                            OrderObject order = new OrderObject(orderID, customerID, employeeID, 
                                (DateTime)orderDate, (DateTime)requiredDate, (DateTime)shippedDate, shipVia, freight,
                                shipName, shipAddress, shipCity, shipRegion, shipPostalCode, shipCountry);

                            orders.Add(order);
                        }
                        reader.Close();
                    }
                    catch (Exception e)
                    {
                        errorMsg = e.Message;
                        Console.WriteLine(errorMsg);
                        throw;
                    }

                    connection.Close();
                }
                catch (Exception e)
                {
                    errorMsg = e.Message;
                    Console.WriteLine(errorMsg);
                    throw;
                }
            }

            return orders;
        }
    }
}
