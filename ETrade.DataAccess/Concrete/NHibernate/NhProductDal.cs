using ETrade.DataAccess.Abstract;
using ETrade.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.DataAccess.Concrete.NHibernate
{
    internal class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1,
                               CategoryId=2,
                               ProductName = "Laptop",
                               QuantityPerUnit="1 in a box",
                               UnitPrice=3000,
                               UnitsInStock=2 }
            };
            return products;

         
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    } 
}
