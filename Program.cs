using System;

namespace UserRegistrationwithRegex
{
    class Program
    {
       static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Password" +userRegistration.ValidatePassword("Rupaliss"));
            Console.WriteLine("Password" + userRegistration.ValidatePassword("rupali775475"));

            Console.WriteLine("Password" + userRegistration.ValidatePassword("Rupaliss"));

            Console.WriteLine("Password" + userRegistration.ValidatePasswordRule3("Rupali123"));
            Console.WriteLine("Password" + userRegistration.ValidatePasswordRule3("rupalis123"));
        }
    }
}
