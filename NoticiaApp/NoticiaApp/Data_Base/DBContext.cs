using NoticiaApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NoticiaApp.Data_Base
{
    public class DBContext : DbContext
    {
        public DbSet<Noticia> Noticias { get; set; }

        /// <summary>
        /// construtor. eh passada a string de conexao, ela devera ser usada para criar a conexao com a base
        /// ou seja, devera exitir uma string de conexao no arquivo Web.config
        /// </summary>
        public DBContext() : base("noticia")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DBContext, Configuration>());
        }
    }
}