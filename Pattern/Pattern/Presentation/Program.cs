using Pattern.Application.Dtos;
using Pattern.Application.Services;
using Pattern.Domain.Interfaces;
using Pattern.Entity;
using Pattern.Infrastructure;
using Pattern.Infrastructure.Repositories;
using System;
namespace Pattern.Presentation
{
    class Program
    {
        static void Main()
        {
           IproductRepository repository = new ProductRepository();
           ProductService service = new ProductService(repository);
           
           ProductDTO dto = new ProductDTO { Name = "Laptop", Price = 1500 };
           ProductDTO dto2 = new ProductDTO { Name = "Phone", Price = 800 };
              service.AddProduct(dto);
                service.AddProduct(dto2);
              var products = service.GetProducts();
                foreach (var p in products)
                {
                Console.WriteLine(p.Name +" " + p.Price);
                }
        }
    }
    //day32
}