using System;

namespace UserRegistrationwithRegex
{
    class Program
    {
       static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Password" +userRegistration.ValidatePassword("RupaliSs"));
            Console.WriteLine("Password" + userRegistration.ValidatePassword("rupali775475"));
        }
    }
}
