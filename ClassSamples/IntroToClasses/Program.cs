// See https://aka.ms/new-console-template for more information
using Animals;

Console.WriteLine("\n\tHello, World of Classes!\n");

//the class standard for coding classes will be
//      each class definition will be coded in a separate physical file

//to use a class in your program you delcare your instance (object)
//  using the class name.

Dog myDog; //this is a variable capable of holding an instance of Dog

//to create an instance (object of) Dog, you will ask the system
//  to create a new instance
myDog = new Dog();

//to access an item within your instance your code will use the dot (.) operate
//assigning a value to the public characteristic _Name (using a mutator)
myDog.SetName("No");

//access data within the current instance one could use the characteristic
//  name if the access level is public (using an accessor)
Console.WriteLine($"My dog is called {myDog.GetName()}");
Console.WriteLine($"My dog is {myDog.????} years old");


