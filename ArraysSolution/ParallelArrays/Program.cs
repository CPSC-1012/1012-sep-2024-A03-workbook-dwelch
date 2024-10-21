// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tParallel Arrays\n\n");

const int PHYSICALSIZE = 25;
int logicalSize = 0;

//create a program that will allow the user to enter up to 25 names
//  and markds in a set of parallel arrays
//Display all the current students and their marks
//Calculate and display the mean average of the marks
//Find the student with the highest mark
//Find the student with the lowest mark

//to shorten the  example, good data will be assumed

string[] students = new string[PHYSICALSIZE];
int[] marks = new int[PHYSICALSIZE];

bool anotherStudent = false;
string inputValue = "";
int mark = 0;

try
{
    do
    {
        Console.Write("Enter the student name:\t");
        inputValue = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(inputValue))
        {
            anotherStudent = true;
            //the logicalSize is acting as the index to our arrays
            //the students and marks are logically linked via the use of
            //  th same index value to indicate the data storage
            students[logicalSize] = inputValue;
            Console.Write($"Enter the mark for {inputValue}:\t");
            inputValue = Console.ReadLine();
            marks[logicalSize] = int.Parse(inputValue);

            //remember to increment your logical count variable: logicalSize
            logicalSize++;
        }
        else
        {
            anotherStudent = false;
        }
    } while (logicalSize < PHYSICALSIZE && anotherStudent);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("\nClass list wiht marks\n");
for (int index = 0; index < logicalSize; index++)
{
    Console.WriteLine($"Student: {students[index]} has a mark of {marks[index]}");
}