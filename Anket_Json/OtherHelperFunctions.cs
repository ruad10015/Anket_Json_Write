using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket_Json
{
    public static class OtherHelperFunctions
    {
        /// <summary>
        /// Creates and returns a new User object with the specified name, surname, email, phone number, and birthdate.
        /// </summary>
        /// <param name="name">The user's name</param>
        /// <param name="surname">The user's surname</param>
        /// <param name="email">The user's email address</param>
        /// <param name="phone">The user's phone number</param>
        /// <param name="birthdate">The user's birthdate</param>
        /// <returns>A new User object with the provided information</returns>
        public static User GetUser(string name,string surname , string email,string phone,DateTime birthdate)
        {
           return new User { Name = name, Surname = surname, Email = email, Phone = phone, BirthDate = birthdate };
        }
    }
}
