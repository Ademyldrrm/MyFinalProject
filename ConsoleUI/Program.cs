using System.Threading.Channels;
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
            var result = productManager.GetProductDetails();
            if (result.Success == true)
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            else
            {
                Console.WriteLine(result.Message);
            }


            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //foreach (var categories in categoryManager.GetAll())
            //{
            //    Console.WriteLine(categories.CategoryId);
            //}




        }
    }
}