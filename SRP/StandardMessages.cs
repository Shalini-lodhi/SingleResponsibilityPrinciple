using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to SRP!");
        }
        public static void FirstNameErrorMessgae()
        {
            Console.WriteLine("Invalid First Name. \n Write First Name again: ");
        }
        public static void LastNameErrormessage() 
        { 
            Console.WriteLine("Invalid Last Name. \n Write Last Name again: "); 
        }
    }
}
