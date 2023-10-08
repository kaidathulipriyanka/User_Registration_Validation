using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationValidation
{
    internal class ValidateMobileNumber
    {
        public bool Validate_MobileNumber(string mobileNumber)
        {
            string pattern = @"^[0-9]{2}\s[0-9]{10}$";
            return Regex.IsMatch(mobileNumber, pattern);
        }

    }
}
