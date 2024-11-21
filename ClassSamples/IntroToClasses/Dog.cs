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
            get { return _Name; }  //retreives the current value store in the private data member
            set { _Name = value; } //stores the incoming data into the private data member
        }
    }
}
