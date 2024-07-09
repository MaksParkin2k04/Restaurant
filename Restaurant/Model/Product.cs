using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant.Model
{
    public class Product
    {

        /// <param name="id">Идентификатор</param>
        /// <param name="title">Название</param>
        /// <param name="description">Описание</param>
        /// <param name="categories">Категория</param>
        /// <param name="price">Цена</param>
        
        public Product(Guid id, string title, string description, string categories, decimal price)
        {

            Id = id;
            Title = title;
            Description = description;
            Categories = categories;
            Price = price;
       
          
        }
        public Guid Id { get;  set; }

        public string Title { get;  set; }
        public string Description { get;  set; }
        public string Categories { get;  set; }
        public decimal Price { get; set; }

        

        public override string ToString()
        {
            return $"{Id}: {Title} {Description} {Categories}";
        }

    }
}
