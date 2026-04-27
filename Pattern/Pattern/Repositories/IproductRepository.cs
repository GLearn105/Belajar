using Pattern.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Repositories
{
    interface IproductRepository
    {
        void Add(Product product);
        List<Product> GetAll();
    }
}