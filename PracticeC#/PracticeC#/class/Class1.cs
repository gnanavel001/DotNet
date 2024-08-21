using System;
using System.Dynamic;

namespace day1
{

    public class Calculation
    {
        public int totalValue { get; set; }
        public Calculation()
        {
            totalValue = 100;
            Console.WriteLine($"calling constructor {totalValue}");
        }
        static void Main(string[] arg)
        {
            int variable1 = 10;
            int variable2 = 20;
            // int x, y, z;
            string petrolPrice = Convert.ToString(variable1);

            //create instance to call constructor
            Calculation object1 = new Calculation();
            Console.WriteLine($"Sum of value1 {petrolPrice} value2 {variable2} =  {variable1 + variable2}");

            //get input from user
            Console.WriteLine("enter the username");
            string username = Console.ReadLine();

            //maths 
            Console.WriteLine(Math.Max(3, 4));
        }
    }
}