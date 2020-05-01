using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {

            var filtered1 = from value in Repository.invoices
                           let InvoiceTotal = value.Quantity * value.Price
                           orderby InvoiceTotal ascending
                           select new { value.PartDescription, InvoiceTotal };

            var filtered2 = (from value in Repository.invoices
                            where value.Quantity == Repository.invoices.Max(i=>i.Quantity)
                            select  value).First();

            var filtered3 = (from value in Repository.invoices
                            let Avg = Repository.invoices.Select(i => i.Price).Average()
                            select new { Avg }).First();
            Console.WriteLine($"\tPartDescription \t InvoiceTotal");
            foreach (var item in filtered1)
            {
             
                Console.WriteLine("{0,20}{1,20}",item.PartDescription,item.InvoiceTotal);
            }

            Console.WriteLine($"highest quantity:{filtered2.PartDescription}");
            Console.WriteLine($"Average price of the parts:{decimal.Round(filtered3.Avg,2)}");
            
           
        }
    }
}
