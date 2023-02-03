using DataAccess.Abstract;
using Entities.Concrete;


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product { ProductId = 1, CategoryId = 2, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 5 },
                new Product
                {
                    ProductId = 2, CategoryId = 3, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3
                },
                new Product
                {
                    ProductId = 3, CategoryId = 2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 2
                },
                new Product { ProductId = 4, CategoryId = 2, ProductName = "Mouse", UnitPrice = 85, UnitsInStock = 65 },
                new Product
                {
                    ProductId = 5, CategoryId = 2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 1
                }
            };
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
          
        }

        public void Delete(Product product)
        {
            //Product productToDelete = null;

            //foreach (var p in _products)
            //{
            //    if (product.ProductId==product.ProductId)
            //    {
            //        productToDelete=p;
            //    }

            //}

            //LINQ
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        }

        public List<Product> GettallByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    
}
}
