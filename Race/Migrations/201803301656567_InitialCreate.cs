namespace Race.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        YearOfEstablishment = c.DateTime(nullable: false),
                        NumberOfWonChampionShip = c.Int(nullable: false),
                        EntryFee = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Team");
        }
    }
}
