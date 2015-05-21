namespace NoticiaApp.Migrations
{
    using NoticiaApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NoticiaApp.Models.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NoticiaApp.Models.DBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Noticias.AddOrUpdate(
             n => n.Titulo,
               new Noticia { 
                   Titulo = "Criando páginas usando .NET", 
                   SubTitulo = "Uma introdução ao C# MVC 5", 
                   Meta = "http://cesed.br", 
                   Texto = "Será desenvolvido um sistema de noticias usando .Net com MVC, para isso será feito algo e algo mais.                                   continua."
               },
               new Noticia { 
                   Titulo = "Criando páginas usando .NET + AngularJS", 
                   SubTitulo = "Uma introdução ao Kestrel", 
                   Meta = "http://cesed.br/noticia?a=1", 
                   Texto = "Será desenvolvido um sistema de noticias usando .Net com MVC, para isso será feito algo e algo mais.                                   continua."
               },
               new Noticia { 
                   Titulo = "Microsoft lança Kestrel", 
                   SubTitulo = "Crie aplicações que rodem em Linux , OS X e Windows", 
                   Meta = "http://cesed.br/sasua", 
                   Texto = "Iremos criar uma aplicação que no ambiente Linux que irá executar kestrel para criar um sistema MVC e terá como consumidor um webservice na linguagem AngularJS.                                   continua."
               }
             );
        }
    }
}
