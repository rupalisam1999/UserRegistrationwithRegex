using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationwithRegex
{
    class UserRegistration
    {
        const string PASSWORD_RULE1_PATTERN = "^[A-Za-z]{8,}$";

        public bool ValidatePassword(string password)
        {
            var result = Regex.Match(password, PASSWORD_RULE1_PATTERN);
            if (result.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
    
}
