using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPartService
    {
        void PartAdd(Part part);
        void PartDelete(Part part);
        void PartUpdate(Part part);
        List<Part> Getlist();
        Part GetById(int id);
    }
}
