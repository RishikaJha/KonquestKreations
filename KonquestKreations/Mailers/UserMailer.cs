using KonquestKreations.Models;
using Mvc.Mailer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonquestKreations.Mailers
{
    public class UserMailer : MailerBase
    {
        public UserMailer()
        {
            MasterName = "_Layout";
        }
        public virtual MvcMailMessage VerifyEmail(EnquiryFormEntry enquiryFormEntry)
        {
            
           
            ViewBag.Name = "Customer Name : " + enquiryFormEntry.Name;
            ViewBag.Message = "Message : " + enquiryFormEntry.Message;
            ViewBag.Email = "Customer Email ID : "+ enquiryFormEntry.Email;
            ViewBag.Phone = "Customer Contact No. : " + enquiryFormEntry.PhoneNumber;
            return Populate(x =>
            {
                x.ViewName = "VerifyEmail";
                x.Subject = "Customer Enquiry for Konquest Kreations";
                x.To.Add("KonquestKreation@gmail.com");
                x.CC.Add("divinerishika@gmail.com");
              
            });
        }
    }
}
