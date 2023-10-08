using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationValidation
{
    internal class ValidateEmail
    {
        public bool Validate_Email(string email)
        {
            string pattern = @"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z]+\.[a-zA-Z]{2,4}(\.[a-zA-Z]{2,4})*$";
            return Regex.IsMatch(email, pattern);
        }

    }
}
