using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public  class Invoice
    {
        public int PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }

    public  static class Repository
    {
       public  static IQueryable<Invoice> invoices = new List<Invoice>
        {
            new Invoice{PartNumber = 87, PartDescription="Electrinic Sander", Price=57.98M, Quantity =7},
              new Invoice{PartNumber = 24, PartDescription="Power Saw", Price=99.99M, Quantity =18},
                new Invoice{PartNumber = 7, PartDescription="Sledge Hamer", Price=21.50M, Quantity =11},
                  new Invoice{PartNumber = 77, PartDescription="Hammer", Price=11.99M, Quantity =76},
                    new Invoice{PartNumber = 39, PartDescription="Lawn Mower", Price=79.50M, Quantity =3},
                      new Invoice{PartNumber = 68, PartDescription="Screw Driver", Price=6.99M, Quantity =106},
                        new Invoice{PartNumber = 56, PartDescription="Jig Saw", Price=11.00M, Quantity =21},
        }.AsQueryable();

      
    }
}
