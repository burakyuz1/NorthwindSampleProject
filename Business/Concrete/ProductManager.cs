using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product GetProductById(int id)
        {
            return _productDal.Get(m => m.ProductID == id);
        }

        public List<Product> GetProducts()
        {
            return _productDal.GetList();
        }

        public List<Product> GetProducts(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryID == categoryId);
        }
    }
}
