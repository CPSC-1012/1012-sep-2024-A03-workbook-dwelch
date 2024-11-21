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

//the class contains the ability to throw Exceptions
//therefore, it is best to do all the processing involving the class
//  within user friendly error handling techniques

try
{ 
    //to access an item within your instance your code will use the dot (.) operate
    //assigning a value to the public characteristic _Name (using a mutator)
    //myDog.SetName("No");
    myDog.Name = "No"; //using a property looks "more like" an assignment to a variable
                       //this makes use of a property, 
                       //a property can be used as "if" it were a variable
                       //the system recognizes that the property is on the left
                       //     side of an assignment operation, and therefore
                       //     knows to used the setter
    myDog.SetAge(4.5);
    myDog.CelebrateBrithday();

    myDog.OwnerFirstName = "Lowand"; //the validation is within the class definition
                                     //the programmer using the class DOES NOT need to code the validation
    myDog.OwnerLastName = "Behold";
    DisplayMyPet(myDog);
}
catch(Exception ex)
{
    Console.WriteLine($"Class data error: {ex.Message}");
}


static void DisplayMyPet(Dog myDog)
{
    //access data within the current instance one could use the characteristic
    //  name if the access level is public (using an accessor)
    //Console.WriteLine($"My dog is called {myDog.GetName()}");  //using a method
    //Console.WriteLine($"The dog belonging to {myDog.OwnerLastName}, {myDog.OwnerFirstName} is called {myDog.Name}");  //using a property
    Console.WriteLine($"The dog belonging to {myDog.FullName} is called {myDog.Name}");  //using a property
                                                                                         //this makes use of a property
                                                                                         //the system recognizes that the property is not
                                                                                         // part of an assignment operation, and therefore
                                                                                         //     knows to used the getter
    Console.WriteLine($"My dog is {myDog.GetAge()} years old");
}


