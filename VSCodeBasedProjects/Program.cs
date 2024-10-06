// See https://aka.ms/new-console-template for more information
var firstName = "Gnanvel     ";
var lastName = "Vengatesan           ";
string EmailID = "gnanavelVengat@gmail.com";
// Console.WriteLine($"Hello {firstName.Trim()} {lastName.TrimEnd()} {EmailID}");
// without using varibale we cant change the string  actiual string value while writing functions
//strings are Immutable
//white spaces are matters in  C# white spaces are significant
Console.WriteLine($"Hello {firstName.Trim()} {lastName.TrimEnd()} {EmailID.Length} {EmailID.Replace("gmail.com", "BruceWayneENterPrice.com")}");

int actualValue = (int)2.324;
int bitsValue = 32;
var calculationsValue = Math.Pow(actualValue, bitsValue);

Console.WriteLine($"inta max value {calculationsValue}");

//brancing 

if (actualValue < bitsValue)
    Console.WriteLine("print the if contion is true");
int counter = 100;
while (counter < 10)
{
    counter++;
    Console.WriteLine(counter);
}

// do
// {
//     counter++;
//     ++counter;
//     Console.WriteLine(counter);
// } while (counter < 10);

// for (int i = 0; i < 10; ++i)
// {
//     Console.WriteLine(i);
//     i++;
// }

// for (char charValue = 'A'; charValue <= 'Z'; charValue++)
// {
//     Console.WriteLine(charValue);
// }

//var auto detect data type 


//collection
var collection1 = new List<string> { "task1", "task2", "task3" };

collection1.Sort();
List<string> collection2 = ["Task    1"];

foreach (var item in collection1)
{
    Console.WriteLine(item);
}
foreach (var item in collection2)
{
    Console.WriteLine(item);
}

//array
string[] array1 = ["a", "b", "c", "d", "e", "f", "g"];
array1 = [.. array1, "Z"];
// foreach (var item in array1[1..4])
// {
//     Console.WriteLine(item);
// }

//to print or get from reverse
Console.WriteLine(array1[^1]);
string[] array2 = new string[5] { "", "", "", "", "" };

int[] arrayWIthNumber = [001, 1, 100, 1000, 2, 10, 5, 01, 00000001];

//Linq Language Integrated Query (LINQ)

// IEnumerable<int> scoreQuery = from score in arrayWIthNumber where score > 10 select score;
IEnumerable<int> scoreQuery = from score in arrayWIthNumber
                              where score > 10
                              orderby score descending
                              select score;
Console.WriteLine(scoreQuery.Sum());

foreach (var item in scoreQuery)
{
    Console.WriteLine(item);
}
var sample = new int[] { 1, 2, 3 };