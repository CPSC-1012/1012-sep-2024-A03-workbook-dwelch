// See https://aka.ms/new-console-template for more information

//you can use special wildcard characters to enhance the appearance
//  if your i/o on the console
//  \n this adds a line to string
//  \t this is used as a tab on the string
using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;

Console.WriteLine("\n\tEstimated Inventory Management Cost Savings\n\n");

//Detailed Steps
////data storage
//DECLARE inventoryManagementCosts as Float
//DECLARE estimatedPercentageSaved as Float
//DECLARE estimateAmountSaved as Float
////inputs
//PROMPT: Enter the cost of Inventory : [inventoryManagementCosts]
//PROMPT: Enter the savings percentage(ie 15.5)
//READ: [estimatedPercentageSaved]
////processing
//CALCULATE estimateAmountSaved = inventoryManagementCosts * (estimatedPercentageSaved / 100)
////output
//PRINT estimateAmountSaved(note dollar amount)

//literals in C# also must consider their datatype
//int       no need for a datatype suffix
//double    no need for a datatype suffix BUT optionally use a d
//decimal   there is NEED for a datatype suffix. It is an m
decimal inventoryManagementCosts = 0.0m, estimateAmountSaved;
double estimatedPercentageSaved;
string inputValue; //default of a string is null (null is the absence of data)

Console.Write("Enter the cost of Inventory :\t");
inputValue = Console.ReadLine();

//this logic assumes that valid data is entered by the user
//use the appropriate datatype.Parse() to convert your string to the
//  desired datatype
inventoryManagementCosts = decimal.Parse(inputValue);

Console.Write("Enter the savings percentage(ie 15.5) :\t");
inputValue = Console.ReadLine();
estimatedPercentageSaved = double.Parse(inputValue);

//you can temporarily alter the datatype of a variable using: type-casting
//this DOES NOT alter the actual datatype of the variable
//this tells the system to treat the following as the specific datatype
//syntax (casting datatype)expression
estimateAmountSaved = inventoryManagementCosts * (decimal)(estimatedPercentageSaved / 100);

Console.WriteLine($"\n\tThe estimated inventory cost savings is: {estimateAmountSaved.ToString("C2")}");