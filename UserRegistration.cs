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
        const string EMAIL_PATTERN = "^[a-z]{2,}[.]{1}[a-z]{3,}[@][a-z]{2,}[.]{1}[a-z]{2,}[.]{1}[a-z]{2,}$";

        public bool ValidateEmail(string email)
        {
            var result = Regex.Match(email, EMAIL_PATTERN );
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
