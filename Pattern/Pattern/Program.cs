using System;
namespace Pattern
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
                foreach (var product in products)
                {
                    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
                }
        }
    }
}