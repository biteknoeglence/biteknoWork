using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class HeadingRepository : IHeadingDal
    {
        Context c = new Context();
        public void AddHeading(Heading heading)
        {
            c.Add(heading);
            c.SaveChanges();
        }

        public void DeleteHeading(Heading heading)
        {
            c.Remove(heading);
            c.SaveChanges();
        }

        public Heading GetById(int id)
        {
            return c.Headings.Find(id);
        }

        public List<Heading> ListAllHeading()
        {
            throw new NotImplementedException();
        }

        public void UpdateHeading(Heading heading)
        {
            throw new NotImplementedException();
        }
    }
}
