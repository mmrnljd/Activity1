using System;
using System.Collections.Generic;

namespace OrderingSystem
{
    class Program
    {
        static List<(string itemName, double price)> orders = new List<(string, double)>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add New Item");
                Console.WriteLine("2. View Order Summary");
                Console.WriteLine("3. Place Order");
                Console.WriteLine("4. Total Price of Order");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewItem();
                        break;
                    case "2":
                        ViewOrderSummary();
                        break;
                    case "3":
                        PlaceOrder();
                        break;
                    case "4":
                        TotalPriceOfOrder();
                        break;
                    case "5":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddNewItem()
        {
            Console.Write("Enter item name: ");
            string itemName = Console.ReadLine();

            Console.Write("Enter item price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            orders.Add((itemName, price));
            Console.WriteLine("Item added successfully!");
        }

        static void ViewOrderSummary()
        {
            if (orders.Count > 0)
            {
                Console.WriteLine("Order Summary:");
                for (int i = 0; i < orders.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {orders[i].itemName} - ${orders[i].price}");
                }
            }
            else
            {
                Console.WriteLine("No items in the order.");
            }
        }

        static void PlaceOrder()
        {
            if (orders.Count > 0)
            {
                Console.WriteLine("Order placed successfully!");
                orders.Clear();
            }
            else
            {
                Console.WriteLine("No items to place order.");
            }
        }

        static void TotalPriceOfOrder()
        {
            double totalPrice = 0;
            foreach (var order in orders)
            {
                totalPrice += order.price;
            }
            Console.WriteLine($"Total Price of Order: ${totalPrice}");
        }
    }
}
