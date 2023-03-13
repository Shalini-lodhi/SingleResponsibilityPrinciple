using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class UserDataCapture
    {
        public static Person Capture()
        {
            //Ask for user informatin
            Person user = new Person();

            Console.WriteLine("Your first name: ");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("Your Last Name: ");
            user.LastName = Console.ReadLine();

            return user;
        }
    }
}
