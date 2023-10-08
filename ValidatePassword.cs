using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationValidation
{
    internal class ValidatePassword
    {
        public bool Validate_Password(string password)
        {
            // Password rules
            bool hasMinimumLength = password.Length >= 8;
            bool hasUpperCase = Regex.IsMatch(password, "[A-Z]");
            bool hasNumericDigit = Regex.IsMatch(password, "[0-9]");
            bool hasSpecialCharacter = Regex.IsMatch(password, "[!@#$%^&*()_+\\-=\\[\\]{};':\",.<>?]");

            return hasMinimumLength && hasUpperCase && hasNumericDigit && hasSpecialCharacter;
        }
    }
}
