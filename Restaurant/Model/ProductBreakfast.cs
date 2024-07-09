using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class ProductBreakfast : Product
    {
        
        public ProductBreakfast(Guid id, string title, string description, string categories, decimal price) : base(id, title, description, categories, price)
        {

            this.Id = id;
            this.Title = title;
            this.Description  = description;
            this.Categories = categories;
            this.Price = price;
           

        }

       

    }
}
