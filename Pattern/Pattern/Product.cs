using System;
namespace Pattern
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class ProductDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    interface IproductRepository
    {
        void Add(Product product);
        List<Product> GetAll();
    }
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