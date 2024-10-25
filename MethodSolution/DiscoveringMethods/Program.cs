// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tParallel Arrays Using Methods\n\n");

#region Driver Routine
const int PHYSICALSIZE = 25;
int logicalSize = 0;

//create a program that will allow the user to enter up to 25 studnet names
//  and marks in a set of parallel arrays
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
        //the method GetStudentName returns a string.
        inputValue = GetStudentName();
        if (!string.IsNullOrWhiteSpace(inputValue))
        {
            anotherStudent = true;
            //the logicalSize is acting as the index to our arrays
            //the students and marks are logically linked via the use of
            //  the same index value to indicate the data storage
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
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//how to sort the arrays and keep the relationship between the two arrays
Array.Sort(students, marks, 0, logicalSize);

//Call statement
//this statement requests that a specified method be executed
//syntax of the Call statement
//  [returnvariablename = ] methodname([argument list]);
//syntax of the argument list
//    value [, value [...]]
//Rules: for your argument list
//   value is any valid C# value
//   the order of values MUST match the expected order defined by the method
//   the value MUST be of the expected datatype of the parameter defined by the method
DisplayClass(students, marks, logicalSize);
CalculateAverage(logicalSize, marks);
HighestMark(students, marks);
int lowestIndex = GetLowestMarkIndex(students, marks, logicalSize);
Console.WriteLine($"{students[lowestIndex]} has the lowest mark of {marks[lowestIndex]}");

#endregion end of driver

#region Methods
/*
 * benefits of methods
 * Program Readability : methods are smaller pieces of code
 * Program Debugging: you are debugging smaller pieces of code, once working you do not need to look
 *                      at the code again
 * Reusable Code: you can call a method from anyplace any number of times.
 * Improves Maintainability: possible reduction of code in your program thus less to maintain
 * Collaboration: we can develop code in parallel by assigning different method with its 
 *                  specification to different people to develop at the same time
 */

/*
 * Task of a method: the task should be a single process
 * syntax of the method
 *      accessmodifier returndatatype methodname([list of parameters])
 *      {  .... coding block   .... }
 * the list of parameters syntax
 *      datatype localvariablename [, datatype localvariablename [...]]
 * if the method does not return any value then the returndatatype is: void
 * if the method does not return any value then there is NO return statement
 * if the method does return a single value then the returndatatype is that value's datatype
 * if the method does return a single value then there is a return statement containing a
 *      single value (literal or variable or expression)
 */

//NOTE: THIS COURSE, AS A CLASS STANDARD, WILL MAKE ALL METHODS STATIC

//create a method called DisplayClass(string [] names, int[] numbers, int logicalSize)
//method header is the fully qualified method definition
//method signature is the methodname and list of parameters
static void DisplayClass(string[] names, int[] numbers, int logicalSize)
{
    
    //any variable that is required for this code must be declared within the method
    //any variable that is declared within the method exists ONLY as long as the method
    //  executes
    //concern any parameter variable as a locally declared variable
    Console.WriteLine("\nClass list with marks\n");
    for (int index = 0; index < logicalSize; index++)
    {
        Console.WriteLine($"Student: {names[index]} has a mark of {numbers[index]}");
    }

    //this method returns nothing, therefore there is NO return statement
}

//create a method to read the student name
//the methos will return the string
static string GetStudentName()
{
    string inputValue = ""; //this variable will only exists as long the the method executes
    Console.Write("Enter the student name:\t");
    inputValue = Console.ReadLine();

    //the return statement allowes the program to return a single value of the expected
    //  datatype
    return inputValue;
}

static void CalculateAverage(int logicalSize, int[] marks)
{
    //calculate the class mean average
    int sumOfMarks = 0;
    double meanAverage = 0.0;
    int classIndex = 0;
    while (classIndex < logicalSize)
    {
        sumOfMarks += marks[classIndex];
        classIndex++;
    }
    meanAverage = (double)sumOfMarks /(double)logicalSize;
    Console.WriteLine($"The mean average four out {logicalSize} students is {meanAverage.ToString("##0.0")}");
}

static void HighestMark(string[] students, int[] marks)
{
    //find the student with the highest mark
    int highestMark = marks[0]; //assume the first mark is the highest 
    string topStudent = students[0];
    int counter = 0; //the counter is necessary due to the fact that we are
                     //  playing with parallel arrays

    //the foreach loop is used for collections
    //the foreach loop will
    //  a) traverse your collection from the first entry to the last entry
    //  b) you will use a "placeholder" identifier to represent the entry value
    //  c) you DO NOT need to create or manage an index to your array
    //syntax for the foreach loop:
    //  foreach (datatype placeholder in collectionname)
    //  {  ... coding block ...}

    //NOTE: many times you will see that the datatype can be of type: var
    //      if "var" is used then the datatype is resolved at execution time
    //      if using the actual datatype, the resolution is at compile time
    //      "var" takes its datatype from the collection datatype
    //      Using "var" when coding, may affect the intelli-sense for the software

    foreach (int theMark in marks)
    {
        if (theMark > highestMark)
        {
            //new top student
            highestMark = theMark;
            //ONLY because of parallel arrays
            topStudent = students[counter];
        }
        counter++; //only required due to the fact we are playing with parallel arrays
    }

    Console.WriteLine($"{topStudent} has the highest mark of {highestMark}");
}

static int GetLowestMarkIndex(string[] students, int[] marks, int logicalSize)
{
    //find the student with the lowest mark
    int lowestMark = int.MaxValue; //the highest possible integer value
    int lowestIndex = 0; //index of student with the lowest mark

    for (int index = 0; index < logicalSize; index++)
    {
        if (marks[index] < lowestMark)
        {
            lowestMark = marks[index];
            lowestIndex = index;
        }
    }
    return lowestIndex;
}
#endregion end of Methods