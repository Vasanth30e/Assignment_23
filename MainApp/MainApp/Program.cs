using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("User Registeration");
                UserModule.RegisterUser();

                Console.WriteLine("Do you wish to continue or if yes press 'y' or any other key");
                string choice = Console.ReadLine();
                if(choice == "y")
                {
                    Console.WriteLine("Registration continues");
                }
                else
                {
                    break;
                }

                Console.ReadKey();
            }            
        }
    }
}
