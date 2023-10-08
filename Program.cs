namespace UserRegistrationValidation
{
    internal class Program  
    {
       
        static void Main(string[] args)
        {
            ValidateFirstName first = new ValidateFirstName();

            // Example usage
            Console.WriteLine("Enter a FirstName");

            string firstName = Console.ReadLine(); ;
            if (first.Validate_FirstName(firstName))
            {
                Console.WriteLine("Validate: " + firstName);
            }
            else
            {
                Console.WriteLine("Invalid: " + firstName);
            }
            Console.WriteLine();

            //

            ValidateLastName validateLastName = new ValidateLastName();
            Console.WriteLine("Enter a LastName");
            string lastName = Console.ReadLine();
            if (validateLastName.Validate_LastName(lastName))
            {
                Console.WriteLine("Validate: " + lastName);

            }
            else
            {
                Console.WriteLine("Invalid: " + lastName);
            }
            Console.WriteLine();

            //

            ValidateEmail validateEmail = new ValidateEmail();
            Console.WriteLine("Enter a Email");
            string email = Console.ReadLine();
            if (validateEmail.Validate_Email(email))
            {
                Console.WriteLine("Validate: " + email);

            }
            else
            {
                Console.WriteLine("Invalidate: " + email);
            }
            Console.WriteLine();

            //

            ValidateMobileNumber validateMobileNumber = new ValidateMobileNumber();
            Console.WriteLine("Enter a Mobile Number");
            string mobileNumber = Console.ReadLine();
            if (validateMobileNumber.Validate_MobileNumber(mobileNumber))
            {
                Console.WriteLine("Validate: " + mobileNumber);
            }
            else
            {
                Console.WriteLine("Invalidate: " + mobileNumber);
            }
            Console.WriteLine();

            //

            ValidatePassword validatePassword = new ValidatePassword();
            Console.WriteLine("Enter a Password");
            string password = Console.ReadLine();
            if (validatePassword.Validate_Password(password))
            {
                Console.WriteLine("Validate: " + password);
            }
            else
            {
                Console.WriteLine("Invalid: " + password);
            }
            Console.WriteLine();

            //
            ClearEmailSamples clearEmail = new ClearEmailSamples();
            string emailSamples = Console.ReadLine();
            if (clearEmail.ClearEmail_Samples(emailSamples))
            {
                Console.WriteLine("Valid: " + clearEmail);
            }
            else
            {
                Console.WriteLine("Invalid: " + clearEmail);
            }
        }
    }
}
   
