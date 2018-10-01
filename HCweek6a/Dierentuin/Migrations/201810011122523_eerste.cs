namespace Dierentuin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eerste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dieren",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Soort = c.String(),
                        IsZoogdier = c.Boolean(nullable: false),
                        AantalPoten = c.Int(nullable: false),
                        AantalHoofden = c.Int(nullable: false),
                        AantalOogen = c.Int(nullable: false),
                        Verblijf_Nr = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Verblijven", t => t.Verblijf_Nr)
                .Index(t => t.Verblijf_Nr);
            
            CreateTable(
                "dbo.Verblijven",
                c => new
                    {
                        Nr = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Nr);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dieren", "Verblijf_Nr", "dbo.Verblijven");
            DropIndex("dbo.Dieren", new[] { "Verblijf_Nr" });
            DropTable("dbo.Verblijven");
            DropTable("dbo.Dieren");
        }
    }
}
