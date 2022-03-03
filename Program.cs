using System;

namespace UserRegistrationwithRegex
{
    class Program
    {
       static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Email" +userRegistration.ValidateEmail("rupali.xyz@bl.co.in"));
            Console.WriteLine("Email" + userRegistration.ValidateEmail("rupali.@bl.co.in"));
        }
    }
}
