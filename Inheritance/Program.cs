// Property of James Crispe
// Created on: March 13, 2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------clsShape Program-------------------------");

            // Start
            clsShapes shape1 = new clsShapes();
            shape1.Name = "Triangle";
            shape1.Side = 3;
            Console.WriteLine("Name: " + shape1.Name);
            Console.WriteLine("No of Sides: " + shape1.Side);
            Console.WriteLine("Area of Shape: " + shape1.ComputeArea());
            Console.WriteLine("Perimeter of Shape: " + shape1.ComputePerimeter());

            Console.WriteLine();

            clsShapes shape2 = new clsShapes();
            shape2.Name = "Square";
            shape2.Side = 4;
            Console.WriteLine("Name: " + shape2.Name);
            Console.WriteLine("No of Sides: " + shape2.Side);
            Console.WriteLine("Area of Shape: " + shape2.ComputeArea());
            Console.WriteLine("Perimeter of Shape: " + shape2.ComputePerimeter());

            

            // End of clsShape Program

            Console.WriteLine("-------------------------------clsSquare Program---------------------------------");

            // Start
            clsSquare square1 = new clsSquare();
            square1.name = "Square";
            square1.side1 = 4;
            square1.side2 = 4.3;

            Console.WriteLine("Name: " + square1.name);
            Console.WriteLine("No of Sides1: " + square1.side1);
            Console.WriteLine("No of Sides2: " + square1.side2);
            Console.WriteLine("Area of Shape: " + square1.ComputeArea());
            Console.WriteLine("Perimeter of Shape: " + square1.ComputePerimeter());

            

            Console.ReadLine();

            // End


        }
    }
}
