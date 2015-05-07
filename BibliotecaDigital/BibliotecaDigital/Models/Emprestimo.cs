using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BibliotecaDigital.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        [Display(AutoGenerateField=false)]  
        public DateTime DataEmprestimo { get; set; }
        [Display(AutoGenerateField = false)]  
        public DateTime DataDevolucao { get; set; }
        public int IdLivro { get; set; }
        public virtual Livro Livro { get; set; }
        public int IdAluno { get; set; }
        public virtual Aluno Aluno { get; set; }

        public Emprestimo()
        {
            DataEmprestimo = DateTime.Now;
            DataDevolucao = DateTime.Now;
            DataDevolucao = DataDevolucao.AddDays(5);
        }
    }
}