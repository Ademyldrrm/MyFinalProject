using Business.Abstact;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;
       

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public List<Product> GettAll()
        {
               return _productDal.GetAll();
        }
    }
}
