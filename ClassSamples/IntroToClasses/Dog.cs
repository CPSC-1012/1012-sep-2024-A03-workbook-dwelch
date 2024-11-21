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
    }
}
