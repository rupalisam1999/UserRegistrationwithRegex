using System;

namespace UserRegistrationwithRegex
{
    class Program
    {
       static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("FirstName" +userRegistration.ValidateLastName("Rupali"));
            Console.WriteLine("FirstName" + userRegistration.ValidateLastName("rupali"));
        }
    }
}
