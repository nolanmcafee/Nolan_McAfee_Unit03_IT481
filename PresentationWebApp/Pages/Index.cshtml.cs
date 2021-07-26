using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace PresentationWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private PL customers;

        public List<string> customerCompanyNames;
        public int customerCount;

        public string btnClk;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            //Testing different combinations of credentials and tables
            int test = 1;
            string UserID, Password, Table;

            switch (test)
            {
                case 1:                         //Cases 1-3 explore User_Sales access to each table
                    UserID = "User_Sales";
                    Password = "User_Sales";
                    Table = "Customers";
                    break;
                case 2:
                    UserID = "User_Sales";
                    Password = "User_Sales";
                    Table = "Employees";
                    break;
                case 3:
                    UserID = "User_Sales";
                    Password = "User_Sales";
                    Table = "Orders";
                    break;
                case 4:                         //Cases 4-6 explore User_CEO access to each table
                    UserID = "User_CEO";
                    Password = "User_CEO";
                    Table = "Customers";
                    break;
                case 5:
                    UserID = "User_CEO";
                    Password = "User_CEO";
                    Table = "Employees";
                    break;
                case 6:
                    UserID = "User_CEO";
                    Password = "User_CEO";
                    Table = "Orders";
                    break;
                case 7:                         //Cases 7-9 explore User_HR access to each table
                    UserID = "User_HR";
                    Password = "User_HR";
                    Table = "Customers";
                    break;
                case 8:
                    UserID = "User_HR";
                    Password = "User_HR";
                    Table = "Employees";
                    break;
                case 9:
                    UserID = "User_HR";
                    Password = "User_HR";
                    Table = "Orders";
                    break;
                case 10:                         //Cases 10-12 explore each users' access to an authorized table with wrong password
                    UserID = "User_Sales";
                    Password = "Wrong_Password";
                    Table = "Customers";
                    break;
                case 11:
                    UserID = "User_CEO";
                    Password = "Wrong_Password";
                    Table = "Orders";
                    break;
                case 12:
                    UserID = "User_HR";
                    Password = "Wrong_Password";
                    Table = "Employees";
                    break;
                case 13:                         //Cases 13 explores access with wrong user and wrong password to real table
                    UserID = "Wrong_User";
                    Password = "Wrong_Password";
                    Table = "Employees";
                    break;
                default:
                    UserID = string.Empty;
                    Password = string.Empty;
                    Table = string.Empty;
                    break;
            }

            customers = new PL(UserID, Password, Table);
            //customerCompanyNames = customers.CompanyNames();
            customerCount = customers.Count();



            /*
            try
            {
                customers = new PL(UserID, Password, Table);
                customerCompanyNames = customers.CompanyNames();
                customerCount = customers.Count();
            }
            catch (Exception e)
            {
                return e.Message;
                //customerCompanyNames.Add(e.Message);
                //customerCount = 0;
            }
            */

            /*foreach (string customer in customers.CompanyNames())
            {
                //table1.Rows.Add(customer);
                Console.WriteLine(customer);
            }*/
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            
        }

        public void formactions()
        {

        }
        public void btnClick()
        {
            /*
            PL customers = new PL();
            customerCompanyNames = customers.CompanyNames();
            foreach (string customer in customers.CompanyNames())
            {
                //table1.Rows.Add(customer);
                Console.WriteLine(customer);
            }
            */
        }

        /*public async Task OnGetAsync(string btnClk)
        {

        }*/
        
    }
}
