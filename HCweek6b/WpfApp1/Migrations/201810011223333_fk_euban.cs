namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fk_euban : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Memes", "EUBan_ArtikelNr", "dbo.EUBans");
            DropIndex("dbo.Memes", new[] { "EUBan_ArtikelNr" });
            AddColumn("dbo.Memes", "EUBan_ArtikelNr1", c => c.Int());
            CreateIndex("dbo.Memes", "EUBan_ArtikelNr1");
            AddForeignKey("dbo.Memes", "EUBan_ArtikelNr1", "dbo.EUBans", "ArtikelNr");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Memes", "EUBan_ArtikelNr1", "dbo.EUBans");
            DropIndex("dbo.Memes", new[] { "EUBan_ArtikelNr1" });
            DropColumn("dbo.Memes", "EUBan_ArtikelNr1");
            CreateIndex("dbo.Memes", "EUBan_ArtikelNr");
            AddForeignKey("dbo.Memes", "EUBan_ArtikelNr", "dbo.EUBans", "ArtikelNr");
        }
    }
}
