using SRP;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        StandardMessages.WelcomeMessage();

        Person person = UserDataCapture.Capture();

        UserValidator.Validate(person);
       
        //Create a username for the person
        Console.WriteLine($"User name is {person.FirstName} {person.LastName}");
    }
}