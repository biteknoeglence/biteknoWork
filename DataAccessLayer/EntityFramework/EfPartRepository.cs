using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfPartRepository : GenericRepository<Part>, IPartDal
    {
        public void Delete(Part t)
        {
            throw new NotImplementedException();
        }

        public void Insert(Part t)
        {
            throw new NotImplementedException();
        }

        public void Update(Part t)
        {
            throw new NotImplementedException();
        }

        Part IGenericDal<Part>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        List<Part> IGenericDal<Part>.GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
