namespace NinjaApp.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClanName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NinjaFamilies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ninjas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NinjaType = c.Int(nullable: false),
                        ServedInOniwaban = c.Boolean(nullable: false),
                        MilitaryRole = c.Int(nullable: false),
                        ClanId = c.Int(),
                        NinjaFamily_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clans", t => t.ClanId)
                .ForeignKey("dbo.NinjaFamilies", t => t.NinjaFamily_Id)
                .Index(t => t.ClanId)
                .Index(t => t.NinjaFamily_Id);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EquipmentType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EquipmentNinjas",
                c => new
                    {
                        Equipment_Id = c.Int(nullable: false),
                        Ninja_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Equipment_Id, t.Ninja_Id })
                .ForeignKey("dbo.Equipments", t => t.Equipment_Id, cascadeDelete: true)
                .ForeignKey("dbo.Ninjas", t => t.Ninja_Id, cascadeDelete: true)
                .Index(t => t.Equipment_Id)
                .Index(t => t.Ninja_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ninjas", "NinjaFamily_Id", "dbo.NinjaFamilies");
            DropForeignKey("dbo.EquipmentNinjas", "Ninja_Id", "dbo.Ninjas");
            DropForeignKey("dbo.EquipmentNinjas", "Equipment_Id", "dbo.Equipments");
            DropForeignKey("dbo.Ninjas", "ClanId", "dbo.Clans");
            DropIndex("dbo.EquipmentNinjas", new[] { "Ninja_Id" });
            DropIndex("dbo.EquipmentNinjas", new[] { "Equipment_Id" });
            DropIndex("dbo.Ninjas", new[] { "NinjaFamily_Id" });
            DropIndex("dbo.Ninjas", new[] { "ClanId" });
            DropTable("dbo.EquipmentNinjas");
            DropTable("dbo.Equipments");
            DropTable("dbo.Ninjas");
            DropTable("dbo.NinjaFamilies");
            DropTable("dbo.Clans");
        }
    }
}
