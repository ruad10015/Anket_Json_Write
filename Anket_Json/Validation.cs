using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Anket_Json
{
    public static class Validation
    {
        /// <summary>
        /// Checks if a given name contains only letters and has a minimum length of 3 characters.
        /// </summary>
        /// <param name="name">The name to be validated</param>
        /// <returns>True if the name is valid, otherwise throws an exception</returns>
        public static bool CheckName(string name)
        {
            int ex, ascNum; bool isLetter = true;
            if (name.Length >= 3 && !int.TryParse(name, out ex))
            {
                foreach (char c in name.ToLower().Trim())
                {
                    ascNum = (int)c;
                    if (!(ascNum >= 97 && ascNum <= 122)) { isLetter = false; break; }
                }
                if (isLetter) return true;
            }
            throw new ArgumentException("The name can only contain letters.");
        }


        /// <summary>
        /// Checks if a given surname contains only letters and has a minimum length of 3 characters.
        /// </summary>
        /// <param name="surname">The surname to be validated</param>
        /// <returns>True if the surname is valid, otherwise throws an exception</returns>
        public static bool CheckSurname(string surname)
        {
            int ex, ascNum; bool isLetter = true;
            if (surname.Length >= 3 && !int.TryParse(surname, out ex))
            {
                foreach (char c in surname.ToLower().Trim())
                {
                    ascNum = (int)c;
                    if (!(ascNum >= 97 && ascNum <= 122)) { isLetter = false; break; }
                }
                if (isLetter) return true;
            }
            throw new ArgumentException("The surname can only contain letters.");
        }


        /// <summary>
        /// Validates an email address against a regular expression pattern.
        /// </summary>
        /// <param name="email">The email address to be validated</param>
        /// <returns>True if the email is in a valid format, otherwise throws an exception</returns>
        public static bool CheckEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);

            if (regex.IsMatch(email)) return true;

            throw new ArgumentException("Invalid email format.");
        }


        /// <summary>
        /// Checks if a phone number is exactly 12 digits long and contains only digits.
        /// </summary>
        /// <param name="phoneNumber">The phone number to be validated</param>
        /// <returns>True if the phone number is valid, otherwise throws an exception</returns>
        public static bool CheckPhoneNumber(string phoneNumber)
        {
            
            if (phoneNumber.Length == 12)
            {
                foreach (char c in phoneNumber)
                {
                    if (!char.IsDigit(c))
                    {
                        throw new ArgumentException("Phone number can only contain digits.");
                    }
                }

                return true; 
            }
            throw new ArgumentException("Phone number must be exactly 12 digits long.");
        }


        /// <summary>
        /// Checks if a file name has a .json extension (case-insensitive).
        /// </summary>
        /// <param name="fileName">The file name to be validated</param>
        /// <returns>True if the file name is valid, otherwise throws an exception</returns>
        public static bool CheckJsonFormat(string fileName)
        {
            if (fileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            throw new ArgumentException("File name must have a .json extension.");
        }


        /// <summary>
        /// Checks if a DateTime object is not equal to the current date and time.
        /// </summary>
        /// <param name="datetime">The DateTime object to be validated</param>
        /// <returns>True if the DateTime object is valid, otherwise throws an exception</returns>
        public static bool CheckDateTime(DateTime datetime) {
            if (datetime != DateTime.Now) return true;
            throw new ArgumentException("Birth Date not initialized...");
        }


        /// <summary>
        /// Checks if a text string is not empty.
        /// </summary>
        /// <param name="text">The text string to be validated</param>
        /// <returns>True if the text is not empty, otherwise throws an exception</returns>
        public static bool isFilled(string text)
        {
            if (text.Length != 0) return true;
            throw new ArgumentException("Data is empty..");
        }
    }
}
