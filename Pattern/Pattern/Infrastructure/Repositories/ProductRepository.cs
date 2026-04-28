using Pattern.Application.Repositories;
using Pattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Infrastructure
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
