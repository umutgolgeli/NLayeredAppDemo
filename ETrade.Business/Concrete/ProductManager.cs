using ETrade.Business.Abstract;
using ETrade.DataAccess.Abstract;
using ETrade.DataAccess.Concrete;
using ETrade.DataAccess.Concrete.EntityFramework;
using ETrade.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
         _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Business codes
            
            return _productDal.GetAll();
        }
    }
}
