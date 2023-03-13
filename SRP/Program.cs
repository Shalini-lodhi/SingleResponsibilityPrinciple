using SRP;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        StandardMessages.Welcomemessage();

        //Ask for user informatin
        Person person = new Person();

        Console.WriteLine("Your first name: ");
        person.FirstName = Console.ReadLine();

        Console.WriteLine("Your Last Name: ");
        person.LastName = Console.ReadLine();

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