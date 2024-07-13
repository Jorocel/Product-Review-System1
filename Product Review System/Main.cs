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
    class Program
    {
        public static void Main(string[] args)
        {
            ProductMain();  
        }

        public static void ProductMain()
        {
            ProductWelcome.AvocajoLogo();
            ProductWelcome.Welcome();
            bool LoggedIn = Login.UserLogin();
            Menu.ProductMain();
        }
    }

}
