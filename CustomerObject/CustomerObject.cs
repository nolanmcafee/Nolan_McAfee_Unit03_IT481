using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class CustomerObject
    {
        //declare private class attributes
        private string customerID;
        private string companyName;
        private string contactName;
        private string contactTitle;
        private string address;
        private string city;
        private string region;
        private string postalCode;
        private string country;
        private string phone;
        private string fax;

        public CustomerObject(string CustomerID, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax)
        {
            customerID = CustomerID;
            companyName = CompanyName;
            contactName = ContactName;
            contactTitle = ContactTitle;
            address = Address;
            city = City;
            region = Region;
            postalCode = PostalCode;
            country = Country;
            phone = Phone;
            fax = Fax;
        }

        //declare class get/set properties to reference attributes
        public string CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }
        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }
        public string ContactName
        {
            get
            {
                return contactName;
            }
            set
            {
                contactName = value;
            }
        }
        public string ContactTitle
        {
            get
            {
                return contactTitle;
            }
            set
            {
                contactTitle = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Region
        {
            get
            {
                return region;
            }
            set
            {
                region = value;
            }
        }
        public string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                postalCode = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public string Fax
        {
            get
            {
                return fax;
            }
            set
            {
                fax = value;
            }
        }
    }
}
