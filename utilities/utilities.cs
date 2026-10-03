using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

    }
}
