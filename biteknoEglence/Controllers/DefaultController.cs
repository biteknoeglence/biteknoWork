using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biteknoEglence.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult OurService()
        {
            return PartialView();
        }

        public PartialViewResult Portfolio()
        {
            return PartialView();
        }

        public PartialViewResult About()
        {
            return PartialView();
        }

        public PartialViewResult Comment()
        {
            return PartialView();
        }

        public PartialViewResult Client()
        {
            return PartialView();
        }

        public PartialViewResult Blog()
        {
            return PartialView();
        }

        public PartialViewResult Education()
        {
            return PartialView();
        }

        public PartialViewResult FreeSupport()
        {
            return PartialView();
        }

        public PartialViewResult TakePrice()
        {
            return PartialView();
        }

        public PartialViewResult SendCv()
        {
            return PartialView();
        }

        public PartialViewResult Contact()
        {
            return PartialView();
        }

       
    }
}
