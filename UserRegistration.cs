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
        const string PHONE_NO_PATTERN = "^[1-9]{2}[ *][1-9]{10}$";

        public bool ValidatePhoneNo(string phoneNo)
        {
            var result = Regex.Match(phoneNo, PHONE_NO_PATTERN );
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
