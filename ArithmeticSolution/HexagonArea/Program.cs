// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("\n\tUsing Math class for calculations\n");

//Write a program that prompts the user to enter the side of a hexagon and
//displays its area. The formula for
//computing the area of a hexagon is

// area = ((3 * srt(3)) / 2) * (s * s) where s is the length of a hexagon side

//Detail Steps
//(...)

string inputValue = "";
double lengthOfSide = 0;
double areaOfHexagon = 0;

Console.Write("Enter your hexagon side length:\t");
inputValue = Console.ReadLine();
lengthOfSide = double.Parse(inputValue);

areaOfHexagon = ((3 * Math.Sqrt(3)) / 2) * Math.Pow(lengthOfSide, 2);

Console.WriteLine($"\nThe area of a hexagon with a side length of {lengthOfSide} " +
    $"is {areaOfHexagon.ToString("#,##0.0000")}");