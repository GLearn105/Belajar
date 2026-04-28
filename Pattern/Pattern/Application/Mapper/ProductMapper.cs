using Pattern.Application.Dtos;
using Pattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Application.Mapper
{
    class ProductMapper
    {
        public static ProductDTO ToDTO(Product product)
        {
            return new ProductDTO
            {
                Name = product.Name,
                Price = product.Price
            };
        }
        public static Product ToEntity(ProductDTO dto)
        {
            return new Product
            {
                Name = dto.Name,
                Price = dto.Price
            };
        }
    }
}
