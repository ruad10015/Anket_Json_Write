using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Anket_Json
{
    public class FileManage
    {
        private const string ErrorLogFileName = "error.log";

        /// <summary>
        /// Logs an error message, including the error date, message, and stack trace, to an error log file.
        /// </summary>
        /// <param name="ex">The exception to be logged</param>
        public static void LogError(Exception ex)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(ErrorLogFileName, true))
                {
                    writer.WriteLine($"[Error Date: {DateTime.Now}]");
                    writer.WriteLine($"Message: {ex.Message}");
                    writer.WriteLine($"StackTrace: {ex.StackTrace}");
                    writer.WriteLine();
                }
            }
            catch (Exception logEx)
            {
                Console.WriteLine($"Incurred an error while writing to the error log : {logEx.Message}");
            }
        }



        /// <summary>
        /// Writes user data to a JSON file with the specified user's JSON file name.
        /// </summary>
        /// <param name="user">The user object containing data to be written</param>
        public static void WriteJson(User user)
        {
            string json = JsonConvert.SerializeObject(user);
            File.WriteAllText(user.JsonFileName, json);
        }


        /// <summary>
        /// Writes a list of user data to a JSON file named "users.json."
        /// </summary>
        /// <param name="users">The list of user objects to be written</param>
        public static void WriteJsonAllUser(List<User> users)
        {
            string json = JsonConvert.SerializeObject(users);
            File.WriteAllText("users.json", json);
        }


        /// <summary>
        /// Reads user data from a JSON file with the given file name and deserializes it into a User object.
        /// </summary>
        /// <param name="fileName">The name of the JSON file to read from</param>
        /// <returns>The deserialized User object, or null if the file does not exist</returns>
        public static User ReadJson(string fileName)
        {
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<User>(json);
            }
            return null;
        }


        /// <summary>
        /// Reads a list of user data from a JSON file named "users.json" and deserializes it into a list of User objects.
        /// </summary>
        /// <returns>The deserialized list of User objects, or null if the file does not exist</returns>
        public static List<User> ReadJsonAllUser()
        {
            if (File.Exists("users.json"))
            {
                string json = File.ReadAllText("users.json");
                return JsonConvert.DeserializeObject<List<User>>(json);
            }
            return null;
        }
    }
}
