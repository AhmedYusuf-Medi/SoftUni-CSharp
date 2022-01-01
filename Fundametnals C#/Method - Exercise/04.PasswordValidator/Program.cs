using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool Validate = ValideLenght(password) &&
                ValideLettersAndDigits(password)&& ValidateDigits(password);
            if (Validate)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!ValideLenght(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!ValideLettersAndDigits(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!ValidateDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        private static bool ValidateDigits(string password)
        {
            int count = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            return false;
        }

        private static bool ValideLettersAndDigits(string password)
        {
            foreach (var c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ValideLenght(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
