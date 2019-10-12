using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBesic
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.firstName = "Md";
            person1.middleName = "Rafiqul";
            person1.lastName = "Khan";
            Change(person1);
            //person1.GetFullName();
            //person1.GetReverseName();
            Console.WriteLine(person1.GetFullName());
            Console.WriteLine(person1.GetReverseName());


            Console.WriteLine(" ");

            Person person2 = new Person();
            person2.firstName = "Erfan";
            person2.middleName = "Ullah";
            person2.lastName = "Vuian";

            Console.WriteLine(person2.GetFullName());
            Console.WriteLine(person2.GetReverseName());


            Console.WriteLine(" ");

            Person person3 = person1;
            Console.WriteLine(person3.GetFullName());
            Console.WriteLine(person3.GetReverseName());
            Console.ReadKey();
        }

        static void Change(Person person1)
        {
            person1.lastName = "Changed";

        }
    }
}
