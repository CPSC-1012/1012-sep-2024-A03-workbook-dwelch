// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tUsing Branch IF Technique\n\n");

/*
 * 
 * Name: Don Welch
 * Last updated: Oct 7 2024
 * 
 * Problem:
 * Write a program that will determine the cost of admission for a theatre.  
 * The price of admission is based on the age of the customer.  
 * Your program should prompt the user for their age and then display the correct 
 * admission amount.  
 * 
 * Children 6 and under = FREE ($0.00) 
 * Students 7 to 17 = $9.80 
 * Adults 18 to 54 = $11.35 
 * Seniors 55+ = $10.00 
 * 
 * this problem can be solved using a nested if technique
 * it can also be solve using the branching if-else if technique
 * 
 * syntax:
 * 
 *   if (condition(s))                                      if(condition(s)
 *   {                                                      {
 *      true path                                               true path
 *   }                                                      }
 *   else if (condition(s)                                  else
 *   {                                                      {
 *      true path                                                if(condition(s)
 *   }                                                           {
 *   [else if (condition(s))                                         true path
 *    {                                                           }
 *       true path                                                else
 *    } ....]                                                     {  
 *   else                                                              .....
 *   {                                                             } 
 *      required                                             }   
 *      only false path (the "left overs")
 *   }
 */

string inputValue;
int age = 0;
double admissionAmount = 0.00;

Console.Write("Enter you age in years:\t");
inputValue = Console.ReadLine();
if(!int.TryParse(inputValue, out age))
{
    Console.WriteLine($"Your input of >{inputValue}< is not a number indicating your age.");
}
else
{
    if (age < 0)
    {
        Console.WriteLine($"Your input of >{age}< is a negative number. Age needs to be 0 or greater.");
    }
    else
    {
        //at this point in your proces, you can assume your data is valid


        //NOTE: the relative operator here is NOT an equals
        //      this means this branch CANNOT be coded as a case-structure
        //      ALL case-structures can be coded as a branch structure BUT
        //          not all branch structures can be coded as a case structure
        if (age <= 6)
        {
            //logic for 6 and under
            admissionAmount = 0.00;
        }
        else if(age <=17) //valid but not necessary (age > 6 && age <=17 )
        {
            //logic for a student
            admissionAmount = 9.00;
        }
        else if(age <= 54)
        {
            //logic for an adult
            admissionAmount = 11.35;
        }
        else
        {
            //everyone else (senior)
            admissionAmount = 10.00;
        }

        //can this answer be coded as a nested-if
        //if (age <= 6)
        //{
        //    //logic for 6 and under
        //    admissionAmount = 0.00;
        //}
        //else
        //{
        //    if (age <=17) //valid but not necessary (age > 6 && age <=17 )
        //    {
        //        //logic for a student
        //        admissionAmount = 9.00;
        //    }
        //    else
        //    {
        //        if (age <= 54)
        //        {
        //            //logic for an adult
        //            admissionAmount = 11.35;
        //        }
        //        else
        //        {
        //            //everyone else (senior)
        //            admissionAmount = 10.00;
        //        }
        //    }
        //}



            Console.WriteLine($"\n\tA Ticket for your age of {age} " +
            $"will cost ${admissionAmount.ToString("#0.00")}");
    }
} 