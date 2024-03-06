using System.ComponentModel;
using System.Drawing;

namespace PizzaStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor= ConsoleColor.Green;
            Console.Write("          ");
            Console.BackgroundColor= ConsoleColor.White;
            Console.Write("          ");
            Console.BackgroundColor= ConsoleColor.Red;
            Console.WriteLine("          ");

            Console.BackgroundColor= ConsoleColor.Black;

            Console.WriteLine("Welcome to Big Mamma Pizzaria!");

            // Henter kundens navn
            Console.WriteLine("Please enter your name:");
            string customerName = Console.ReadLine();

            // laver kunden som et objekt
            Customer customer = new Customer(customerName);

            // pizza menuen skal vise her
            Console.WriteLine("\n Menu:");
            Console.WriteLine("============");


            foreach (var pizza in Menu)
            {
                Console.WriteLine($"{pizza.PizzaName}: ${pizza.Price}");
            }

        }
    }
}
