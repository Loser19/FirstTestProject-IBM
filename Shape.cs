using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestProject_IBM
{
    internal class Shape <T>
    {
        private T shapeName;
        public Shape()
        {
            shapeName = default(T); //Initializing with default value
        }
        public Shape(T name)
        {
            shapeName = name; //Initializing with provided value
        }
        public T ShapeName
        {
            get { return shapeName; }
            set { shapeName = value; }
        }

        public override string ToString()
        {
            return $"Shape Name: {shapeName}";
        }
    }
}
