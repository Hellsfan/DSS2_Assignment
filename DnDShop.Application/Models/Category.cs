using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Application.Models
{
    public class Category : IDatabaseModel
    {
        public virtual long? Id { get; set; }
        public virtual string Name { get; set; }
        public IList<Product> Products { get; set; }

        protected Category()
        {
        }

        protected Category(string name)
        {
            Name = name;
        }

        public static Category Create(string name)
        {
            return new Category(name);
        }

        public void Update(string name)
        {
            Name = name;
        }
    }
}
