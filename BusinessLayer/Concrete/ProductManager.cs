using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> Getlist()
        {
            return _productDal.GetListAll();
        }

        public List<Product> GetProductByID(int id)
        {
            return _productDal.GetListAll(x => x.ProductID == id);
        }

        public List<Product> GetListProductListWithCategory()
        {
            return _productDal.GetListWithCategory();
        }

        public List<Product> GetListProductListWithHeading()
        {
            return _productDal.GetListWithHeading();
        }

        public List<Product> GetListProductListWithPart()
        {
            return _productDal.GetListWithPart();
        }

        public List<Product> GetListProductListByMember(int id)
        {
            return _productDal.GetListAll(x => x.MemberID == id);
        }

        public void ProductAdd(Product part)
        {
            throw new NotImplementedException();
        }

        public void ProductDelete(Product part)
        {
            throw new NotImplementedException();
        }

        public void ProductUpdate(Product part)
        {
            throw new NotImplementedException();
        }

        
    }
}
