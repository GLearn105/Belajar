using Pattern.Domain.Entities;
using Pattern.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Infrastructure.Repositories
{
    class ProductRepository : IproductRepository
    {
        private List<Product> products = new List<Product>();
        private int nextId = 1;
        public void Add(Product product)
        {
            product.Id = nextId++;
            products.Add(product);
        }
        public List<Product> GetAll()
        {
            return products;
        }
    }
}
