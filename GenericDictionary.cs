using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal class GenericDictionary<Tkey, TValue>
    {
        private Dictionary<Tkey, TValue> dict = new Dictionary<Tkey, TValue>();
        public void Add(Tkey key, TValue value)
        {
            if (!dict.ContainsKey(key)) //if key does not exist in the dictionary then add it
            {
                dict.Add(key, value);
            }
            else //if key already exists in the dictionary then display a message
            {
                Console.WriteLine($"Key {key} already exists.");
            }
        }
        public void Remove(Tkey key)
        {
            if (dict.ContainsKey(key)) //if key exists in the dictionary then remove it
            {
                dict.Remove(key);
                Console.WriteLine($"Key {key} removed from the dictionary.");
            }
            else //if key does not exist in the dictionary then display a message
            {
                Console.WriteLine($"Key {key} not found in the dictionary.");
            }
        }
        public void DisplayDict()
        {
            Console.WriteLine("Dictionary contents:");
            foreach (var kvp in dict) //iterate through the dictionary and display key-value pairs
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}
