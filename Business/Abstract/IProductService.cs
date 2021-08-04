using Entities.Concrete;
using Entities.Concrete.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IProductService
    {
        List<Product> GetProducts();
        List<Product> GetProducts(int categoryId);
        Product GetProductById(int id);
    }
}
