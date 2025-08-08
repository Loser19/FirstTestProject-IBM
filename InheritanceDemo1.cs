using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal class InheritanceDemo1 : PersonDetails
    {
        public int EmployeeID { get; set; }
        public string? Department { get; set; }

        public InheritanceDemo1() : base() { }
        public InheritanceDemo1(string name, int employeeid, int age, string address, string number, string email, string occupation, string department) : base(name, age, address, number, email, occupation)
        {
            EmployeeID = employeeid;
            Department = department;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine(GetPersonDetails());
        }
    }
}
