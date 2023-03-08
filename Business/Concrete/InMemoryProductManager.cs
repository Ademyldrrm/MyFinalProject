using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class InMemoryProductManager : IProductDal
    {
        private IProductDal _productDal;

        public InMemoryProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }


        public List<Product> GetAll(Expression<Func<Product, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS8614 // Nullability of reference types in type of parameter doesn't match implicitly implemented member.
        public Product Get(Expression<Func<Product, bool>> filter)
#pragma warning restore CS8614 // Nullability of reference types in type of parameter doesn't match implicitly implemented member.
        {
            throw new NotImplementedException();
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