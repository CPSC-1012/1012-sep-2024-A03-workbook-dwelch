// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tWelcome to the Collective\n\n");

//a single variable holds a single value
//it can be altered
//syntax: datatype variablename [= initialvalue];

int grade = 78;

//a Collection
//C# supports various kinds of collections
//we will concentration at this time on Arrays
//an array represents a number of values of the same datatype
//referencing a particular value within the collection can be done using an "index"
//arrays are fixed size collections
//arrays hold a single datatype of values
//you must specify the maximum size of your array before you can use it
//if you try to reference an item via the index and the index is < 0 or greater then the max size, your
//  code will abort with an expection
//each value in the array can be referred to as the array element.
//syntax:  datatype [] arrayname [= new datatype[max-size]];

//Create an array of grades for a class of size 33.
//We will fill the arrays with a random set of grades between 0 and 100

//you might wish to create a constant variable for your array max size
const int PHYSICALSIZE = 33;

//setup the array
//declaration
double[] grades;
//set the size
grades = new double[PHYSICALSIZE]; //you could put the value 33 instead of the constant 

//optionally the declaration and sizing can be done in one line
//double [] grades = new double[PHYSICALSIZE];

//create the random generator
Random rnd = new Random();

//traverse (walk through the array) the array filling in each element with a
//  random value between 0 and 100 inclusive
//since arrays are of a particular size and referencing an array element
//  is via a numeric index, the preferred iteration structure would be the for loop
//the index of this array is 0 through 32 (the natural count is 1 to 33)

for (int index = 0; index < PHYSICALSIZE; index++)
{
    //type casting, place a (datatype) in from of your value, temporarily changed
    //  the datatype of the value to the casting type
    grades[index] = (double)rnd.Next(0, 10001) / 100.0;
    //this is using .NextDouble to do the same thing
    //grades[index] = rnd.NextDouble() * 100.0;
}

//traverse (walk through the array) the array display each array element
for (int index = 0; index < PHYSICALSIZE; index++)
{
    Console.WriteLine($"The grade at index {index} is the {index+1}th element and is {grades[index]}");
}

//declaring the array size by supplying a set of values on the declaring statement
//when you supply a set of values, the system automatically set the size of your array
//  to the number of values
//using this technique not only gives the array its size BUT ALSO its initial element values
//the following creates an array of 7 elements which element holds a string
string[] dayOfWeek = new string[] {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

//how does one know the size of their array?
//arrays have properties that the coder can access
//the array size property is: .Length
for (int index = 0; index < dayOfWeek.Length; index++)
{
    Console.WriteLine($"The week day at index {index} is the {index+1}th element and is {dayOfWeek[index]}");
}

//array have built-in functionality that you as a coder can use
//How about sorting the array?
//you could use the array method called Sort

//default ascending sort
//Array.Sort(grades); 
//for (int index = 0; index < PHYSICALSIZE; index++)
//{
//    Console.WriteLine($"The grade at index {index} is the {index+1}th element and is {grades[index]}");
//}

//there are other syntaxes that can be used to do the same actions
//sort ascending
//Array.Sort(grades, (x, y) => x.CompareTo(y)); //ascending predicate (x, y) => x.CompareTo(y)
//sort descending
Array.Sort(grades, (x, y) => y.CompareTo(x)); //descending predicate (x, y) => y.CompareTo(x)
for (int index = 0; index < PHYSICALSIZE; index++)
{
    Console.WriteLine($"The grade at index {index} is the {index+1}th element and is {grades[index]}");
}

//clear the array
Array.Clear(grades);
for (int index = 0; index < grades.Length; index++) //you be using .Length for grades instead of PHYSICALSIZE
{
    Console.WriteLine($"The grade at index {index} is the {index+1}th element and is {grades[index]}");
}
