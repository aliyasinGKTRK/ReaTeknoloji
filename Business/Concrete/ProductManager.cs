using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal  _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.List();
        }

        public List<Product> GetByCategory(int id)
        {
            return _productDal.List(x=>x.CategoryId==id).ToList();
        }

        public List<Product> GetByDetail(int id)
        {
            return _productDal.List(x=>x.Id==id);
        }
    }
}
