using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;

namespace Product_Review_System
{
    class Product
    {
        public string Joro { get; set; }
        public string[] Reviews { get; set; }
        public int ReviewCount { get; set; }

        public Product(string jorocel)
        {
            Joro = jorocel;
            Reviews = new string[100];
            ReviewCount = 0;
        }

        public void AddReview(string review)
        {
            if (ReviewCount < 100)
            {
                Reviews[ReviewCount] = review;
                ReviewCount++;
            }
            else
            {
                Console.WriteLine("Review limit reached for this product.");
            }
        }
    }
}