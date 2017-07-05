using SalaoBeleza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SalaoBeleza.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Hair()
        {
            ViewBag.Message = "Your hair page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MakeUp()
        {
            ViewBag.Message = "Your make up page.";

            return View();
        }

        public ActionResult Manicure()
        {
            ViewBag.Message = "Your manicure page.";

            return View();
        }

        public ActionResult Podiatry()
        {
            ViewBag.Message = "Your podiatry page.";

            return View();
        }

        public ActionResult Aesthetics()
        {
            ViewBag.Message = "Your aesthetics page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(Email email)
        {
            if (ModelState.IsValid)
            {
                SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
                var mail = new MailMessage();
                mail.From = new MailAddress(email.FromEmail);
                mail.To.Add("salao.beleza.2016@hotmail.com");
                mail.Subject = "Mensagem do Site: " + email.FromName;
                mail.IsBodyHtml = true;
                mail.Body = "<pre>" + email.Message + "</pre>";
                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("salao.beleza.2016@hotmail.com", "password");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }

            return View();
        }
    }
}
 