// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tHello, World of Math Expression!\n\n");

//basic arithmetic operators

int intA = 3, intB = 4, intC = 0;

//addition
intC = intA + intB;
Console.WriteLine($"\nThe result of the math expression {intA} + {intB} is: {intC}\n");
//the string interpolation written as string concatenation
//Console.WriteLine($"\nThe result of the math expression " + intA + " + " + intB + " is: " + intC + "\n");

//subtraction
intC = intA - intB;
Console.WriteLine($"\nThe result of the math expression {intA} - {intB} is: {intC}\n");

//Multiplication
intC = intA * intB;
Console.WriteLine($"\nThe result of the math expression {intA} * {intB} is: {intC}\n");

//Division
intC = intA / intB;
Console.WriteLine($"\nThe result of the math expression {intA} / {intB} is: {intC}\n");
intC = intB / intA;
Console.WriteLine($"\nThe result of the math expression {intB} / {intA} is: {intC}\n");

//Modular division
intC = intA % intB;
Console.WriteLine($"\nThe result of the math expression {intA} % {intB} is: {intC}\n");
intC = intB % intA;
Console.WriteLine($"\nThe result of the math expression {intB} % {intA} is: {intC}\n");