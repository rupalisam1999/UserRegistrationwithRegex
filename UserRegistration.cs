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
        const string LAST_NAME_PATTERN = "^[A-Z]{1}[a-z]{3,}$";

        public bool ValidateLastName(string lastName)
        {
            var result = Regex.Match(lastName, LAST_NAME_PATTERN);
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
