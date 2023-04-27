using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDShop.Application.Models
{
    public class ShoppingCart : IDatabaseModel
    {
        public virtual long? Id { get; set; }
        public virtual double? TotalPrice { get; set; }
        public virtual int TotalItems { get; set; }
        public virtual IList<Product>? Products { get; set; }
    }
}
