namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedArtiestToMeme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Memes", "Artiest", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Memes", "Artiest");
        }
    }
}
