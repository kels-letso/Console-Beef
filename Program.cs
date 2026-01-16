using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator("Pheladi");

            Console.WriteLine("Enter the first number");
            double Num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            double Num2 = Convert.ToDouble(Console.ReadLine());
            //this shit is hard
            //We have to ask the user if they want to add,subract, multiply or devide
            Console.WriteLine();
            Console.WriteLine("How do you want to calculate your numbers");
            Console.WriteLine();
            Console.WriteLine("1. add ");
            Console.WriteLine("2. subtract");
            Console.WriteLine("3. multiply");
            Console.WriteLine("4. devide");
            Console.WriteLine("5. Is the number odd or even?");

            //THE MONEY IS FINISHED
            //you need a variable that you will use to store a number that the people chose like 1.2 .3 

            int choice = Convert.ToInt16(Console.ReadLine());

            //Create a switch to be able to pick an option(on what the user wants to doo, to call a method to calculate
            
        
                Console.WriteLine(choice++);

            switch (choice)
            {

                case 1:
                    //yho
                    Console.WriteLine($"The sum of {Num1} and {Num2} is {Calculator.add(Num1, Num2)}");
                    //when you add two numbers the final number is called sum
                    break;

                case 2:

                    Console.WriteLine($"The difference between {Num1} and {Num2} is {Calculator.subtract(Num1, Num2)}");
                    //when you subtractc two numbers the product is called difference
                    break;

                case 3:
                    //something wrong here  
                    Console.WriteLine($"The prHoduct of {Num1} and {Num2} is {Calculator.multiply(Num1, Num2)}");
                    break;

                case 4:
                    //CALL THE DIVIDE METHOD
                    Console.WriteLine($"The quotient of {Num1} and {Num2} is {Calculator.devide(Num1, Num2)}");
                    break;
                case 5:
                    Console.WriteLine($" {Calculator.iseven(Num1)}");
                    Console.WriteLine($" {Calculator.iseven(Num2)}");
                    break;
                default:
                    Console.WriteLine("Invalid choice");

                    break;

                    //end of switch

                    //end of main method

                    //end of class
                    //end of namespace

            }
        }
       
    }

}
