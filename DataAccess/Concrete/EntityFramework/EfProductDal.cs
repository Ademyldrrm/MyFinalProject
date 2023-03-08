using System.Data.SqlTypes;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)

        {
            using NorthwindContext context = new NorthwindContext();
            return filter ==null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
        }


        public Product Get(Expression<Func<Product, bool>> filter)

        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public void Add(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);

                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }


        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updateEntity = context.Entry(entity);

                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);

                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
