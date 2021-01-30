using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity // public bu class a diğer katmanlarda ulabilsin demek. 
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string MyProperty { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

// Data access ürünü ekleyecek
// Business ürünü kontrol edecek
// Console ürünü gösterecek
