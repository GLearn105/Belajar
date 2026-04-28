using Pattern.Domain.Dtos;
using Pattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Mapper
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
