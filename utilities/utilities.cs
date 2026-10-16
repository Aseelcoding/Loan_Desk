using LoanDesk.Models;
using System.Linq;
using System.Text.RegularExpressions;

namespace utilities
{
    public class utilities
    {
        //to check if the string contain a number or not
        public static bool IsDigit(string Password)
        {
            return Regex.IsMatch(Password, @"\d");
        }

        public static bool IsStringContainUpper(string Password)
        {
            return Regex.IsMatch(Password, @"[A-Z]");
        }

        public static bool IsStringContainSymbol(string Password)
        {
            return Regex.IsMatch(Password, @"[\p{P}\p{S}]");
        }

        public static string ClearFilterString(string input)
        {
            // Remove all special characters from the string
            string output = Regex.Replace(input, @"[^\w\s]", "");
            return output;
        }

        public static void IsValidPhoneNumber(string PhoneNumber)
        {
            if (!Regex.Match(PhoneNumber, @"^\+[0-9]{9,15}$").Success)
                throw new Exceptions.ValidationException("Phone number is not valid");
        }

        public static void ValidateName(string Name)
        {
            if (!Regex.Match(Name, @"^[A-Za-z]+(?: [A-Za-z]+)*$").Success)
                throw new Exceptions.ValidationException("Name is not vaild");
        }

        public static void ValidateLength(string Text, string PropertyName, int Min, int Max)
        {
            if ((Text.Length < Min || Text.Length > Max))
            {
                throw new Exceptions.ValidationException($"{PropertyName} must be between {Min} and {Max}");
            }
        }

        public static void IsEmptyOrNullOrWhiteSpace(string Text, string PropertyName)
        {
            if (string.IsNullOrEmpty(Text) || string.IsNullOrWhiteSpace(Text))
                throw new Exceptions.ValidationException($"{PropertyName} must not be Empty or start with white space");
        }

        public static string SanitizePhoneNumber(string Phone)
        {
            string phoneNumber = Phone.Trim();
            bool hasPlus = phoneNumber.StartsWith("+");

            phoneNumber = new string(phoneNumber.Where(char.IsDigit).ToArray());

            if (hasPlus)
                phoneNumber = "+" + phoneNumber;

            return phoneNumber;
        }
    }
}