using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biteknoEglence.Controllers
{
    public class PartController : Controller
    {
        PartManager pm = new PartManager(new EfPartRepository());
        public IActionResult Index()
        {
            var values = pm.Getlist();
            return View();
        }
    }
}
