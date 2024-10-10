// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tRound and Round and Round we go!\n\n");

///<summary>
///
/// Name: Don Welch
/// Last Modified: Oct 10 2024
/// 
/// Find the sum of the squares of the integers from 1 to MySquare, where MySquare is input by the user.  
/// E.g. user enters 4 then return 1x1 + 2x2 + 3x3 + 4x4 = 30
/// 
/// Detail Steps
/// DECLARE inputValue as string
/// DECLARE mySquare as int
/// DECLARE sumOfSquares as int
/// DELCARE loopCounter as int intialize to 1
/// 
/// REPEAT WHILE input is invalid
///     Prompt "Enter the integer upper square number to sum"
///     READ inputValue
///     check inputvalue to be valid
///       if no display an appropriate message
///       if yes SET mySquare to inputValue
/// end loop
/// 
/// REPEAT WHILE loop counter <= MySquare
///     Calculate the square of the loop counter
///     Add to the sum of the squares (sumOfSquares)
///     increment the loop counter by +1
///     DISPLAY the calculate as (loopcounter X loopcounter)
/// END LOOP
/// DISPLAY the final sum of squares.
/// 
/// </summary>
/// 

int mySquare = 0;
int sumOfSquares = 0;
string inputValue = "";

//possible stopping conditions
//a) mySquare > 0 (if not continue while mySquare <=0)
//b) setup a boolean variable to act as a "flag" to execute loop or terminate loop

//this is the flag for example b
bool invalid = true; 

//while (mySquare <= 0) //the while statement for option (a)
while (invalid) //the while statement for option (b)
{
//if the condition is true, do the code in the loop

    Console.Write("Enter a positive whole number to create a sum of squares:\t");
    inputValue = Console.ReadLine();
    if (!int.TryParse(inputValue, out mySquare))
    {
        //bad data
        Console.WriteLine($"\tYour input of >{inputValue}< is not a positive whole number. Try again.");
        //exit if, then loop
    }
    else
    {
        if(mySquare <= 0)
        {
            //bad data
            Console.WriteLine($"\tYour input of >{mySquare}< is not a positive whole number greater than 0. Try again.");
            //exit if, then loop
        }
        else
        {
            //only needed for option (b)
            invalid = false; //change the flag to terminate the loop
        }
    }//eof
}//eol

Console.WriteLine($"\nyou entered {mySquare}\n");

//solution using a loop to sum the squares
////option a) using a while loop
////    why: you could have an unknown number of times to execute the loop

//int loopCounter = 1; 
//Console.Write($"The sum of squares for {mySquare} is ");
//while(loopCounter <= mySquare)
//{

//    sumOfSquares += loopCounter * loopCounter;
//    Console.Write($"{loopCounter}X{loopCounter}");
//    if(loopCounter < mySquare)
//    {
//        Console.Write(" + ");
//    }
//    else
//    {
//        Console.Write(" = ");
//    }
//    //IMPORTANT!!!!!!!!!! remember to increment your loopCounter
//    //loopCounter = loopCounter + 1;
//    //loopCounter += 1;
//    loopCounter++; //increment of a nummeric by +1
//}

//Console.Write($"{sumOfSquares}\n");

//option b) using a for loop (sometimes also called the counter loop)
//    why: you could have an known number of times to execute the loop

//syntax for the for loop
// for(declaration/initialization of loop counter; termination condition; increment counter code)
// {
//     loop logic code
//  }

//NOTE: WARNING any variable declared within a loop is ONLY in existence while the loop is active
//              you would get a ""out of content" error
//              this is part of the variable scope

Console.Write($"The sum of squares for {mySquare} is ");
for (int forCounter = 1; forCounter <= mySquare; forCounter++)   //the increment code code also be forCounter += 1
{

    sumOfSquares += forCounter * forCounter;
    Console.Write($"{forCounter}X{forCounter}");
    if (forCounter < mySquare)
    {
        Console.Write(" + ");
    }
    else
    {
        Console.Write(" = ");
    }
    
}//eol

Console.Write($"{sumOfSquares}\n");
