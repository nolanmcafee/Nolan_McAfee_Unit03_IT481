using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class OrderObject
    {
        private int orderID;
        private string customerID;
        private int employeeID;
        private DateTime? orderDate;
        private DateTime? requiredDate;
        private DateTime? shippedDate;
        private int shipVia;
        private decimal freight;
        private string shipName;
        private string shipAddress;
        private string shipCity;
        private string shipRegion;
        private string shipPostalCode;
        private string shipCountry;

        public OrderObject(int OrderID, string CustomerID, int EmployeeID, DateTime OrderDate, DateTime RequiredDate, DateTime ShippedDate, 
            int ShipVia, decimal Freight, string ShipName, string ShipAddress, string ShipCity, string ShipRegion, string ShipPostalCode, string ShipCountry)
        {
              orderID = OrderID;
              customerID = CustomerID;
              employeeID = EmployeeID;
              orderDate = OrderDate;
              requiredDate = RequiredDate;
              shippedDate = ShippedDate;
              shipVia = ShipVia;
              freight = Freight;
              shipName = ShipName;
              shipAddress = ShipAddress;
              shipCity = ShipCity;
              shipRegion = ShipRegion;
              shipPostalCode = ShipPostalCode;
              shipCountry = ShipCountry;
        }

        public int OrderID { get { return orderID; } set { orderID = value; } }
        
        public string CustomerID { get { return customerID; } set {customerID  = value; } }
        
        public int EmployeeID { get { return employeeID; } set { employeeID = value; } }
        
        public DateTime? OrderDate { get { return orderDate; } set { orderDate = value; } }
        
        public DateTime? RequiredDate { get { return requiredDate; } set { requiredDate = value; } }
        
        public DateTime? ShippedDate { get { return shippedDate; } set { shippedDate = value; } }
        
        public int ShipVia { get { return shipVia; } set { shipVia = value; } }
        
        public decimal Freight { get { return freight; } set { freight = value; } }
       
        public string ShipName { get { return shipName; } set { shipName = value; } }
        
        public string ShipAddress { get { return shipAddress; } set { shipAddress = value; } }
       
        public string ShipCity { get { return shipCity; } set { shipCity = value; } }
       
        public string ShipRegion { get { return shipRegion; } set { shipRegion = value; } }
        
        public string ShipPostalCode { get { return shipPostalCode; } set { shipPostalCode = value; } }
        
        public string ShipCountry { get { return shipCountry; } set { shipCountry = value; } }
    }
}
