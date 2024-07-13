using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_System
{
    class Menu
    {
        static Product[] products = new Product[100];
        static int productCount = 0;

        public static void ProductMain()
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Products");
                Console.WriteLine("2. Add Review to a Product");
                Console.WriteLine("3. Display Products and Reviews");
                Console.WriteLine("4. Display Most Reviewed Products");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        AddReview();
                        break;
                    case "3":
                        DisplayProducts();
                        break;
                    case "4":
                        DisplayMostReviewedProducts();
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter again.");
                        break;
                }
            }
        }
        public static void AddProduct()
        {
            Console.Write("Enter the name of the product: ");
            string Jorocel = Console.ReadLine();
            if (productCount < 100)
            {
                products[productCount] = new Product(Jorocel);
                productCount++;
                Console.WriteLine("Product added successfully!");
            }
            else
            {
                Console.WriteLine("Product limit reached. Cannot add more products.");
            }
        }
        public static void AddReview()
        {
            if (productCount == 0)
            {
                Console.WriteLine("No products added yet. Please add a product first.");
                return;
            }

            Console.WriteLine("Select a product to add a review:");
            for (int i = 0; i < productCount; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Joro}");
            }

            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int productIndex) && productIndex >= 1 && productIndex <= productCount)
            {
                Console.Write("Enter your review: ");
                string review = Console.ReadLine();
                products[productIndex - 1].AddReview(review);
                Console.WriteLine("Review added successfully!");
            }
            else
            {
                Console.WriteLine("Invalid product choice.");
            }
        }

        public static void DisplayProducts()
        {
            if (productCount == 0)
            {
                Console.WriteLine("No products added yet.");
                return;
            }

            Console.WriteLine("\nProducts and Reviews:");
            for (int i = 0; i < productCount; i++)
            {
                Console.WriteLine($"Product: {products[i].Joro}");
                if (products[i].ReviewCount > 0)
                {
                    Console.WriteLine("Reviews:");
                    for (int j = 0; j < products[i].ReviewCount; j++)
                    {
                        Console.WriteLine($"- {products[i].Reviews[j]}");
                    }
                }
                else
                {
                    Console.WriteLine("- No reviews yet.");
                }
                Console.WriteLine();
            }
        }
        public static void DisplayMostReviewedProducts()
        {
            if (productCount == 0)
            {
                Console.WriteLine("No products added yet.");
                return;
            }

            for (int i = 0; i < productCount - 1; i++)
            {
                for (int j = i + 1; j < productCount; j++)
                {
                    if (products[j].ReviewCount > products[i].ReviewCount)
                    {
                        Product temp = products[i];
                        products[i] = products[j];
                        products[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nMost Reviewed Products:");
            for (int i = 0; i < productCount && i < 3; i++) // Display top 3 most reviewed products
            {
                Console.WriteLine($"Product: {products[i].Joro} | Number of Reviews: {products[i].ReviewCount}");
            }
        }
    }
}
