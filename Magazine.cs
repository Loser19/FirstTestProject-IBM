using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace FirstTestProject_IBM
{
    // Magazine inherits from Book (multilevel: LibraryItem -> Book -> Magazine)
    internal class Magazine : Book
    {
        public int IssueNumber { get; set; }
        public string Month { get; set; }

        public Magazine() { }

        public Magazine(string title, string publisher, string author, string isbn, int issueNumber, string month)
            : base(title, publisher, author, isbn)
        {
            IssueNumber = issueNumber;
            Month = month;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Issue Number: {IssueNumber}");
            Console.WriteLine($"Month: {Month}");
        }
    }
}