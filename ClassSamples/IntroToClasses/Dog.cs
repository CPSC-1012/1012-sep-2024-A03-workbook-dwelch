using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//when you create a class within a project, by default,
//  the namespace for the class is the project name

namespace Animals
{
    //the definition of the class name
    //  a) access level
    //       private nothing outside of the class has acces to items
    //          within the class
    //       internal access to the class is limited to programming
    //          within the project
    //       public access to the class is open to an outside user
    //          of the class
    //  b) the key word class
    //  c) the programmer/developer define name of the class
    public class Dog
    {
        //declares the characteristics of a Dog
        //each characteristic is a variable
        //a valid characteristic has a valid C# datatype
        //NOTE: a class can have various datatypes

        //Data Members (aka fields, variables, value,....)

        //if you wish to encapsulate your data in a secure fashion
        //  your characteristics have an access type of private

        private string _Name;
        private double _Age; //omitting the access type for your variable means that the
                             //     access type defaults to private.
        private string _OwnerFirstName;
        private string _OwnerLastName;
        private string _Breed;

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

        //methods that do "stuff" against the data contained within the class
        //if the data is within the instance ALREADY then you DO NOT need to
        //  pass the data in with the method
        public void CelebrateBrithday()
        {
            //this method does not take in any parameters BECAUSE the data
            //  is AREADY contained within the instance
            _Age = Math.Floor(++_Age);  //using ++Age 4.5 + 1 -> 5.5 -> .Floor(5.5) -> 5
                                        //using Age++ .Floor(4.5) -> 4 -> 4.5 + 1 -> 5.5 
        }

        //overloaded method
        //overloaded methods are methods with the same method name BUT a
        //  different list of parameters
        public void CelebrateBrithday(double newage)
        {
            
            _Age = newage;  
        }

        //Each class has a given set of methods
        //ONe such method is called ToString()
        //this method can of overridden with your OWN version
        public override string ToString()
        {
            return $"{_Name},{_Age},{_OwnerFirstName},{_OwnerLastName},{_Breed}";
        }

        //Properties

        //consider this a special type of method
        //a property is an interface to private data member within your class definition
        //a property is associated with a SINGLE piece of data
        //a property is public
        //a property MUST have an accessor (getter)
        //  the getter returns a piece of data
        //  the getter is public
        //a property MAY have a mutator (setter)
        //  the setter assigns a value to your private data member
        //  a setter may be either public (default) or private
        //  if the setter is private, it can be used from within the class
        //      it CANNOT be used by an outsider user
        //  a property without a setter is referred to as "readonly"
        //PROPERTIES DO NOT HAVE A PARAMETER LIST!!!!!!! NOT EVEN THE ( )!!!!!!
        //properties use a special key word to refer to the incoming data value
        //      that key word is -> value

        //syntax property: accesstype datatype propertyname
        //                { 
        //                    get { ... coding block ...}
        //                   [[private] set { ... coding block ...}]
        //                }

        //there are two ways to code a property
        //  a) fully-implemented property
        //  b) auto-implemented property

        //Fully-implemented property
        //a fully-implemented property will have an associated data member
        //data is transfer via the property into/out of the data member
        //the data is NOT store in the property
        //a property can have additional logic within its coding
        //  this logic is usually validation of some type

        //instead of using a getter and setter method, Name could be
        //  coded using a property

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

        public string OwnerFirstName
        {
            get { return _OwnerFirstName; }
            set 
            {
                //validation of the incoming data
                //rule: the string cannot be null, empty or content just blanks
                if (string.IsNullOrWhiteSpace(value))
                {
                    //bad data
                    //cast an error message
                    //within a class, casting error messages is done using Exceptions
                    //if this exception is throw, then the processing in the class
                    //  is terminated and the system returns to where the property
                    //  was being used.
                    //  ONE DOES NOT USE CONSOLE.WRITELINE WITHIN THE CLASS TO 
                    //      DISPLAY ERROR MESSAGES!!!!!!!!!!!!!!!!!!!!!!!!!
                    throw new Exception("You are missing the owner first name.");
                }
                //since the error would through an error and exit the proper if
                //  there was an error; the else of the conditional statement
                //  is optionally

                //else
                //{
                    _OwnerFirstName = value;
                //}
            }
        }

        public string OwnerLastName
        {
            get { return _OwnerLastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("You are missing the owner first name.");
                }
                _OwnerLastName = value;
            }
        }

        public string Breed
        {
            //accessor
            get { return _Breed; }  //retreives the current value store in the private data member
            //mutator
            set { _Breed = value; } //stores the incoming data into the private data member
        }

        //  a property without a setter is referred to as "readonly"
        public string FullName
        {
            //this property will use the first and last name to create a string
            //  that contains the owner's full name

            //Don's Rule: wherever possible within the class coding, use the property
            //              to acces your data.

            get { return OwnerLastName + "," + OwnerFirstName; }

            //NOTE: no set!!!!!!!!
        }

        //Constructors

        //  these are used during the creation of an instance (occurance) of your
        //    class during your program execution

        //a class DOES NOT need a constructor physically code for it
        //if a class DOES NOT have a physically code constructor method then
        //      the system will create the instance of your class
        //      using the system default values for your field datatype

        //HOWEVER!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //IF YOU CODE A CONSTRUCTOR PHYSCIALLY FOR YOUR CLASS, YOU ARE TOTALLY
        //      RESPONSIBLE FOR ANY AND ALL CONSTRUCTORS OF THE CLASS
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        //how many constructors can a class have? Many

        //the purpose of the constructor is to ensure that the user of the class
        //  gets an expected usable valid instance of the class

        //there is generally two types of constructors coded for a class
        //you DO NOT need to code both!!!

        //syntax for a general constructor
        //   public className( [list of parameters] ) { coding block }

        //access: public
        //NO RETURN DATATYPE
        //name: is your class name
        //parameters: are optional
        //coding block: is C# code

        //Default constructor
        //this constructor will not have any parameters
        //the assumption is the data will have either
        //  a) the system datatype defualts
        //  b) any assigned literal values to ensure property validation is meet

        public Dog()
        {
            //IF there is no code in your default constructor assigning
            //  values to your data members, the data members will be set
            //  to their system defaults

            //the default constructor is often compared to the "system" constructor

            //SINCE our properties have business rules (validation)
            //  our "default" constructor should ensure that data members within
            //  our class instance passes any validation

            //Consideration!!!!
            //does the property have any validation that would be violation
            //  by just using the system datatype defaults?

            //in this example Name, FirstName and LastName cannot be null, empty or just blanks
            //thus, a literal value was assigned that would pass the valdiation

            //Age has a validation but the system datatype default would survice

            OwnerFirstName = "Unknown";
            OwnerLastName = "Unknown";

            ////optionally
            ////if you wished, you could assign values to your other data members
            ////  even though they have acceptable defualt values
            Age = 0;
            Name = "unknown";
            Breed = "unknown";
        }

        // Greedy Constructor
        //this constructor will receive a set of values for the data within the class
        //the parameters list is a complete list of values to cover all data members
        //  within the class
        //the constructor will assign the incoming values to the appropriate
        //  data members.
        //BEST PRACTICE: ASSIGN THE INCOMING VALUES TO THE DATA MEMBERS VIA THEIR PROPERTY
        //Why: the data will be validated 

        public Dog(string name, double age, string ownerfirstname,
                        string ownerlastname, string breed)
        {
            //it is possible to include validation for your incoming data within
            //  the greed constructor 
            //you might do this IF your properties do NOT contain validation
            //                  IF you have additional validation that is not within the property
            //                  IF your setter is private (not part of this course)
            //REMEMBER that once the instance is created using the constructor ANY alternations
            //  to you data via properties or methods, should, contain validation
            //Question? Why have the same code in multiple places
            //Solution:
            //  a) create a method that could be called from anywhere in the class defintion
            //      (Modular approach)
            //  b) if you use the practice of accessing your data via the properties
            //      within the class definition, then the validation could be placed
            //      in one location: properties. (Don's Rule)

            //in this demo, Name does not have any validation in the property
            //one could do the validation in this constructor
            //one would have to do the same validation every other place in the class
            //  coding that could possible alter the Name data member
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name is missing its data");
            }
            Name = name;
            Age = age;
            OwnerFirstName = ownerfirstname;
            OwnerLastName = ownerlastname;
            Breed = breed;
        }
    }
}

