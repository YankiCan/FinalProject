using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll(); // Add reference to entities kolay yolu. 
        // Bug var ise; DataAccess - add - project references - entities, sonra ampulden using System.Collections.Generic seç!
        void Add(Product product);
        void Update(Product product); 
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId); // Ürünleri kategoriye göre filtrele.
    }
}
