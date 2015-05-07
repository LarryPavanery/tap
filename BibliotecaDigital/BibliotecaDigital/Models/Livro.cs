using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaDigital.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool emprestado { get; set; }
        public string Descricao { get; set; }
    }
}