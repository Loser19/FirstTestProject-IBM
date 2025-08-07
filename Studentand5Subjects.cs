using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal class Studentand5Subjects
    {
        public Studentand5Subjects()
        {
        }
        public void DisplayStudentDetails(string name, int age, string[] subjects, int[] marks)
        {
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine("Subjects and Marks:");
            int totalMarks = 0;

            for (int i = 0; i < subjects.Length; i++)
            {
                int mark = (marks != null && i < marks.Length) ? marks[i] : 0;
                Console.WriteLine($"- {subjects[i]}: {mark}");
                totalMarks += mark;
            }

            Console.WriteLine($"Total Marks: {totalMarks}");

            if (subjects.Length > 0)
            {
                double average = (double)totalMarks / subjects.Length;
                Console.WriteLine($"Average Marks: {average}");
            }
            else
            {
                Console.WriteLine("No subjects provided.");
            }
        }

        public void DisplayStudentInfo(string name, int age, string[] subjects, int[] marks)
        {
            DisplayStudentDetails(name, age, subjects, marks);
        }

    }
}
