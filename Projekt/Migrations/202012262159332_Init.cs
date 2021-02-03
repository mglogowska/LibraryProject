namespace Projekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autorzy",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Gatunki",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NazwaGatunku = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Klienci",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Wypozyczenia",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KlientID = c.Int(nullable: false),
                        KsiazkaID = c.Int(nullable: false),
                        DataWypozyczenia = c.DateTime(nullable: false),
                        DataOddania = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Klienci", t => t.KlientID, cascadeDelete: true)
                .ForeignKey("dbo.Ksiazki", t => t.KsiazkaID, cascadeDelete: true)
                .Index(t => t.KlientID)
                .Index(t => t.KsiazkaID);
            
            CreateTable(
                "dbo.Ksiazki",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tytul = c.String(),
                        GatunekID = c.Int(nullable: false),
                        AutorID = c.Int(nullable: false),
                        Ilosc = c.Int(nullable: false),
                        DataDodania = c.DateTime(nullable: false),
                        DataModyfikacji = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Autorzy", t => t.AutorID, cascadeDelete: true)
                .ForeignKey("dbo.Gatunki", t => t.GatunekID, cascadeDelete: true)
                .Index(t => t.GatunekID)
                .Index(t => t.AutorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wypozyczenia", "KsiazkaID", "dbo.Ksiazki");
            DropForeignKey("dbo.Ksiazki", "GatunekID", "dbo.Gatunki");
            DropForeignKey("dbo.Ksiazki", "AutorID", "dbo.Autorzy");
            DropForeignKey("dbo.Wypozyczenia", "KlientID", "dbo.Klienci");
            DropIndex("dbo.Ksiazki", new[] { "AutorID" });
            DropIndex("dbo.Ksiazki", new[] { "GatunekID" });
            DropIndex("dbo.Wypozyczenia", new[] { "KsiazkaID" });
            DropIndex("dbo.Wypozyczenia", new[] { "KlientID" });
            DropTable("dbo.Ksiazki");
            DropTable("dbo.Wypozyczenia");
            DropTable("dbo.Klienci");
            DropTable("dbo.Gatunki");
            DropTable("dbo.Autorzy");
        }
    }
}
