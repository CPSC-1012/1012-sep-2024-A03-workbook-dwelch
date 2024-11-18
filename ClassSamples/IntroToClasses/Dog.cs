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
        private double _Age;

        //Behaviours (aka methods)

        //mutator (setter)
        public void SetName(string name)
        {
            _Name = name;
        }

        //accessor (getter)
        public string GetName()
        {
            return _Name;
        }
    }
}
