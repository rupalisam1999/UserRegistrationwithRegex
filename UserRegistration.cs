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
        const string PASSWORD_RULE2_PATTERN = "^[A-Z]{1}[a-z]{7,}$";

        public bool ValidatePassword(string password)
        {
            var result = Regex.Match(password, PASSWORD_RULE2_PATTERN);
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
