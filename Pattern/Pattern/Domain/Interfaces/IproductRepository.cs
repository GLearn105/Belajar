using Pattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Domain.Interfaces
{
    interface IproductRepository
    {
        void Add(Product product);
        List<Product> GetAll();
    }
}