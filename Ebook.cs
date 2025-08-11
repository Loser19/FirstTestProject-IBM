using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal class EBook : Book
    {
        public string FileFormat { get; set; }
        public double FileSizeMB { get; set; }

        public EBook() { }

        public EBook(string title, string publisher, string author, string isbn, string fileFormat, double fileSizeMB)
            : base(title, publisher, author, isbn)
        {
            FileFormat = fileFormat;
            FileSizeMB = fileSizeMB;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"File Format: {FileFormat}");
            Console.WriteLine($"File Size (MB): {FileSizeMB}");
        }
    }
}