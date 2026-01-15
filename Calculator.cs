using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Calculator
    {
        public string Name { get; set; }

        public Calculator(string name)
        {
            Name = name;
        }

        //you want the method to add double 
        //addition mehtod
        // you want to declare a method tha returns you must name it static to avoid errors in the actual code
        public static double add(double A, double B)
        {
            //the method will e dark if you don't call it
            //for the computher to be able to write you tell it what todo to be able to add
            double additon = A + B;
            return additon;
        }
        //subtraction method
        public static double subtract(double A, double B)
        {

            //tell the mehtod to subtract 

            double subtraction = A - B;
            return subtraction;
        }
       public static double multiply(double A, double B)
        {

            double multiply = A * B;
            return multiply;

        }
        public static double devide(double A, double B)
        {
            double devide  = A / B;
            return devide;

        }
        public static double iseven(double A)
        {
          if ( A % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                    Console.WriteLine("The number is odd");
            }
            return A;
        }
        
        
    }
}
