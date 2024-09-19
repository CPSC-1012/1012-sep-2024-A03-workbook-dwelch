// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tHello, World of Math Expression!\n\n");

//basic arithmetic operators

//Using Integers
Console.WriteLine("\n\tInteger Arithmetic expressions\n");
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

//***********************************************************************************

//Using Decimals
Console.WriteLine("\n\n\tDecimal Arithmetic expressions\n");
double doubleA = 3, doubleB = 4, doubleC = 0;

//addition
doubleC = doubleA + doubleB;
Console.WriteLine($"\nThe result of the math expression {doubleA} + {doubleB} is: {doubleC}\n");

//subtraction
doubleC = doubleA - doubleB;
Console.WriteLine($"\nThe result of the math expression {doubleA} - {doubleB} is: {doubleC}\n");

//Multiplication
doubleC = doubleA * doubleB;
Console.WriteLine($"\nThe result of the math expression {doubleA} * {doubleB} is: {doubleC}\n");

//Division
doubleC = doubleA / doubleB;
Console.WriteLine($"\nThe result of the math expression {doubleA} / {doubleB} is: {doubleC}\n");
doubleC = doubleB / doubleA;
Console.WriteLine($"\nThe result of the math expression {doubleB} / {doubleA} is: {doubleC}\n");

//Modular division
doubleC = doubleA % doubleB;
Console.WriteLine($"\nThe result of the math expression {doubleA} % {doubleB} is: {doubleC}\n");
doubleC = doubleB % doubleA;
Console.WriteLine($"\nThe result of the math expression {doubleB} % {doubleA} is: {doubleC}\n");
