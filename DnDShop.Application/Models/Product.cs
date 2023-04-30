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
        public virtual long? ShoppingCartId { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
        public virtual string FileId { get; set; }

        protected Product()
        {

        }

        protected Product(
            string name,
            string description,
            long? categoryId,
            int quantity,
            int price)
        {
            if (categoryId is null
                || categoryId < default(long))
            {
                throw new ArgumentNullException(
                    nameof(categoryId),
                    "Product category can't be null or negative");
            }

            CategoryId = categoryId;

            Update(
                name: name,
                description: description,
                quantity: quantity,
                price : price);
        }

        public static Product Create(string name,
           string description,
           long? categoryId,
           int quantity,
           int price)
        {
            return new Product(
               name: name,
               description: description,
               categoryId: categoryId,
               quantity: quantity,
               price: price);
        }

        public void Update(
            string name,
            string description,
            int quantity,
            int price)
        {
            if (name == null)
            {
                throw new ArgumentNullException(
                    nameof(name),
                    "Product name can't be null");
            }

            if (description == null
                || description.Length > 256)
            {
                throw new ArgumentNullException(
                    nameof(description),
                    "Invalid description. " +
                    "Description can't be null or more then 256 chars");
            }

            if (quantity < default(int))
            {
                throw new ArgumentNullException(
                    nameof(quantity),
                    "Invalid quantity. " +
                    "Quantity should be a positive number or zero");
            }

            Name = name;
            Description = description;
            Quantity = quantity;
            Price = price;
        }
    }
}
