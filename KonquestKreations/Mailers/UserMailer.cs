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
        public virtual MvcMailMessage VerifyEmail()
        {
            return Populate(x =>
            {
                x.Subject = "Test subject";
                x.ViewName = "VerifyEmail";
                x.To.Add("divinerishika@gmail.com");
            });
        }
    }
}
