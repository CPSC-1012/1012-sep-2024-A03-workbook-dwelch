// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tIt is just an Average World!\n");

//constants
//a constant is a data storage item that has a program definted name
//                                       has a datatype
//                                       has an assigned value
//a constant, unlike a variable, CANNOT be altered
//a constant can be used in your code just like a variable
const int NUMBER_OF_VALUES = 3;

double calculateAverage = 0.0;
double numOne, numTwo, numThree;
string inputValue;

Console.Write("Enter your first number:\t");
inputValue = Console.ReadLine();
numOne = double.Parse(inputValue); //this assumes that the string is a numeric
Console.Write("Enter your second number:\t");
inputValue = Console.ReadLine();
numTwo = double.Parse(inputValue);
Console.Write("Enter your third number:\t");
inputValue = Console.ReadLine();
numThree = double.Parse(inputValue);

//order of operations in arithmetic
// (....)
// * and / left to right
// + and - left to right
calculateAverage = (numOne + numTwo + numThree) / NUMBER_OF_VALUES;

Console.WriteLine($"\nThe average of ({numOne}, {numTwo}, {numThree}) is {calculateAverage}");
Console.WriteLine($"\nThe average of ({numOne}, {numTwo}, {numThree}) is {calculateAverage.ToString("F2")}");
Console.WriteLine($"\nThe average of ({numOne}, {numTwo}, {numThree}) is {calculateAverage.ToString("#,##0.00")}");
Console.WriteLine($"\nThe average of ({numOne}, {numTwo}, {numThree}) is {Math.Round(calculateAverage,2)}");