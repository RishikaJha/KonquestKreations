using KonquestKreations.Models;
using KonquestKreations.Mailers;
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
        [HttpPost, ActionName("AddEnquiry")]
        public ActionResult AddEnquiry(EnquiryFormEntry enquiryFormEntry)
        {
            if (ModelState.IsValid)
            {
                var enquiryForm = new EnquiryFormEntry();
                enquiryForm.Name = enquiryFormEntry.Name;
                enquiryForm.Email = enquiryFormEntry.Email;
                enquiryForm.Message = enquiryFormEntry.Message;
                enquiryForm.PhoneNumber = enquiryFormEntry.PhoneNumber;
                db.EnquiryFormEntries.Add(enquiryForm);
                db.SaveChanges();
                var userMailer = new UserMailer();
                userMailer.VerifyEmail(enquiryForm).Send();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}