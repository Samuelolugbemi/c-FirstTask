using System;

namespace InvoiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("something", "someone", 1, 4000M);

            Console.Write("Please enter quantity: ");
            int quant = Convert.ToInt32(Console.ReadLine());
            invoice.SetQuantity(quant);

            Console.Write("Please enter price per item: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            invoice.SetPricePerItem(price);

            invoice.GetInvoiceAmount();

        }
    }
}
