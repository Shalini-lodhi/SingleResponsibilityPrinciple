# Single Responsibility Principle in Design Pattern in C#

The Single Responsibility Principle (SRP) is a design principle that suggests that each class or module should have only one responsibility. In other words, a class or module should have only one reason to change.

The SRP is an important part of the SOLID design principles and is widely used in software development, especially in object-oriented programming. The principle is important because it helps to create code that is more modular, easier to maintain, and easier to test.

## Example of SRP in C#

Consider an example of a class that manages a user account in a C# application. The class might have the following responsibilities:

-   Capture user data 
-   Validating users
-  Generate User
-  User Profile
-   Error/Welcome Messages

However, according to the SRP, each class or module should have only one responsibility. Therefore, we should break this class into smaller classes, each with its own responsibility.

One possible solution would be to create separate classes for Capture user data, validating users, Generate User, User Profile and Error/Welcome Messages.

> Branches for class seperation
>  1. [Message separation](https://github.com/Shalini-lodhi/SingleResponsibilityPrinciple/tree/1_StandardMessages_Class_Seperation/SRP) 
>  2. [User Details separation](https://github.com/Shalini-lodhi/SingleResponsibilityPrinciple/tree/2_UserDeatails_Class_Seperation/SRP)
>  3. [User Validation](https://github.com/Shalini-lodhi/SingleResponsibilityPrinciple/tree/3_UserValidation_Class_Seperation/SRP)
>  4. [Account Generator](https://github.com/Shalini-lodhi/SingleResponsibilityPrinciple/tree/4_AccountGenerator_Class_Seperation/SRP)



In this example, we have separated the responsibilities of capture user data into the `UserDataCapture` class, validating user data storage into the `UserValidator` class, generate user into `AccountGenerator` class, user profile/entity model into `Person` class, and massages into the `StandardMessages` class. This ensures that each class has only one responsibility and is easier to maintain and test.

## Conclusion

The Single Responsibility Principle is an important design principle that helps to create code that is more modular, easier to maintain, and easier to test. By ensuring that each class or module has only one responsibility, we can create more flexible and robust software systems.
