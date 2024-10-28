// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tSimple Calculator using Methods\n");

//author Don Welch
//last modified: Oct 28 2024
//Create a calculator demonstrating modular approach to developing solution

#region Driver
int num1 = 0;
int num2 = 0;
string choice = "";
double results = 0;
bool validFlag = false;
string symbol = "";

//get two numbers for the calculator from the user
num1 = GetNumber("Enter your first whole number for the calculation");
num2 = GetNumber("Enter your second whole number for the calculation");

//get the choice of calculation type from the user
DisplayMenu();
choice = Console.ReadLine();

//decide the choice and do the calculation
switch (choice.ToUpper())
{
    case "A":
        {
            results = num1 + num2;
            validFlag = true;
            symbol = "+";
            break;
        }
    case "B":
        {
            results = num1 - num2;
            validFlag = true;
            symbol = "-";
            break;
        }
    case "C":
        {
            results = num1 * num2;
            validFlag = true;
            symbol = "*"; 
          
            break;
        }
    case "D":
        {
            if (num2 != 0)
            {
                results = num1 / num2;
                validFlag = true;
                symbol = "/";
            }
            else
            {
                Console.WriteLine("\n\tDividing by zero is invalid.\n");
                validFlag = false;
            }
            break;
        }
    default:
        {
            Console.WriteLine("Your option choice is invalid. Try again.");
            break;
        }
}


//display the results of the calculation
DisplayResults(num1, num2, results, validFlag, symbol);
#endregion

#region Methods
//when given the method header, it is an implied contract

// void DisplayMenu(): this will display the menu options for the calculator
static void DisplayMenu()
{
    // a method stub is the method header and empty coding block
    Console.WriteLine("\nThe options for your calculator are:");
    Console.WriteLine("a) Add");
    Console.WriteLine("b) Subtract");
    Console.WriteLine("c) Multiply");
    Console.WriteLine("d) Divide");
    Console.Write("Enter your calculation choice:\t");
}

// int GetNumber(string prompt): this will receive a string to prompt the user for
//                                  a whole number and return the entered number
static int GetNumber(string prompt)
{
    //since this method returns a value, you will need to put a temporary
    //  return statement in the coding block
    bool validFlag = false;
    string inputValue = "";
    int number = 0;
    do
    {
        validFlag = true;
       
        Console.Write($"{prompt}:\t");
        inputValue = Console.ReadLine();
        if (!int.TryParse(inputValue, out number))
        {
            Console.WriteLine($"\n\tInput error: >{inputValue}< is not a number");
            validFlag = false;
        }

    } while (!validFlag);
    return number;
    //this return statement is only here in the stub to return a valid value
    //this return statement WILL be replaced once the method is actually coded
    //return 0;
}


// void DisplayResults(int num1, int num2, double results, bool valid, string sybmol):
//  this method will receive the 2 numbers involved in the calculation, the calculation
//  result, a flag indicating the success of the calculation and a symbol representing the
//  calculation. Require out sample; 4 + 5 = 9
static void DisplayResults(int num1, int num2, double results, bool valid, string symbol)
{
    if (valid)
        Console.WriteLine($"\n\t{num1} {symbol} {num2} = {results}");
}
#endregion
