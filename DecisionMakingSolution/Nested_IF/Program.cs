// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tGames! Games! Games!\n");

// We are going to code the rock, paper, scissors game

/*
 * Rock, Paper, Scissors Game
 * Author: Don Welch
 * Last Update: Oct 4 2024
 * 
 * Computer will generate a random choice of rock (0) paper (1) or scissors (2)
 * User will chose rock paper or scissors
 * Validate incoming data using user friendly error handling and defensive coding
 * this program is to demonstrate control structures 
 *    if/else
 *    nested if
 * output result of a match
 * 
 */

string inputValue = "";
Random rnd = new Random(); //this is the random number generator
int machineChoice = 0;
int userChoice = 0;

//generate the computer choice
//.Next(inclusive,exclusive)
machineChoice = rnd.Next(0, 3);  //0,1 or 2

//get user choice
//data validation, defensive programming
Console.WriteLine("Game choices: Rock (0), Paper (1) or Scissors (2).");
Console.Write("Enter you game choice:\t");
inputValue = Console.ReadLine();
//defensive coding
//check if the input value is actually a string BEFORE attempting to
//  convert the input into a number

//use: xxx.TryParse(string, out variable
//where xxx is your datatype
//      string is the data to convert
//      out is a required keyword
//      variable is where the convert data will be placed
//the TryParse returns a boolean true or false
//
//possible results
//   a) true: data is converted and place in the out variable
//   b) false: data is not converted, not placed in out variable, and program does not abort

//bool result = int.TryParse(inputValue, out userChoice);
//if (result)
if(int.TryParse(inputValue, out userChoice))
{
    //the user entered a number
    //is it a valid choice?

    //we will asked another question (decision) within tryparse question
    //this is referred to as a Nested-if (an if structure inside another if structure)
    //this is an example of using a logic operator
    // read the statements as data operator value OR data operator value
    if (userChoice < 0 || userChoice > 2)
    {
        Console.WriteLine($"Your entry of {userChoice} is invalid: not 0,1 or 2. Try again.");
    }
    else
    {
       //an acceptable user value
       if (userChoice == 0)
        {
            //using this structure, the structure is exited ONCE a if has been matched
            if(machineChoice == 0)
            {
                Console.WriteLine("\n\tYou and the computer are both rocks. It is a draw");
            }
            else
            {
                if (machineChoice == 1)
                {
                    Console.WriteLine("\n\tYou are a rock and the computer is paper. You lose");
                }
                else
                {
                    Console.WriteLine("\n\tYou are a rock and the computer is scissors. You win");
                }
            }
        }
       if (userChoice == 1)
        {
            //using this structure EACH inner if is done
            if (machineChoice == 0)
            {
                Console.WriteLine("\n\tYou are paper and the computer is rock. You win");
            }
            if (machineChoice == 1)
            {
                Console.WriteLine("\n\tYou are paper and the computer is paper. It is a draw");
            }
            if (machineChoice == 2)
            {
                Console.WriteLine("\n\tYou are paper and the computer is scissors. You lose");
            }
            
        }
       //using logic operators
       if (userChoice == 2 && machineChoice == 0)
        {
            Console.WriteLine("\n\tYou are scissors and the computer is rock. You lose");
        }
        if (userChoice == 2 && machineChoice == 1)
        {
            Console.WriteLine("\n\tYou are scissors and the computer is paper. You win");
        }
        if (userChoice == 2 && machineChoice == 2)
        {
            Console.WriteLine("\n\tYou are scissors and the computer is scissors. It is a draw");
        }
    }
    
}
else
{
    Console.WriteLine($"Your entry of {inputValue} is invalid. Try again.");
}


