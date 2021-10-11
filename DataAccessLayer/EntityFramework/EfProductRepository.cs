using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>, IProductDal
    {
        Context c = new Context();
        public List<Product> GetListWithCategory()
        {
            return c.Products.Include(x => x.Heading.Part.Category).ToList();
        }

        public List<Product> GetListWithHeading()
        {
                return c.Products.Include(x => x.Heading).ToList();
        }

        public List<Product> GetListWithPart()
        {
                return c.Products.Include(x => x.Heading.Part).ToList();
        }
    }
}
