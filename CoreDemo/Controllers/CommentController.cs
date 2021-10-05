using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult PartialCommentList()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult PartialCommentAdd()
        {
            return PartialView();
        }


        [HttpPost]
        public PartialViewResult PartialCommentAdd(Comment comment)
        {
            comment.BlogID = 6;
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
            comment.CommentStatus = true;
            _commentService.AddComment(comment);
            return PartialView();
        }
    }
}
