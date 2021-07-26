using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class EmployeeObject
    {
        private int         employeeID;
        private string      lastName;
        private string      firstName;
        private string      title;
        private string      titleOfCourtesy;
        private DateTime?   birthDate;
        private DateTime?   hireDate;
        private string      address;
        private string      city;
        private string      region;
        private string      postalCode;
        private string      country;
        private string      homePhone;
        private decimal     salary;
        private string      extension;
        //private byte[]      photo;
        private string      notes;
        private int         reportsTo;
        //private string      photoPath;

        public EmployeeObject(int EmployeeID, string LastName, string FirstName, string Title, string TitleOfCourtesy, DateTime BirthDate, DateTime HireDate, 
            string Address, string City, string Region, string PostalCode, string Country, string HomePhone, decimal Salary, string Extension, 
            /*byte[] Photo,*/ string Notes, int ReportsTo/*, string PhotoPath*/)
        {
            employeeID =        EmployeeID;
            lastName =          LastName;
            firstName =         FirstName;
            title =             Title;
            titleOfCourtesy =   TitleOfCourtesy;
            birthDate =         BirthDate;
            hireDate =          HireDate;
            address =           Address;
            city =              City;
            region =            Region;
            postalCode =        PostalCode;
            country =           Country;
            homePhone =         HomePhone;
            salary =            Salary;
            extension =         Extension;
            //photo =             Photo;
            notes =             Notes;
            reportsTo =         ReportsTo;
            //photoPath =         PhotoPath;
        }

        public int EmployeeID { get { return employeeID; } set { employeeID = value; } }

        public string LastName { get { return lastName; } set { lastName = value; } }

        public string FirstName { get { return firstName; } set { firstName = value; } }

        public string Title { get { return title; } set { title = value; } }

        public string TitleOfCourtesy { get { return titleOfCourtesy; } set { titleOfCourtesy = value; } }

        public DateTime? BirthDate { get { return birthDate; } set { birthDate = value; } }

        public DateTime? HireDate { get { return hireDate; } set { hireDate = value; } }

        public string Address { get { return address; } set { address = value; } }

        public string City { get { return city; } set { city = value; } }

        public string Region { get { return region; } set { region = value; } }

        public string PostalCode { get { return postalCode; } set { postalCode = value; } }

        public string Country { get { return country; } set { country = value; } }

        public string HomePhone { get { return homePhone; } set { homePhone = value; } }

        public decimal Salary { get { return salary; } set { salary = value; } }

        public string Extension { get { return extension; } set { extension = value; } }

        //public byte[] Photo { get { return photo; } set { photo = value; } }

        public string Notes { get { return notes; } set { notes = value; } }

        public int ReportsTo { get { return reportsTo; } set { reportsTo = value; } }

        //public string PhotoPath { get { return photoPath; } set { photoPath = value; } }

    }
}
