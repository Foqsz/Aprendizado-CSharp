using System;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string orderName = Console.ReadLine();
            Console.Write("Email: ");
            string orderEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime orderDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatusEx status = Enum.Parse<OrderStatusEx>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            ClientExercise order = new ClientExercise(orderName, orderEmail, orderDate);
            OrderExercise orderC = new OrderExercise();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int pQuantity = int.Parse(Console.ReadLine());

                ProductExercise Quantity = new ProductExercise(pName, pPrice, pQuantity);
                orderC.AddQuantity(Quantity);
            }

            Console.WriteLine(); 
            Console.WriteLine(orderC); 

        }
    }
}
