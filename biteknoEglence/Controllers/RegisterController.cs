using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biteknoEglence.Controllers
{
    public class RegisterController : Controller
    {
        MemberManager mm = new MemberManager(new EfMemberRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Member p)
        {
            MemberValidator mv = new MemberValidator();
            ValidationResult results = mv.Validate(p);
            if(results.IsValid)
            {

                p.MemberStatus = true;
                p.MemberAbout = "test";
                mm.MemberAdd(p);
                return RedirectToAction("Index", "Product");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
            }
            return View();
        }
    }
}
