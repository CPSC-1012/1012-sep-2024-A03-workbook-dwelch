using CompositeClassess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//when you create a class within a project, by default,
//  the namespace for the class is the project name

namespace Animals
{
   
    public class Dog
    {
  
        private string _Name;
        private double _Age; //omitting the access type for your variable means that the
                             //     access type defaults to private.
        private string _Breed;

        //add a property which is a variable to this class
        //  that represents the owner
        //this is an example of Composition
        public Owner DogOwner { get; set; }

        //this is a collection of visits to the kennel
        //each visit is represented by the class Stay
        //one can on the declaration statement of the property
        //  assign an initial instance to the List
        //  AND this list will be empty BUT it will exist
        //without the assignment the List<T> is null
        public List<Stay> Visits { get; set; } = new List<Stay>();

        //Behaviours (aka methods)

        //mutator (setter)
        public void SetName(string name)
        {
            _Name = name;
        }

        public void SetAge(double age)
        {
            _Age = age;
        }

        //accessor (getter)
        public string GetName()
        {
            return _Name;
        }

        public double GetAge()
        {
            return _Age;
        }

        public void CelebrateBrithday()
        {
          
            _Age = Math.Floor(++_Age);  //using ++Age 4.5 + 1 -> 5.5 -> .Floor(5.5) -> 5
                                        //using Age++ .Floor(4.5) -> 4 -> 4.5 + 1 -> 5.5 
        }

        public void CelebrateBrithday(double newage)
        {
            
            _Age = newage;  
        }

        public override string ToString()
        {
            return $"{_Name},{_Age},{_Breed},{DogOwner.ToString()}";
        }

        public string Name
        {
            //accessor
            get { return _Name; }  //retreives the current value store in the private data member
            //mutator
            set { _Name = value; } //stores the incoming data into the private data member
        }

        public double Age
        {
            //rule: age must be zero or greater
            get { return _Age; }  //retreives the current value store in the private data member
            set 
            { 
                if (value < 0)
                {
                    throw new Exception($"{value} as an Age is invalid. Must be 0 to greater.");
                }
                _Age = value; 
            } //stores the incoming data into the private data member
        }

       

        public string Breed
        {
            //accessor
            get { return _Breed; }  //retreives the current value store in the private data member
            //mutator
            set { _Breed = value; } //stores the incoming data into the private data member
        }

        //  a property without a setter is referred to as "readonly"

        public Dog()
        {
            ////optionally
            ////if you wished, you could assign values to your other data members
            ////  even though they have acceptable defualt values
            Age = 0;
            Name = "unknown";
            Breed = "unknown";

            //create an instance of the class Owner to be used
            //  within this class
            DogOwner = new Owner("Unknown", "Unknown", "000-000-0000");

        }

        public Dog(string name, double age, string breed, Owner owner)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name is missing its data");
            }
            Name = name;
            Age = age;
            Breed = breed;
            DogOwner = owner;
        }
        public Dog(string name, double age, string breed, 
                        string firstname, string lastname, string phone)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name is missing its data");
            }
            Name = name;
            Age = age;
            Breed = breed;
            DogOwner = new Owner(firstname, lastname, phone);
        }
    }
}

