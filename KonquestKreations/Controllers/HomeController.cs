using KonquestKreations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KonquestKreations.Controllers
{
    public class HomeController : Controller
    {
        private EnquiryFromContext db = new EnquiryFromContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost,ActionName("AddEnquiry")]
        public ActionResult AddEnquiry(EnquiryFormEntry enquiryFormEntry)
        {
            if (ModelState.IsValid)
            {
                var enquiryForm = new EnquiryFormEntry();
                enquiryForm.Name = enquiryFormEntry.Name;
                enquiryForm.Email = enquiryFormEntry.Email;
                enquiryForm.Message = enquiryFormEntry.Message;
                db.EnquiryFormEntries.Add(enquiryForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }


    }
}