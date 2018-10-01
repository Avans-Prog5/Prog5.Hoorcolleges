namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fk_object_Ban : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Memes", "EUBan_ArtikelNr");
            RenameColumn(table: "dbo.Memes", name: "EUBan_ArtikelNr1", newName: "EUBan_ArtikelNr");
            RenameIndex(table: "dbo.Memes", name: "IX_EUBan_ArtikelNr1", newName: "IX_EUBan_ArtikelNr");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Memes", name: "IX_EUBan_ArtikelNr", newName: "IX_EUBan_ArtikelNr1");
            RenameColumn(table: "dbo.Memes", name: "EUBan_ArtikelNr", newName: "EUBan_ArtikelNr1");
            AddColumn("dbo.Memes", "EUBan_ArtikelNr", c => c.Int());
        }
    }
}
