using SRP;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        StandardMessages.Welcomemessage();

        Person person = UserDataCapture.Capture();

        //checks to be sure that first and last name are valid
        if (string.IsNullOrWhiteSpace(person.FirstName))
        {
            StandardMessages.FirstNameErrorMessgae();
            person.FirstName = Console.ReadLine();
            //return;
        }
        if (string.IsNullOrWhiteSpace(person.LastName))
        {
            StandardMessages.LastNameErrormessage();
            person.LastName = Console.ReadLine();
            //return;
        }

        //Create a username for the person
        Console.WriteLine($"User name is {person.FirstName} {person.LastName}");
    }
}