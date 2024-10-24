// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tParallel Arrays\n\n");

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

//how to sort the arrays and keep the relationship between the two arrays
Array.Sort(students, marks, 0, logicalSize);


Console.WriteLine("\nClass list wiht marks\n");
for (int index = 0; index < logicalSize; index++)
{
    Console.WriteLine($"Student: {students[index]} has a mark of {marks[index]}");
}

//calculate the class mean average
int sumOfMarks = 0;
double meanAverage = 0.0;
int classIndex = 0;
while(classIndex < logicalSize)
{
    sumOfMarks += marks[classIndex];
    classIndex++;
}
meanAverage = (double)sumOfMarks /(double)logicalSize;
Console.WriteLine($"The mean average four out {logicalSize} students is {meanAverage.ToString("##0.0")}");

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

foreach(int theMark in marks)
{
    if(theMark > highestMark)
    {
        //new top student
        highestMark = theMark;
        //ONLY because of parallel arrays
        topStudent = students[counter];
    }
    counter++; //only required due to the fact we are playing with parallel arrays
}

Console.WriteLine($"{topStudent} has the highest mark of {highestMark}");

//find the student with the lowest mark
int lowestMark = int.MaxValue; //the highest possible integer value
int lowestIndex = 0; //index of student with the lowest mark

for(int index = 0; index < logicalSize; index++)
{
    if (marks[index] < lowestMark)
    {
        lowestMark = marks[index];
        lowestIndex = index;
    }
}
Console.WriteLine($"{students[lowestIndex]} has the lowest mark of {marks[lowestIndex]}");