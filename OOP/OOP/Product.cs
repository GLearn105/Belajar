using System;
using System.Collections.Generic;
using System.Linq;
namespace OOP
{
    class Product
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public decimal Price {get; set;}
    }
    class Category
    {
        public int Id {get; set;}
        public string Name {get; set;}
    }
    interface IRepository<T>
    {
        void Add(T Entity);
        void Update(T Entity);
        void Delete(int id);
        void DeleteProduct (int id);
        void Remove (int id);
        void RemoveAll ();
        List<T> GetAll();
        T GetById(int id);
    }

    interface IProductRepository
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        void DeleteProduct (int id);
        void Remove(Product product);
        void RemoveAll();
        List<Product> GetAll();
        Product GetById(int id);
    }
    class ProductRepository : IRepository<Product>
    {
        private List<Product> products = new List<Product>();

        public void Add(Product entity) => products.Add(entity);
        public void Update(Product entity)
        {
            var existingProduct = GetById(entity.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = entity.Name;
                existingProduct.Price = entity.Price;
            }
        }
        public void Delete(int id)
        {
             var product = GetById(id);
            if (product != null)
             products.Remove(product);           
        }
        public void DeleteProduct(int id)
        {
             var product = GetById(id);
            if (product != null)
             products.Remove(product);           
        }
        public void Remove(int id)
        {
             var product = GetById(id);
            if (product != null)
             products.Remove(product);           
        }
        public void RemoveAll() => products.Clear();

        public List<Product> GetAll() => products;

        public Product GetById(int id) => products.FirstOrDefault(p => p.Id == id);
    }
    class CategoryRepository : IRepository<Category>
    {
        private List<Category> categories = new List<Category>();

        public void Add(Category entity) => categories.Add(entity);
        public void Update(Category entity)
        {
            var existingCategory = GetById(entity.Id);
            if (existingCategory != null)
            {
                existingCategory.Name = entity.Name;
            }
        }
        public void Delete(int id)
        {
             var category = GetById(id);
            if (category != null)
            {
                Console.WriteLine($"Category '{category.Name}' Not Found");
            }
             categories.Remove(category);           
        }
        public void DeleteProduct(int id)
        {
             var category = GetById(id);
            if (category != null)
             categories.Remove(category);           
        }
        public void Remove(int id)
        {
             var category = GetById(id);
            if (category != null)
             categories.Remove(category);           
        }
        public void RemoveAll() => categories.Clear();

        public List<Category> GetAll() => categories;

        public Category GetById(int id) => categories.FirstOrDefault(c => c.Id == id);
    }
    class ProductService
    {
        private readonly IRepository<Product> productRepository;
        public ProductService(IRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }
        public void AddProduct(Product product)
        {
            productRepository.Add(product);
            Console.WriteLine($"Product '{product.Name}' added successfully.");
        }
        public void UpdateProduct(Product product)
        {
            productRepository.Update(product);
            Console.WriteLine($"Product '{product.Name}' updated successfully.");
        }
        public void DeleteProduct(int id)
        {
            productRepository.Delete(id);
            Console.WriteLine($"Product with ID {id} deleted successfully.");
        }
        public void RemoveProduct(int id)
        {
            productRepository.Remove(id);
            Console.WriteLine($"Product with ID {id} removed successfully.");
        }
        public void RemoveAllProducts()
        {
            productRepository.RemoveAll();
            Console.WriteLine("All products removed successfully.");
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
    interface IUnitOfWork
    {
        IRepository<Product> Product { get; }
        IRepository<Category> Categories { get; }
        void Commit();
    }
    class UnitOfWork : IUnitOfWork
    {
        public IRepository<Product> Product { get; private set; }
        public IRepository<Category> Categories { get; private set; }

        public UnitOfWork()
        {
            Product =   new ProductRepository();
            Categories = new CategoryRepository();
        }
        public void Commit()
        {
            // Here you would typically save changes to the database
            
            Console.WriteLine("Changes committed to the database.");
        }
    }
}
