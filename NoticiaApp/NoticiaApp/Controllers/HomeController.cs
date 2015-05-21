using NoticiaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace NoticiaApp.Controllers
{
    public class HomeController : Controller
    {

        private DBContext db = new DBContext();

        public ActionResult Index()
        {
            return View(db.Noticias.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sobre.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contato.";

            return View();
        }
        
        /// <summary>
        ///     http://www.c-sharpcorner.com/UploadFile/sourabh_mishra1/sending-an-e-mail-using-Asp-Net-mvc/
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        [HttpPost]
        public ViewResult Contact(Mail mail)
        {
            if (ModelState.IsValid)
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add(mail.Email);
                mailMessage.From = new MailAddress(mail.From);
                mailMessage.Subject = mail.Titulo;
                string Body = mail.Mensagem;
                mailMessage.Body = Body;
                mailMessage.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("username", "password");// Enter seders User name and password
                smtp.EnableSsl = true;
                smtp.Send(mailMessage);

                return View("Contact", mail);
            }
            else
            {
                return View();
            }
        }
    }
}