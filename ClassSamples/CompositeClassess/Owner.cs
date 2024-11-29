using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeClassess
{
    public class Owner
    {
        //auto implemented property
        // has NO additional logic within the property
        // Simply holds a data value
        // has NO associated private data member
        // the system manages the internal saving and access
        //      to the data value
        // access to the data value is ONLY via the property

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public Owner(string firstname, string lastname, string phone)
        {
            //if you are using auto-implemented properties AND
            //  still need to do validation THEN the validation
            //  needs to be coded elsewhere in your code
            if (string.IsNullOrWhiteSpace(firstname))
                throw new Exception("Missing value for first name.");

            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"{FirstName},{LastName},{Phone}";
        }
        public string FullName
        {
            //this property will use the first and last name to create a string
            //  that contains the owner's full name

            //Don's Rule: wherever possible within the class coding, use the property
            //              to acces your data.

            get { return LastName + "," + FirstName; }

            //NOTE: no set!!!!!!!!
        }
    }
}
