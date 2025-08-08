using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace FirstTestProject_IBM
{
    internal class EmployeeDemo
    {
        public void RunEmployeeDemo()
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter employee age: ");
            int age = int.TryParse(Console.ReadLine(), out int parsedAge) ? parsedAge : 0;

            Console.Write("Enter employee ID: ");
            string empId = Console.ReadLine();

            Console.Write("Is the employee Full Time or Intern? (Enter 'full' or 'intern'): ");
            string empType = Console.ReadLine()?.Trim().ToLower();

            if (empType == "full")
            {
                HandleFullTimeEmployee(name, age, empId);
            }
            else if (empType == "intern")
            {
                HandleInternEmployee(name, age, empId);
            }
            else
            {
                Console.WriteLine("Invalid employee type entered.");
            }
        }

        private void HandleFullTimeEmployee(string name, int age, string empId)
        {
            Console.Write("Enter basic salary: ");
            double basic = double.TryParse(Console.ReadLine(), out double parsedBasic) ? parsedBasic : 0;

            double hra = basic * 0.40; // 40% HRA
            double da = basic * 0.20;  // 20% DA
            double totalSalary = basic + hra + da;

            Console.WriteLine("\n--- Full Time Employee Details ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {empId}");
            Console.WriteLine($"Basic Salary: {basic}");
            Console.WriteLine($"HRA (40%): {hra}");
            Console.WriteLine($"DA (20%): {da}");
            Console.WriteLine($"Total Salary: {totalSalary}");
        }

        private void HandleInternEmployee(string name, int age, string empId)
        {
            Console.Write("Enter stipend: ");
            double stipend = double.TryParse(Console.ReadLine(), out double parsedStipend) ? parsedStipend : 0;

            double hra = stipend * 0.10; // 10% HRA for interns
            double totalSalary = stipend + hra;

            Console.WriteLine("\n--- Intern Employee Details ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {empId}");
            Console.WriteLine($"Stipend: {stipend}");
            Console.WriteLine($"HRA (10%): {hra}");
            Console.WriteLine($"Total Salary: {totalSalary}");
        }
    }
}
