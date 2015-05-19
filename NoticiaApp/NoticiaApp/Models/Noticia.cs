using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoticiaApp.Models
{
    public class Noticia
    {
        /// <summary>
        /// id do obj
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// titulo da noticia
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// sub titulo da noticia
        /// </summary>
        public string SubTitulo { get; set; }

        /// <summary>
        /// eh o link de quem pertence a noticia, por exemplo, se a noticia vier do olhar digital
        /// entao essa propriedade tera o link da noticia, referenciando o site deles
        /// </summary>
        public string Meta { get; set; }

        /// <summary>
        /// data de quando a aplicacao foi criada
        /// </summary>
        public DateTime DataCreated { get; set; }

        /// <summary>
        /// data da ultima alteracao da noticia, caso alguem precise editar
        /// </summary>
        public DateTime LastUpdate { get; set; }

    }
}