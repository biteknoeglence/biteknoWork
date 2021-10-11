using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biteknoEglence.ViewComponents.Product
{
    public class MemberLastProduct : ViewComponent
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        public IViewComponentResult Invoke()
        {
            var values = pm.GetListProductListByMember(1);
            return View(values);
        }
    }
}
