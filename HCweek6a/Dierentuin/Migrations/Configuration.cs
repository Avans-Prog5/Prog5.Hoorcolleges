namespace Dierentuin.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Dierentuin.DierentuinContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Dierentuin.DierentuinContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Dieren.Add(new Dier() { Soort = "pingwing", AantalOogen = 2, AantalPoten = 2 });
            context.Dieren.Add(new Dier() { Soort = "Lemmings", AantalOogen = 2, AantalPoten = 2 , IsZoogdier = true });
            context.Dieren.Add(new Dier() { Soort = "Zebra", AantalOogen = 2, AantalPoten = 4 , IsZoogdier = true });
            context.Dieren.Add(new Dier() { Soort = "Spin", AantalOogen = 32, AantalPoten = 8});
            context.SaveChanges();

        }
    }
}
