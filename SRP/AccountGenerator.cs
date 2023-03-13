using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class AccountGenerator
    { 
        public static void CreateAccount(Person person)
        {
            //Create a username for the person
            Console.WriteLine($"User name is {person.FirstName} {person.LastName}");
        }
    }
}
