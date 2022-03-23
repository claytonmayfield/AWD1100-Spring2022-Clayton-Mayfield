using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLibary
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocSecNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public override string ToString()
        {
            return "FirstName" + FirstName + " last Name" + LastName + "SocSecNumber" + SocSecNumber +
                "Address" + Address + "city" + City + "State" + State + "zipcode" + ZipCode;
        }
    }
}
