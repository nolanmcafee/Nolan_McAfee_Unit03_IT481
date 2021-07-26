using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataAccess;
using System.Data;
using DataObjects;

namespace BusinessLogic
{
    public class BLL
    {
        //string connection = ConfigurationManager.ConnectionStrings["Northwind"].ToString();
        //string connection = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        //static string connection = "Data Source=DESKTOP-EKHOH1V\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        //static string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True"; //KNOWN GOOD CONFIGURATION
        //static string connection;
        private DAL dataCustomers;
        private DAL dataEmployees;
        private DAL dataOrders;
        
        private List<CustomerObject> allCustomerData;
        private List<EmployeeObject> allEmployeeData;
        private List<OrderObject>    allOrderData;

        //private List<CustomerObject> allData;
        private List<string> nameDataCustomerCompany;
        private List<string> nameDataEmployeeFirst;
        private List<string> nameDataEmployeeLast;
        private List<string> dataOrderNumber;
        private string connection;
        private string table;
        private List<string> employeeNames;

        public BLL(string Connection, string Table)
        {
            connection = Connection;
            table = Table;
        }

        public List<string> getResultsTable()
        {
            switch (table)
            {
                case ("Customers"):
                    try
                    {
                        dataCustomers = new DAL(connection, table);
                        allCustomerData = dataCustomers.getAllCustomerData();
                        getAllCustomerCompanyNames();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                    break;
                case ("Employees"):
                    try
                    {
                        dataEmployees = new DAL(connection, table);
                        allEmployeeData = dataEmployees.getAllEmployeeData();
                        getAllEmployeeFirstNames();
                        getAllEmployeeLastNames();

                        /*
                        for (int i = 0; i < getNumberOfEmployeeRecords() - 1; i++)
                        {
                            employeeNames.Add(nameDataEmployeeFirst[i] + " " + nameDataEmployeeLast[i]);
                        }
                        */
                        employeeNames = nameDataEmployeeLast;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                    break;
                case ("Orders"):
                    try
                    {
                        dataOrders = new DAL(connection, table);
                        allOrderData = dataOrders.getAllOrderData();
                        getAllOrderNumbers();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                    break;
                default:

                    break;
            }

            return nameDataCustomerCompany ?? employeeNames ?? dataOrderNumber;
        }

        public List<string> getAllCustomerCompanyNames()
        {
            nameDataCustomerCompany = new List<string>();

            foreach (CustomerObject customer in allCustomerData)
            {

                nameDataCustomerCompany.Add(customer.CompanyName);
            }

            return nameDataCustomerCompany;
        }



        public List<string> getAllEmployeeFirstNames()
        {
            nameDataEmployeeFirst = new List<string>();
            
            foreach (EmployeeObject employee in allEmployeeData)
            {
                nameDataEmployeeFirst.Add(employee.FirstName);
            }
            return nameDataEmployeeFirst;
        }

        public List<string> getAllEmployeeLastNames()
        {
            nameDataEmployeeLast = new List<string>();
            
            foreach (EmployeeObject employee in allEmployeeData)
            {
                nameDataEmployeeLast.Add(employee.LastName);
            }
            return nameDataEmployeeLast;
        }

        public List<string> getAllOrderNumbers()
        {
            dataOrderNumber = new List<string>();

            foreach (OrderObject order in allOrderData)
            {
                dataOrderNumber.Add((string)order.OrderID.ToString());
            }
            return dataOrderNumber;
        }


        public int getNumberOfCustomerRecords()
        {
            return allCustomerData.Count;
        }

        public int getNumberOfEmployeeRecords()
        {
            return allEmployeeData.Count;
        }

        public int getNumberOfOrderRecords()
        {
            return allOrderData.Count;
        }




        //List<DAL> custlist = new List<DAL>();

        //ICollection<string> customers = new System.Collections.Generic.ICollection();

    }
}
