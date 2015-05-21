using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public string Titulo { get; set; }
        /// <summary>
        /// sub titulo da noticia
        /// </summary>
        [Required]
        public string SubTitulo { get; set; }
        /// <summary>
        /// eh o link de quem pertence a noticia, por exemplo, se a noticia vier do olhar digital
        /// entao essa propriedade tera o link da noticia, referenciando o site deles
        /// </summary>
        [Required]
        public string Meta { get; set; }
        /// <summary>
        /// eh o link de quem pertence a noticia, por exemplo, se a noticia vier do olhar digital
        /// entao essa propriedade tera o link da noticia, referenciando o site deles
        /// </summary>
        [Required]
        [StringLength(300, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 50)]
        [DataType(DataType.MultilineText)]
        public string Texto { get; set; }
        /// <summary>
        /// data de quando a aplicacao foi criada
        /// </summary>
        [Display(Name = "Criação")]
        public DateTime DataCreated { get; set; }

        /// <summary>
        /// data da ultima alteracao da noticia, caso alguem precise editar
        /// </summary>
        [Display(Name = "Ultima alteração")]
        public DateTime LastUpdate { get; set; }

        public Noticia()
        {
            DataCreated = DateTime.Now;
            LastUpdate = DateTime.Now;
        }
    }
}