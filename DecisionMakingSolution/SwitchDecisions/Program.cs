// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;

Console.WriteLine("\n\tSwitch Decisions: All things are equal!");

//Name: Don Welch
//last modification: Oct 7 2024
//
//there is a structure refered to as a case structure
//conditions:
//  a) there is a single argument to be check : machineChoice
//  b) that argument is check against a series of values: 0,1,2
//  c) the comparsion is EQUALS
//
//the C# command to use for a case structure is the switch
//syntax:
//      switch (argument)
//      {
//          case value:
//          {
//              C# logic to execute
//              break;
//          }
//          .
//          .
//          .
//          case value:
//          {
//              C# logic to execute
//              break;
//          }
//          default:
//          {
//              C# logic to execute
//              break;
//          }
//      }

/*
 * Write a program for an Internet service provider so they can calculate how much to bill their
 *   customers. The provider offers customers 3 packages:
 * PACKAGE COST CALCULATION
 * A $9.95 per month for up to 10 hours; additional hours are billed at $2.00 per hour
 * B $13.95 per month for up to 20 hours; additional hours are billed at $1.00 per hour
 * C $19.95 per month for unlimited hours
 *
 * The program should prompt for the letter of the service package (A, B, or C) and the number of
 *    hours they have used if either option A or B has been selected
 */

string inputValue;
char planid;
double hours = 0.0;
double planAmount = 0.00;

Console.Write("Enter your plan A, B or C:\t");
inputValue = Console.ReadLine();
if (!char.TryParse(inputValue, out planid))
{
    Console.WriteLine($"Your entry of >{inputValue}< is not a character. Plan ids are A, B, or C");
}
else
{
    //you could change the character to upper case

    Console.Write("Enter the number of hours used:\t");
    inputValue = Console.ReadLine();
    if (!double.TryParse(inputValue, out hours))
    {
        Console.WriteLine($"Your entry of >{inputValue}< is not a number representing hours used.");
    }
    else
    {
        if (hours < 0)
        {
            Console.WriteLine($"Your entry of >{hours}< hours is not a positive number greater or equal to 0.");
        }
        else
        {
            //at this point you have checked your data and it appears valid
            //in this example we will use a case structure
            //rules:
            //single argument to check: yes planid
            //comparison is equals: yes
            //value list: A B or C

            //since C# is case-sensitive, we need to ensure the value
            //  of the argument matches the case level value
            //switch(char.ToUpper(planid))
            switch (planid)
            {
                case 'A': //planid A
                case 'a': //a second case is treated as a logical OR; solving case-sensitivity 
                    {
                        //you can place any valid C# logic within a case
                        //$9.95 per month for up to 10 hours; additional hours are billed at $2.00 per hour
                        if (hours <= 10)
                        {
                            planAmount = 9.95;
                        }
                        else
                        {
                            planAmount = 9.95 + (hours - 10) * 2.00;
                        }
                        Console.WriteLine($"For your plan {planid} with {hours} hours used " +
                            $"is going to cost {planAmount.ToString("C2")}");
                        break;
                    }
                case 'B':
                    {
                        //B $13.95 per month for up to 20 hours; additional hours are billed at $1.00 per hour
                        if (hours <= 20)
                        {
                            planAmount = 13.95;
                        }
                        else
                        {
                            planAmount = 13.95 + (hours - 20) * 1.00;
                        }
                        Console.WriteLine($"For your plan {planid} with {hours} hours used " +
                            $"is going to cost {planAmount.ToString("C2")}");
                        break;
                    }
                case 'C':
                    {
                        //C $19.95 per month for unlimited hours
                        planAmount = 19.95;
                        Console.WriteLine($"For your plan {planid} with {hours} hours used " +
                            $"is going to cost {planAmount.ToString("C2")}");
                    break;
                    }
                default:
                    {
                        //optional
                        //many times this default is used as a "validation"
                        // in that if any of the above cases are not
                        //  met, the argument value should be considered invalid
                        Console.WriteLine($"\n\tYour planid value of >{planid}< is invalid. Chose A, B or C");
                        break;
                    }

            }//eos
        }
    }
}