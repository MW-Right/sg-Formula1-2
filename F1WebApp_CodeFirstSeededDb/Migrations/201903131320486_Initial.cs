namespace F1WebApp_CodeFirstSeededDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Year = c.Int(nullable: false),
                        Wins = c.Int(nullable: false),
                        Podiums = c.Int(nullable: false),
                        FastestLaps = c.Int(nullable: false),
                        Poles = c.Int(nullable: false),
                        DriverID = c.Int(nullable: false),
                        ConstructorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarID)
                .ForeignKey("dbo.Constructors", t => t.ConstructorID, cascadeDelete: true)
                .ForeignKey("dbo.Drivers", t => t.DriverID, cascadeDelete: true)
                .Index(t => t.DriverID)
                .Index(t => t.ConstructorID);
            
            CreateTable(
                "dbo.Constructors",
                c => new
                    {
                        ConstructorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ConstructorID);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        Country = c.String(),
                        DebutYear = c.DateTime(nullable: false),
                        LastYear = c.DateTime(),
                    })
                .PrimaryKey(t => t.DriverID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "DriverID", "dbo.Drivers");
            DropForeignKey("dbo.Cars", "ConstructorID", "dbo.Constructors");
            DropIndex("dbo.Cars", new[] { "ConstructorID" });
            DropIndex("dbo.Cars", new[] { "DriverID" });
            DropTable("dbo.Drivers");
            DropTable("dbo.Constructors");
            DropTable("dbo.Cars");
        }
    }
}
