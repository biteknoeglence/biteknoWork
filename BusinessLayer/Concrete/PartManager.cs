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
    public class PartManager : IPartService
    {
        IPartDal _partDal;

        public PartManager(IPartDal partDal)
        {
            _partDal = partDal;
        }

        public Part GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Part> Getlist()
        {
            return _partDal.GetListAll();
        }

        public void PartAdd(Part part)
        {
            throw new NotImplementedException();
        }

        public void PartDelete(Part part)
        {
            throw new NotImplementedException();
        }

        public void PartUpdate(Part part)
        {
            throw new NotImplementedException();
        }
    }
}
