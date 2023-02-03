using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class InMemoryProductManager : IProductDal
    {
        private IProductDal _productDal;

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GettallByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}