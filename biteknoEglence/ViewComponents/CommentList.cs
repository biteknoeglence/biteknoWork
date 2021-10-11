using biteknoEglence.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biteknoEglence.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
        {
            new UserComment
            {
                ID=1,
                Username="ali"
            },
            new UserComment
            {
                ID=2,
                Username="elif",
            }
        };
            return View(commentvalues);
        }
    }
}
