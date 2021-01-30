using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; // class içinde ama metotlar dışında tanımlananlar global değişkenlerdir, _ ile birlikte verilir. 
        public InMemoryProductDal() // cons tabtab - Constructor; bellekte ref alınca çalışacak bloktur
        {
            // Oracle, Sql Server, Postgres, MongoDb
            _products = new List<Product> 
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LINQ - Language Integrated Query
            // Lambda - p=>
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId); // Ürünleri tek tek dolaşmaya yarar - foreach yerine çalışır.
            _products.Remove(productToDelete); 
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList(); // İçinde koşula uyan bütün elemanları yeni bir liste haline getirip onu döndürür
        }

        public void Update(Product product)
        {
            // Gönderilenn ürün Id sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
