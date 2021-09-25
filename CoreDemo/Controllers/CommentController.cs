using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult PartialCommentList()
        {
            return PartialView();
        }

        public PartialViewResult PartialCommentAdd()
        {
            return PartialView();
        }
    }
}
