// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("\n\tModular Division\n");

//Write a program that will generate up to a three-digit whole number. The program will
//then calculate the sum of the digits of the number, and then display both the number and its
//digit sum. (i.e. 123 -> sum = 6)

//detail steps
//DECLARE hundreds, tens, units, randomNumber as int
//DECLARE sumOfDigits as int
//DECLARE tempDigits as int
//DECLARE rnd as Random //using the Random class

//processing
//CREATE an instance of Random in rnd
//SET the random number from the Random generator
//EXTRACT the hundreds digit
//SET the tempDigits to remaining digits
//EXTRACT the tens digit
//EXTRACT the units digit
//CALCULATE the sum of digits

//output
//DISPLAY original number and sum of digits

int hundreds = 0, tens = 0, units = 0, tempDigits = 0, sumOfDigits = 0;
int randomNumber;

//the Random class will allow the program to generate random numbers
//This class requires the programmer to create an unique instance
Random rnd; //this allocates a "parking space" for your instance
rnd = new Random(); //this actually creates the instance of the class

//can one code the above in one line: YES
//Random rnd = new Random();

//the following statement uses the generator method called .Next()
//we will supply a range of numbers to limit the number generated
//NOTE: the range is from your lower number (inclusive) to 1 less
//      then the upper range. eg 0 to 100 create numbers 0 to 99
randomNumber = rnd.Next(0, 1000);  //456

//extract the hundreds digit
//integer division
hundreds = randomNumber / 100;     //4
//obtain the remaining digits
//modular division
tempDigits = randomNumber % 100;   //56

//extract the tens digit
tens = tempDigits / 10;             //5
//extract the units digit
units = tempDigits % 10;            //6

//sum of digits
sumOfDigits = hundreds + tens + units;


//output
Console.WriteLine($"The sum of digits for {randomNumber} is {sumOfDigits}.");