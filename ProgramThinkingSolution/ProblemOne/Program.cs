// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

Console.WriteLine("Hello Don, Welcome to the Wonderful World of C#!");

//Detailed Steps
//declare storage
//DECLARE audienceSize as Integer
//DECLARE conversionRate as Float 
//DECLARE numberOfConversions as Float
//input
//PROMPT: Enter the audience size: (read)
//PROMPT: Enter the conversion rate: (read)
//process
//CALCUATE: numberOfConversions = audienceSize * conversionRate
//output
//PRINT the numberOfConversions (round to nearest whole number)

//camelCase: the first letter of the first word is lower case, the first letter
//              of remain words is upper case
//PacalCase (TitleCase): the first letter of each word is upper case

//variables have defaults when they are delcared
//numerics: the value is 0
//strings: the value is null
//bool: the value is false
int audienceSize = 0;
double conversionRate = 0.0, numberOfConversions;
string inputValue = "";

//console I/O uses the Console class with the appropriate method
//write the supplied literal string to the console AND remain on that
//  physical line
Console.Write("Enter the audience size:");
//read the line entered into the console by the user until the enter key
//ALL input is consider a string WHEN read
inputValue = Console.ReadLine();

//YOU MAY NEED to convert the input to a different datatype such as a numeric
//this convertion is referred to as Parsing
//datatypes have a method that will do the conversion, if possible, for you
//typical syntax  datatype.Parse(string value)
audienceSize = int.Parse(inputValue);

//write the supplied literal string to the console AND move to the next
//  physical line
Console.WriteLine("Enter the conversion rate:");
inputValue = Console.ReadLine();
conversionRate = double.Parse(inputValue);

numberOfConversions = audienceSize * conversionRate;

//your output expresion can include variables
//string concatenation
Console.WriteLine("The estimated number of converted individauls is " + numberOfConversions);
//string interoplation
Console.WriteLine($"The estimated number of converted individauls is {numberOfConversions}");