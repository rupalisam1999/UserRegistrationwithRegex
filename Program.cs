using System;

namespace UserRegistrationwithRegex
{
    class Program
    {
       static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("PhoneNo" +userRegistration.ValidatePhoneNo("91 9112674814"));
            Console.WriteLine("PhoneNo" + userRegistration.ValidatePhoneNo("919322775475"));
        }
    }
}
