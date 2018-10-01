namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EUBans",
                c => new
                    {
                        ArtikelNr = c.Int(nullable: false, identity: true),
                        Artiest = c.String(),
                    })
                .PrimaryKey(t => t.ArtikelNr);
            
            CreateTable(
                "dbo.Memes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        EUBan_ArtikelNr = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EUBans", t => t.EUBan_ArtikelNr)
                .Index(t => t.EUBan_ArtikelNr);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Memes", "EUBan_ArtikelNr", "dbo.EUBans");
            DropIndex("dbo.Memes", new[] { "EUBan_ArtikelNr" });
            DropTable("dbo.Memes");
            DropTable("dbo.EUBans");
        }
    }
}
