using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    public class DataValidator
    {
        public static bool ValidateName(string name)
        {
            return !string.IsNullOrEmpty(name);
        }

        public static bool ValidateUsername(string username)
        {
            return !string.IsNullOrEmpty(username) && username.Length >= 5;
        }

        public static bool ValidatePassword(string password)
        {
            return !string.IsNullOrEmpty(password) && password.Length >= 8;
        }
    }
}
