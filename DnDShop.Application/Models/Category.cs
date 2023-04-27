﻿using System;
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
    }
}
