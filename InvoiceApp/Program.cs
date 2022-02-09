using System;

namespace InvoiceApp
{
    class Program
    {
        static void Main()
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

            Invoice Invoice = new Invoice(partNumber, description, quantity, price);

            Console.WriteLine(" ");
            Console.WriteLine("Invoice");
            Console.WriteLine($"Part Number: {Invoice._partNumber}");
            Console.WriteLine($"Part Description: {Invoice._description}");
            Console.WriteLine($"Quantity: {Invoice.Quantity}");
            Console.WriteLine($"Price: {Invoice.Price:C}");
            Console.WriteLine($"Total: {Invoice.GetInvoiceAmount():C}");

            Console.ReadLine();
        }


    }
}
