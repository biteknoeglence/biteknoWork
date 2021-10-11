using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biteknoEglence.Controllers
{
    public class HeadingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
