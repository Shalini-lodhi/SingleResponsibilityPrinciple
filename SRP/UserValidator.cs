using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class UserValidator
    {
        public static void Validate(Person person)
        {
            //checks to be sure that first and last name are valid
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.FirstNameErrorMessgae();
                person.FirstName = Console.ReadLine();
            }
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.LastNameErrormessage();
                person.LastName = Console.ReadLine();
            }
        }
    }
}
