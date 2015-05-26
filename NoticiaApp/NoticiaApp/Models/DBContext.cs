using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NoticiaApp.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Noticia> Noticias { get; set; }
        /// <summary>
        /// construtor. eh passada a string de conexao, ela devera ser usada para criar a conexao com a base
        /// ou seja, devera exitir uma string de conexao no arquivo Web.config
        /// </summary>
        public DBContext()
            : base("noticiaapp")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DBContext, Configuration>());
        }

        public System.Data.Entity.DbSet<NoticiaApp.Models.Genero> Generos { get; set; }
    }
}