// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tIt is just an Average World!\n");

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
calculateAverage = (numOne + numTwo + numThree) / 3;

Console.WriteLine($"\nThe average of ({numOne}, {numTwo}, {numThree}) is {calculateAverage}");
Console.WriteLine($"\nThe average of ({numOne}, {numTwo}, {numThree}) is {calculateAverage.ToString("F2")}");
Console.WriteLine($"\nThe average of ({numOne}, {numTwo}, {numThree}) is {calculateAverage.ToString("#,##0.00")}");
Console.WriteLine($"\nThe average of ({numOne}, {numTwo}, {numThree}) is {Math.Round(calculateAverage,2)}");