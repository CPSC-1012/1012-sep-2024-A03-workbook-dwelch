// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("\n\tCan do more than eat PI");

//Write a program that reads in the radius and length of a cylinder and computes 
//the area and volume using the formulas

// area = radius * radius * PI
// volume = area * length

//Detail steps
//(...)

double radius = 0;
double length = 0;
double area = 0;
double volume = 0;
string inputValue = "";
const double PI = 3.141596;

Console.Write("Enter your cylinder radius:\t");
inputValue = Console.ReadLine();
radius = double.Parse(inputValue);

Console.Write("Enter your cylinder length:\t");
inputValue = Console.ReadLine();
length = double.Parse(inputValue);

area = radius * radius * PI;
//area = radius * radius * double.Pi;
//area = radius * radius * Math.PI;
//area = Math.Pow(radius, 2) * Math.PI;

volume = area * length;


Console.WriteLine($"The cylinder with a radius of {radius} and length of {length} " +
    $"has an area of {area.ToString("F4")} and volume of {volume.ToString("###0.0")}");