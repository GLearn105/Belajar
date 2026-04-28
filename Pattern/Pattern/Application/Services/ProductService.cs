using Pattern.Application.Dtos;
using Pattern.Domain.Entities;
using Pattern.Domain.Interfaces;
using Pattern.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Application.Services
{

    class ProductService
    {
        private readonly IproductRepository repository;
        public ProductService(IproductRepository repository)
        {
            this.repository = repository;
        }
        public void AddProduct(ProductDTO dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Price = dto.Price
            };
            repository.Add(product);
        }
        public List<ProductDTO> GetProducts()
        {
            var products = repository.GetAll();
            return products.Select(p => new ProductDTO
            {
                Name = p.Name,
                Price = p.Price
            }).ToList();
        }
    }
}
