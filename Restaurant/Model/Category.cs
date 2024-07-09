using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Model
{
    public class Category
    {
        ///<param name="id">Идентификатор</param>
        ///<param name="title">Название</param>
        
        public Category(Guid id, string title) {
            Id = id;
            Title = title;
        
        }
        public Guid Id { get; private set; }
        public string Title { get; private set; }
    }
}
