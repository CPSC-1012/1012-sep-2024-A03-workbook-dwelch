// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tDecisions Decisions Decisions .... What to do?\n\n");

/*
 * this is a comment block
 * 
 * Decisions control the flow of your critical paths through your program
 * 
 * All program languages use some reserved work for this command
 * C# uses the keyword structure: if/else
 * C# has serveral structures that can do flow-of-control
 * 
 * One-way path
 *      if (condition(s))
 *      {
 *          true action code
 *      }
 *      
 * Two-way path
 *      if (condition(s))
 *      {
 *          true action code
 *      }
 *      else
 *      {
 *          false action code
 *      }
 *      
 * Nested-if
 *      if (condition(s))
 *      {
 *          if (condition(s))
 *          {
 *              true action code
 *          }
 *          else
 *          {
 *              if (condition(s))
 *              {
 *                  true action code
 *              }
 *              else
 *              {
 *                  false action code
 *              }
 *          }
 *      }
 *      else
 *      {
 *          if (condition(s))
 *          {
 *              true action code
 *          }
 *      }
 *     
 * Branching path
 *      if (condition(s))
 *      {
 *          true action code
 *      }
 *      else if (condition(s))
 *      {
 *          true action code
 *      }
 *      else if (condition(s))
 *      {
 *          true action code
 *      }
 *      ....
 *      else
 *      {
 *          false action code
 *      }
 *      
 * case structure
 *      switch (argument)
 *      {
 *          case testvalue:
 *          {
 *              case code
 *              break;
 *          }
 *          case testvalue:
 *          {
 *              case code
 *              break;
 *          } 
 *          case testvalue:
 *          {
 *              case code
 *              break;
 *          }
 *          ...
 *          default:
 *          {
 *              case code
 *              break;
 *          }
 *      }//eos
 *      
 * rules:
 *  the { } around your tru/false actions are optional, IF and ONLY IF the code is a
 *      single statement in the action OTHERWISE the brackets are required.
 *      
 *  the else is optional, if only a one-way path is needed
 *  the true path is required
 *  
 *  you can have sequential processing before and following an if structure
 *  
 */

//one-way path
//  there is no else (false) path logic

//Do I pay taxes on an item?
//if so, what is my tax amount?

bool taxable = true;
int quantity = 5;
double gst = 0.05;
double price = 2.75;
double tax = 0.0;

//is the item taxable
/*
 * the if conditions consists of a argument; a comparison condition; value
 * keywords: true and false
 * the argument and value can be variables or literals or special keywords
 * 
 * comparsion conditions
 * 
 *      relative operators
 *      equals: == (note the = symbols is the assignment operator)
 *      greater than: >
 *      less than: <
 *      greater than or equal to: >=
 *      less than or equal to: <=
 *      not equal to: != or <>
 *      
 * you can have multiple conditions in your if
 * 
 *      logical operators
 *      and: &&
 *      or: ||
 *      
 * Bitwise operators (popular in gaming coding)
 * work at the binary value level of your value
 *      and: &
 *      or: |
 *      
 * Examples
 *   (a > c)  : value a is greater than value c
 *   ((a + b) < c) : the expression (a + b) is less than the value c
 *      1) sum of a + b is done
 *      2) compares the sum to c
 *      3) resolves to a boolean true or false
 *      
 */

//
//  ALL IF CONDITIONS WILL RESOLVE EVENTUALLY DOWN TO A TRUE OR FALSE VALUE!!!!!!
//

//if (taxable == true)
if(taxable) //  the more acceptable way of testing a boolean variable
{
    //if true (yes)
    // do some type of action
    //true path
    tax = (quantity * price) * gst;
}

Console.WriteLine($"The tax on my {quantity} items each priced at " +
    $"{price.ToString("#,##0.00")} with a tax rate of {gst * 100}% is " +
    $"{tax.ToString("#,##0.00")}");

/*
 * Write a program that lets the user guess whether the flip of a coin results in 
 *          heads or tails. 
 * The program randomly generates an integer 0 to 1, which represents head or tail. 
 * The program prompts the user to enter a guess, and reports whether the guess is 
 * correct or incorrect. 
 */

string inputValue;
int guess = 0;
Random rnd = new Random(); //random number generator
//generate the computer flip
int flip = rnd.Next(0, 2); //range values are (inclusive,exclusive)
Console.Write("\n\nEnter 0 for heads or 1 for tails:\t");
inputValue = Console.ReadLine();
guess = int.Parse(inputValue);

//decide whether the user has guessed correctly and output an appropriate message

//there is two possible outcomes: a)correct guess or b) incorrect guess
//this is a two-way structure
//this will required the > else < in my decision logic

if(flip == guess)
{
    //
    //true path
    //
    Console.WriteLine($"\tYour guess of {guess} matches the flip of {flip}");
    //after executing the path, your program continues to the next statement
    //  following the if structure (eoc)
}
else
{
    //
    //false path
    //
    Console.WriteLine($"\tYour guess of {guess} does not match the flip of {flip}");
    //after executing the path, your program continues to the next statement
    //  following the if structure (eoc)
}//eoc (end of condition)

Console.WriteLine($"\nThis is the next line after the decision structure in your program");