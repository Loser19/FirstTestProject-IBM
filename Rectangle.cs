using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal class Rectangle
    {
        private double length;
        private double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Area()
        {
            return length * width;
        }
        public double Perimeter()
        {
            return 2 * (length + width);
        }
        public override string ToString()
        {
            return $"Rectangle: Length = {length}, Width = {width}, Area = {Area()}, Perimeter = {Perimeter()}";
        }
    }
}
