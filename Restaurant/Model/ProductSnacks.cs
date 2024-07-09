using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class ProductSnacks : Product
    {
        public ProductSnacks(Guid id, string title, string description, string categories, decimal price) : base(id, title, description, categories, price)
        {
            Id = id;
            Title = title;
            Description = description;
            Categories = categories;
            Price = price;
        }
    }
}
