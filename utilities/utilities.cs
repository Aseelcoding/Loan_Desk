using LoanDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace utilities
{
    public class utilities
    {

        //to check if the string contain a number or not 
        static public bool IsDigit(string Password)
        {
            return Regex.IsMatch(Password, @"\d");

        }
        static public bool IsStringContainUpper(string Password)
        {
            return Regex.IsMatch(Password, @"[A-Z]");

        }
        static public bool IsStringContainSymbol(string Password)
        {
            return Regex.IsMatch(Password, @"[\p{P}\p{S}]");

        }
        static public string ClearFilterString(string input)
        {
            // Remove all special characters from the string
            string output = Regex.Replace(input, @"[^\w\s]", "");
            return output;
        }
        static public void IsValidPhoneNumber(string PhoneNumber)
        {
            if (!Regex.Match(PhoneNumber, @"^\+[0-9]{9,15}$").Success)
                throw new Exceptions.ValidationException("Phone number is not valid");

        }
        static public bool IsValidName(string Name)
        {
            return Regex.Match(Name, @"^[A-Za-z]+(?: [A-Za-z]+)*$").Success;
        }
        static public void ValidateLength(string Text, string PropertyName, int Min, int Max)
        {
            if ((Text.Length < Min || Text.Length > Max))
            {
                throw new Exceptions.ValidationException($"{PropertyName} must be between {Min} and {Max}");
            }

        }
        static public void IsEmptyOrNullOrWhiteSpace(string Text, string PropertyName)
        {
            if (string.IsNullOrEmpty(Text)||string.IsNullOrWhiteSpace(Text))
                throw new Exceptions.ValidationException($"{PropertyName} must not be Empty or start with white space");
        }
        static public string SanitizePhoneNumber(string Phone) 
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
