using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal class PersonDetails
    {
        public PersonDetails() { }
        //Autoimplemented properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }

        public PersonDetails(string name, int age, string address, string phoneNumber, string email, string occupation)
        {
            Name = name;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Occupation = occupation;
        }

        public string GetPersonDetails()
        {
            StringBuilder details = new StringBuilder();
            details.AppendLine($"Name: {Name}");
            details.AppendLine($"Age: {Age}");
            details.AppendLine($"Address: {Address}");
            details.AppendLine($"Phone Number: {PhoneNumber}");
            details.AppendLine($"Email: {Email}");
            details.AppendLine($"Occupation: {Occupation}");
            return details.ToString();
        }
        public void DisplayPersonDetails()
        {
            Console.WriteLine(GetPersonDetails());
        }
        public void UpdatePersonDetails(string name, int age, string address, string phoneNumber, string email, string occupation)
        {
            Name = name;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Occupation = occupation;
        }

        public void ClearPersonDetails()
        {
            Name = string.Empty;
            Age = 0;
            Address = string.Empty;
            PhoneNumber = string.Empty;
            Email = string.Empty;
            Occupation = string.Empty;
        }



    }
}
