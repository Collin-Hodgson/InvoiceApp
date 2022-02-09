using System;

namespace InvoiceApp
{
    class Program
    {
        static void Main()
        {
            Invoice Invoice = new Invoice();
            

            Console.Write("Please enter the part number:");
            Invoice._partNumber = Console.ReadLine();

            Console.Write("Please enter the part description:");
            Invoice._description = Console.ReadLine();

            Console.Write("Please enter the quantity of items:");
            Invoice._quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the price of the item:");
            Invoice._price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Invoice");
            Console.WriteLine($"Part Number: ");
            Console.WriteLine("Part Description: ");
            Console.WriteLine("Quantity of item: ");
            Console.WriteLine("Price of item: ");
            Console.WriteLine(Invoice.GetInvoiceAmount());
        }


    }
}
