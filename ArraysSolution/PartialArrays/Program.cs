// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tPartial Array Filling\n\n");

//you still must declare your array to its full size
const int PHYSICALSIZE = 10;
int [] numbers = new int[PHYSICALSIZE];

/*
 * Arrays do not need to be completely filled
 * Arrays that are not completely fillled are called partial arrays
 * with a partially filled array, one needs to track the actual number
 *      of elements that have "real meaningful" data
 * With the declaration of your array, the elements are set to the default
 *      datatype value
 *      example: numeric arrays will be filled with zeros
 * to track the meaningful elements in th array we use another integer value
 * this value is usually referred to as the "logical size"
 * Assumption that the array is filled from index 0 onwards
 */

//this variable will track the number of real meaningful pieces of data
//this is also treated as a natural count
int logicalSize = 0;

string inputValue = "";
bool flag = true;
int num = 0;
int sumOfElements = 0;
double averageOfElements = 0.0;

while(flag)  //1
{
    if (logicalSize == PHYSICALSIZE)  //1
    {
        //no more space to save data within the array
        flag = false;
        Console.WriteLine("\n\tArray is full\n");
    }
    else
    {
        Console.Write("Enter a positive non-zero number (enter a character to quit:\t");
        inputValue = Console.ReadLine();
        if ( int.TryParse(inputValue, out num))  //2
        {
            if(num <= 0) // 3
            {
                Console.WriteLine($"Your value of {num} is not a non-zero positive number. Try again.");
            }
            else
            {
                //assume data is valid as expected
                //need to store the data in the first available array element
                //your current logical count (natural number) can act as the
                //      index in the array AS LONG as the increment to your
                //      logical count is done AFTER the data is stored
                numbers[logicalSize] = num;

                //increment your logical count
                logicalSize += 1;
            }//eof 3
        }
        else
        {
            //non numeric
            //request to quit
            flag = false;
        }//eof  2
    }//eof 1
}//eol 1

//the for loop will use the logical size to control when to exit the loop
//you can still loop through your entire array

//Console.WriteLine("\nFull array\n");
//for(int index = 0; index < numbers.Length; index++)
//{
//    Console.WriteLine($"The number at index {index} is the {index + 1}th element and is {numbers[index]}");
//    sumOfElements += numbers[index];
//}
//averageOfElements = (double)sumOfElements / (double)PHYSICALSIZE;
//Console.WriteLine($"The average of your data is {averageOfElements.ToString("##0.00")}");

//averageOfElements = sumOfElements = 0; //cute C#

//Console.WriteLine("\nPartial array\n");
////this loop only wishes to process the meaningful data stored within the array
////to do so, the stopping limit is indicated by the "logicalSize"
//for (int index = 0; index < logicalSize; index++)
//{
//    Console.WriteLine($"The number at index {index} is the {index + 1}th element and is {numbers[index]}");
//    sumOfElements += numbers[index];
//}

////note: the division is by the logical number of meaningful element
//averageOfElements = (double)sumOfElements / (double)logicalSize;
//Console.WriteLine($"The average of your data is {averageOfElements.ToString("##0.00")}");


//Does partial arrays affect how built-in methods work?  NO
//Does partial arrays affect the expected result of built-in methods: YES

//lets take sorting as an example
//Sort the full array
//Array.Sort(numbers);
//Console.WriteLine("\nFull sorted array\n");
//for (int index = 0; index < numbers.Length; index++)
//{
//    Console.WriteLine($"The number at index {index} is the {index + 1}th element and is {numbers[index]}");
//}

//Sort the partial array
Array.Sort(numbers,0,logicalSize);
Console.WriteLine("\nFull partial array\n");
for (int index = 0; index < PHYSICALSIZE; index++)
{
    Console.WriteLine($"The number at index {index} is the {index + 1}th element and is {numbers[index]}");
}