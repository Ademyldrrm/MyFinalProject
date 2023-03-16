using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }

            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //foreach (var categories in categoryManager.GetAll())
            //{
            //    Console.WriteLine(categories.CategoryId);
            //}
        }
    }
}