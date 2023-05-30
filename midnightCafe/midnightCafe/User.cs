using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midnightCafe
{
    internal class User
    {
        private string firstName = "";
        private string lastName = "";
        private string email = "";
        private string password = "";
        private string birthDate = "";
        private string gender = "";

        public string FIRSTNAME { get { return firstName; } set { firstName = value; } }

        public string LASTNAME { get { return lastName; } set { lastName = value; } }
        
        public string EMAIL { get { return email;  } set { email = value; } }

        public string PASSWORD { get { return password; } set { password = value; } }

        public string BIRTHDATE { get { return birthDate; } set { birthDate = value; } }

        public string GENDER { get { return gender; } set { gender = value; } }
    }
}
