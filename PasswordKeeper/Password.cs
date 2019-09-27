using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordKeeper
{
    class Password
    {
        private string passwordName;
        private string userName;
        private string password;
        private string URL;
        private string notes;

        public string displayName { get { return passwordName; } }

        public Password()
        {
            passwordName = "";
            userName = "";
            password = "";
        }

        public string getWebName()
        {
            return passwordName;
        }

        public string getUserName()
        {
            return userName;
        }

        public string getNotes()
        {
            return notes;
        }

        public string getURL()
        {
            return URL;
        }

        public string getPassword()
        {
            return password;
        }

        public Password(string name, string user, string pass, string url, string note)
        {
            passwordName = name;
            userName = user;
            password = pass;
            URL = url;
            notes = note;
        }

        public Password(string name, string user, string pass, string note)
        {
            passwordName = name;
            userName = user;
            password = pass;
            notes = note;
    }
    }
}

