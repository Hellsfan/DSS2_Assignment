using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Application.Models
{
    public class Product : IDatabaseModel
    {
        public virtual long? Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Price { get; set; }
        public virtual string Description { get; set; }
        public virtual int Quantity { get; set; }
        public virtual long? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual string FileId { get; set; }
    }
}
