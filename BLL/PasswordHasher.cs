using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class PasswordHasher
    {
        private const int SaltSize = 16;  // 128-bit
    

    
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[SaltSize];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }

            return Convert.ToBase64String(saltBytes);
        }


      
        public static string HashPassword(string password, string saltBase64)
        {
        
            string combinedString = password + saltBase64;
            byte[] bytes = Encoding.UTF8.GetBytes(combinedString);

          
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(bytes);

             
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

       
        public static bool VerifyPassword(string enteredPassword, string storedSalt, string storedHash)
        {
            string computedHash = HashPassword(enteredPassword, storedSalt);

           
            return string.Equals(computedHash, storedHash, StringComparison.OrdinalIgnoreCase);
        }
    }
}
