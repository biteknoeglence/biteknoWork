using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        void ProductAdd(Product part);
        void ProductDelete(Product part);
        void ProductUpdate(Product part);
        List<Product> Getlist();
        Product GetById(int id);
        List<Product> GetListProductListWithHeading();
        List<Product> GetListProductListWithPart();
        List<Product> GetListProductListWithCategory();
        List<Product> GetListProductListByMember(int id);

    }
}
