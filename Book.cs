using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal class Book : LibraryItem
    {
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book() { }

        public Book(string title, string publisher, string author, string isbn)
            : base(title, publisher)
        {
            Author = author;
            ISBN = isbn;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
}