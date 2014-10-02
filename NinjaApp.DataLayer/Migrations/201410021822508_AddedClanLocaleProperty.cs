namespace NinjaApp.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedClanLocaleProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clans", "Locale", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clans", "Locale");
        }
    }
}
