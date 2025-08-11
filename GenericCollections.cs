using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal class GenericCollections
    {
        public List<int> numbers = new List<int>(); // generic list to hold integers
        public List<string> names = new List<string>(); // generic list to hold strings
        public List<PersonDetails> personDetails = new List<PersonDetails>(); // generic list to hold PersonDetails objects

        public void AddNumber(int number)
        {
            numbers.Add(number);// adds an integer to the list
        }

        public void DisplayNumbers()
        {
            Console.WriteLine("Numbers in the list:");
            foreach (var number in numbers)
            {
                Console.Write(number + " "); // displays each number in the list
            }
            Console.WriteLine(); // adds a new line after displaying all numbers
        }

        public void RemoveNumber(int number)
        {
            if (numbers.Contains(number))
            {
                numbers.Remove(number); // removes the specified number from the list
            }
            else
            {
                Console.WriteLine($"Number {number} not found in the list.");
            }
        }
        public void ClearNumbers()
        {
            numbers.Clear(); // clears all numbers from the list
            Console.WriteLine("All numbers have been cleared from the list.");
        }
        public void AddName(string name)
        {
            names.Add(name); // adds a string to the list
        }
        public void DisplayNames()
        {
            Console.WriteLine("\nNames in the list:");
            foreach (var name in names)
            {
                Console.Write(name + " "); // displays each name in the list
            }
        }

        public void RemoveName(string name)
        {
            if (names.Contains(name))
            {
                names.Remove(name); // removes the specified name from the list
            }
            else
            {
                Console.WriteLine($"Name {name} not found in the list.");
            }
        }

        public void ClearNames()
        {
            names.Clear(); // clears all names from the list
            Console.WriteLine("All names have been cleared from the list.");
        }
        public void AddPersonDetails(PersonDetails person)
        {
            personDetails.Add(person); // adds a PersonDetails object to the list
        }

        
        public void DisplayPersonDetails()
        {
            Console.WriteLine("\nPerson Details in the list:");
            foreach (var person in personDetails)
            {
                person.DisplayPersonDetails(); // calls the DisplayPersonDetails method of each PersonDetails object
            }
        }

        public void RemovePersonDetails(PersonDetails person)
        {
            if (personDetails.Contains(person))
            {
                personDetails.Remove(person); // removes the specified PersonDetails object from the list
            }
            else
            {
                Console.WriteLine("Person not found in the list.");
            }
        }

        public void ClearPersonDetails()
        {
            personDetails.Clear(); // clears all PersonDetails objects from the list
            Console.WriteLine("All person details have been cleared from the list.");
        }


    }
}
