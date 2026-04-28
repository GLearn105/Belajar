using Pattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Application.Repositories
{
    interface IproductRepository
    {
        void Add(Product product);
        List<Product> GetAll();
    }
}