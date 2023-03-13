using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class clsSquare
    {
        private string Name;
        private int Side1;
        private double Side2;

        public clsSquare()
        {

        }

        public clsSquare(string Name, int Side1, double Side2)
        {
            this.name = Name;
            this.side1 = Side1;
            this.side2 = Side2;
        }

        public string name { get => Name; set => Name = value; }
        public int side1 { get => Side1; set => Side1 = value; }
        public double side2 { get => Side2;set => Side2 = value; }

        public override string ToString()
        {
            return "Name: " + this.name + "\nNo of Sides1: " + this.Side1 + "\nNo of Sides2: " + this.Side2;
        }

        public double ComputeArea()
        {
            return 0.0;
        }

        public double ComputePerimeter()
        {
            return 0.0;
        }
    }
}