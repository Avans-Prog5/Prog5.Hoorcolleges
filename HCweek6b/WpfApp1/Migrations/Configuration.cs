namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WpfApp1.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<WpfApp1.Model.MemeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WpfApp1.Model.MemeContext context)
        {
            context.Memes.Add(new Meme() { Naam = "Pepe" });
            context.Memes.Add(new Meme() { Naam = "Hans" });
            context.Memes.Add(new Meme() { Naam = "Julgen" });
            context.Memes.Add(new Meme() { Naam = "AVans Meme" });
            context.SaveChanges();

        }
    }
}
