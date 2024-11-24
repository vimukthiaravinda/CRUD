using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class User
    {
        private int user_id;
        private string first_name;
        private string last_name;
        private string email;
        private string password;
        private string address;
        private string country;
        private string gender;

        public string First_Name
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public int User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
    }
}
