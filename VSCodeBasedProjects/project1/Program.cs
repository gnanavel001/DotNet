using System;
using System.Dynamic;

namespace day1{

public class Calculation{
    public int totalValue {get; set;} // property
    public int todayMarketValue; // field
    public Calculation(){
        totalValue = 100;
        Console.WriteLine($"calling constructor {totalValue}");
    }
    static void Main (string[] arg){
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

//Accessing String
Console.WriteLine(username[0]);


//sort array
int[] arrayitms = [ 1, 2, 10, 1, 5 ];
Array.Sort(arrayitms);
foreach(int i in arrayitms){
Console.WriteLine($"array sort using Array.Sort {i}");
}
//maths 
Math.Max(1,2);
    }
}
}