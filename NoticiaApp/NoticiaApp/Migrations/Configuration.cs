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
                   Titulo = "Criando p�ginas usando .NET", 
                   SubTitulo = "Uma introdu��o ao C# MVC 5", 
                   Meta = "http://cesed.br", 
                   Texto = "Ser� desenvolvido um sistema de noticias usando .Net com MVC, para isso ser� feito algo e algo mais.                                   continua."
               },
               new Noticia { 
                   Titulo = "Criando p�ginas usando .NET + AngularJS", 
                   SubTitulo = "Uma introdu��o ao Kestrel", 
                   Meta = "http://cesed.br/noticia?a=1", 
                   Texto = "Ser� desenvolvido um sistema de noticias usando .Net com MVC, para isso ser� feito algo e algo mais.                                   continua."
               },
               new Noticia { 
                   Titulo = "Microsoft lan�a Kestrel", 
                   SubTitulo = "Crie aplica��es que rodem em Linux , OS X e Windows", 
                   Meta = "http://cesed.br/sasua", 
                   Texto = "Iremos criar uma aplica��o que no ambiente Linux que ir� executar kestrel para criar um sistema MVC e ter� como consumidor um webservice na linguagem AngularJS.                                   continua."
               }
             );
        }
    }
}
