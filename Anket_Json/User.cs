using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket_Json
{
    public class User
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { if (Validation.CheckName(value)) name = value; }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { if (Validation.CheckSurname(value)) surname = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { if (Validation.CheckEmail(value)) email = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { if (Validation.CheckPhoneNumber(value)) phone = value; }
        }

        public DateTime BirthDate { get; set; } = DateTime.Now;

        private string jsonFileName = "default.json";

        public string JsonFileName
        {
            get { return jsonFileName; }
            set { if (Validation.CheckJsonFormat(value)) jsonFileName = value; }
        }

    }
}
