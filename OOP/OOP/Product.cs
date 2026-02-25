using System;
namespace OOP
{
    class Product
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public decimal Price {get; set;}
    }

    interface IProductRepository
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        List<Product> GetAll();
        Product GetById(int id);
    }
    class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();

        public void Add(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Product '{product.Name}' added successfully.");
        }
        public void Update(Product product)
        {
            var existingProduct = GetById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                Console.WriteLine($"Product '{product.Name}' updated successfully.");
            }
            else
            {
                Console.WriteLine($"Product with ID {product.Id} not found.");
            }
        }
        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine($"Product with ID {id} deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Product with ID {id} not found.");
            }
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
    class ProductService
    {
        private readonly IProductRepository productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public void AddProduct(Product product)
        {
            productRepository.Add(product);
        }
        public void UpdateProduct(Product product)
        {
            productRepository.Update(product);
        }
        public void DeleteProduct(int id)
        {
            productRepository.Delete(id);
        }
        public void ShowAllProducts()
        {
            var products = productRepository.GetAll();
            Console.WriteLine("Products:");
            foreach (var p in products)
            {
                Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Price: {p.Price}");
            }
        }
    }
}
