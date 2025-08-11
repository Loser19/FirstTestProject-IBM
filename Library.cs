using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal class LibraryItem
    {
        public string Title { get; set; }
        public string Publisher { get; set; }

        public LibraryItem() { }

        public LibraryItem(string title, string publisher)
        {
            Title = title;
            Publisher = publisher;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Publisher: {Publisher}");
        }
    }
}
