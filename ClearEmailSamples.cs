using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationValidation
{
    internal class ClearEmailSamples
    {
        public bool ClearEmail_Samples(string emailSamples)
        {
            // Assuming emailSamples is a comma-separated list of emails
            string[] emails = emailSamples.Split(',');
            bool allValid = true;

            foreach (string email in emails)
            {
                if (!ValidateEmail(email.Trim()))
                {
                    allValid = false;
                    Console.WriteLine($"Invalid email: {email}");
                }
            }

            return allValid;
        }

        private bool ValidateEmail(string v)
        {
            throw new NotImplementedException();
        }
    }
}
