using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBesic
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string GetFullName()
        {
            string fullName = firstName + " " + middleName + " " + lastName;

            return fullName;
        }

        public string GetReverseName()
        {
            
            char[] charArray = GetFullName().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
