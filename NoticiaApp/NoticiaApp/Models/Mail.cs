using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoticiaApp.Models
{
    public class Mail
    {
        //Nome
        //Email
        //numero
        //mensagem
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Mensagem { get; set; }
        public string Titulo { get; set; }
        public string From { get; set; }

        public Mail()
        {
            From = "pavanery@gmail.com";
            Titulo = "Site de Noticias";
        }
    }
}