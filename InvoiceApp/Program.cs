using System;

namespace InvoiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string partNumber;
            string description;
            int quantity;
            decimal price;

            Console.Write("Please enter the part number:");
            partNumber = Console.ReadLine();

            Console.Write("Please enter the part description:");
            description = Console.ReadLine();

            Console.Write("Please enter the quantity of items:");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the price of the item:");
            price = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
