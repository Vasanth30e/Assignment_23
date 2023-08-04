using MySharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class UserModule
    {
        public static void RegisterUser()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter User Name atleast 5 characters");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter Password atleast 8 characters");
            string password = Console.ReadLine();

            if (DataValidator.ValidateName(name) && DataValidator.ValidateUsername(userName) && DataValidator.ValidatePassword(password))
            {
                Console.WriteLine("User Registered Successfully!");
            }
            else
            {
                Console.WriteLine("Invalid Data. User Registration Failed!");
            }
        }
    }
}
