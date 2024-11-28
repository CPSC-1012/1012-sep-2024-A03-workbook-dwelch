// See https://aka.ms/new-console-template for more information

//There will be times that the definition of the class you wish to use
//  has a different namespace then your project.
//To be able to use the class in the different namespace you will need
//  to include a using statement indicating the desire namespace of the class definition
//IN ADDITION, the physical location of this other namespace may be outside of the 
//  project that you was currently coding within
//To solution this problem, you will need to add a project reference to
//  your current project pointing to the project that contains the class definition

//Steps:
//a) right click on Dependencies of the project in which you are working
//b) select Add project reference
//c) select the project you wish to have access to by checking the checkbox
//d) press OK

using Animals;

Console.WriteLine("\n\tHello, Objects in the Collective!\n");

//there are different types of collections within C#
//Arrays
//List<T>
//generic collections such as IEnumerable<T>, IQueryable<T>
//the <T> represents a valid C# datatype INCLUDING program defined datatypes

//List<T> vs Array
//both can be handled with indexes
//both can be used in iterations
//both hold a specific datatype
//both need to be declare and created
//in C# both have built in methods to apply against the data

//major difference
//Arrays are fixed size
//List<T> is dynamic in size

Dog theDog = null;
int logicalSize = 0;
Dog[] arrayOfDogs = new Dog[5];

//create a single dog
theDog = new Dog("No", 14.6, "Lowand", "Behold", "Mixed");

//add to the array collection
arrayOfDogs[logicalSize] = theDog;
logicalSize++;
arrayOfDogs[logicalSize] = new Dog("Bad", 4.6, "Charity", "Kase", "BloodHound");
logicalSize++;
arrayOfDogs[logicalSize] = new Dog("Boo", 7.2, "Pat", "Downe", "Collie");
logicalSize++;

DisplayArray(arrayOfDogs, logicalSize);

//this sort uses the entire array whether you have data in all elements or not.
//we have two elements with no data
//the default for an instance of a class (not create) is null
//therefore this command will abort when it attempts to access the elements in the array
//      that are empty (value of element is null)
//Array.Sort(arrayOfDogs, (x, y) => x.Name.CompareTo(y.Name));

//int startindex = 0;
//Array.Sort<Dog>(arrayOfDogs, startindex, logicalSize, new Comparison<Dog>((x, y) => x.Name.CompareTo(y.Name)));

//DisplayArray(arrayOfDogs, logicalSize);


//********************************* List<T> *********************************************************
//lets do the same with a List<T> collection
//note: there is no logicalSize tracking of the instances within the List<T>

List<Dog> listOfDogs = new List<Dog>();

Console.WriteLine("\n\nPlaying with List<T> where <T> is the class Dog\n\n");

Console.WriteLine($"\nThe number of entries in the list is currently {listOfDogs.Count}\n");

//Add an instance of dog to the list
//NOTE: there is NO logical size to track for a list
//      there is NO need to increment a counter (logicalSize)
theDog = new Dog("No", 14.6, "Lowand", "Behold", "Mixed");
//add to the list
listOfDogs.Add(theDog);
Console.WriteLine($"\nThe number of entries in the list is currently {listOfDogs.Count}\n");

listOfDogs.Add(new Dog("Bad", 4.6, "Charity", "Kase", "BloodHound"));
listOfDogs.Add(new Dog("Boo", 7.2, "Pat", "Downe", "Collie"));

Console.WriteLine($"\nThe number of entries in the list is currently {listOfDogs.Count}\n");
DisplayList(listOfDogs);

//other methods in the List class
//Sort
listOfDogs.Sort((x, y) => x.Name.CompareTo(y.Name)); //ascending
//listOfDogs.Sort((x, y) => y.Name.CompareTo(x.Name)); //descedning

DisplayList(listOfDogs);


//can on find an instance that matches a search criteria
//Find
//FindIndex
//FindLast
//FirstOrDefault
// is there a dog called Boo
//RETURNS a copy of the address of the instance in memory

Dog foundDog = listOfDogs.FirstOrDefault(d => d.Name.Equals("Boo")); //Equals is the exact whole match
                                                                     //Contains is a partial match

if (foundDog != null)
{
    //found it
    Console.WriteLine($"\n\tA dog called Boo exists in the kennel and is owned by {foundDog.FullName}");

    //can I remove the instance from the list (memory)
    listOfDogs.Remove(foundDog);
}
else
{
    //did not find it
    Console.WriteLine("\n\tA dof called Boo does not exist in the kennel");
}
DisplayList(listOfDogs);

static void DisplayArray(Dog[] kennel, int logicalSize)
{
    Console.WriteLine("\nDon's Kennel\n");
    Console.WriteLine("{0,-15} {1,5} {2,-30} {3,-15}", "Name", "Age", "Onwer", "Breed");

    Console.WriteLine("\n\t using the for loop and indexes\n");
    for (int i = 0; i < logicalSize; i++)
    {
        Console.WriteLine("{0,-15} {1,5} {2,-30} {3,-15}",
                kennel[i].Name, kennel[i].Age, kennel[i].FullName, kennel[i].Breed);
    }
    Console.WriteLine("\n\t using the foreach loop\n");

    //the foreach is
    //starting at the begining of the collection
    //auto assigns the instance of the collection to the placeholder
    //automatically moves between each instance within the array
    //auto end to collection
    foreach (Dog item in kennel)
    {
        //you need to remember that the array has elements for each and every
        //  phyiscal index where the unused elements will be null
        //you must check to see if the array element has an instance
        if (item != null)
            Console.WriteLine("{0,-15} {1,5} {2,-30} {3,-15}",
                  item.Name, item.Age, item.FullName, item.Breed);
    }
}

static void DisplayList(List<Dog> kennel)
{
    Console.WriteLine("\nDon'w Kennel\n");
    Console.WriteLine("{0,-15} {1,5} {2,-30} {3,-15}", "Name", "Age", "Onwer", "Breed");

    Console.WriteLine("\n\t using the for loop and indexes\n");
    //note instead of the condition using "logicalSize" we use the List<T> property .Count
    for (int i = 0; i < kennel.Count; i++)
    {
        Console.WriteLine("{0,-15} {1,5} {2,-30} {3,-15}",
                kennel[i].Name, kennel[i].Age, kennel[i].FullName, kennel[i].Breed);
    }
    Console.WriteLine("\n\t using the foreach loop\n");

    //the foreach is
    //starting at the begining of the collection
    //auto assigns the instance of the collection to the placeholder
    //automatically moves between each instance within the array
    //auto end to collection
    foreach (Dog item in kennel)
    {
        //you need to remember that the List ONLY contains an "item"
        //  for each instance physically in the list

        Console.WriteLine("{0,-15} {1,5} {2,-30} {3,-15}",
              item.Name, item.Age, item.FullName, item.Breed);
    }
}

