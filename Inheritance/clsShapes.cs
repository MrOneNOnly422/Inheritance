using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Inheritance
{
    internal class clsShapes
    {
        private int side;
        private string name;

        public clsShapes()
        {

        }
        public clsShapes(int side, string name)
        {
            this.side = side;
            this.name = name;
        }

        public int Side { get => side; set => side = value; }
        public string Name { get => name;set => name = value; }

        public override string ToString()
        {
            return "Name: " + this.Name + "\nNo of Sides: " + this.Side;
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