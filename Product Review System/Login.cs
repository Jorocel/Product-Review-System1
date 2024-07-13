using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;

namespace Product_Review_System
{
    class Login
    {
        static string[] Usernames = { "user1", "user2" };
        static string[] Passwords = { "password1", "password2" };
        public static bool UserLogin()
            {
                bool LoggedIn = false;

                while (!LoggedIn)
                {
                    Console.Write("Username: ");
                    string userName = Console.ReadLine();
                    Console.Write("Password: ");
                    string passWord = Console.ReadLine();

                    LoggedIn = Authenticate(userName, passWord);

                    if (!LoggedIn)
                    {
                        Console.WriteLine("Invalid credentials. Please try again!");
                    }
                }
                Console.WriteLine("Login succesful!");
                return LoggedIn;
            }
        public static bool Authenticate(string username, string password)
        {
            for (int i = 0; i < Usernames.Length; i++)
            {
                if (Usernames[i] == username && Passwords[i] == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
    }
