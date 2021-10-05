using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
    public class ContactController : Controller
    {
        IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.ContactDate = DateTime.Parse(DateTime.Now.Date.ToShortDateString());
            contact.ContactStatus = true;
            _contactService.AddContact(contact);
            return RedirectToAction("Index", "Blog");
        }
    }
}
