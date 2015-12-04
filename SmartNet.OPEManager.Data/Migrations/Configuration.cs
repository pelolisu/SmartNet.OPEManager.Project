using System.Data.Entity.Migrations;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Domain.Entities;

namespace SmartNet.OPEManager.Data.Migrations
{
   internal sealed class Configuration : DbMigrationsConfiguration<OPEModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OPEModelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var professor = new Professor
            {
                nome = "Vanderson",
                RA = 1400000,
                senha = "123",
                email = "varnderson@teste.com",
                perfil = Usuario.Perfil.Administrador,
                ativo = true
            };
            context.Professores.AddOrUpdate(professor);
        }
    }
}
