using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
        private readonly IWriterService _writerService;

        public LoginController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        [AllowAnonymous] // proje seviyesinde tanımlanan bütün kurallardan muaf ol.
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous] // proje seviyesinde tanımlanan bütün kurallardan muaf ol.
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            var dataValue = _writerService.ListAllWriter().FirstOrDefault(i => i.WriterMail == writer.WriterMail && i.WriterPassword == writer.WriterPassword);
            if (dataValue != null)
            {
                HttpContext.Session.SetString("username", writer.WriterMail);
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }
        }
    }
}
