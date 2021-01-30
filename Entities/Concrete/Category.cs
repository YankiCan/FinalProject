using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // Çıplak Class Kalmasın 
    public class Category:IEntity // Ampulden Using Entities. Abstrac seç!
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
