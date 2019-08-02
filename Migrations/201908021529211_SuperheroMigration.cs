namespace Superhero_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SuperheroMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Superheroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SuperheroName = c.String(),
                        AlterEgo = c.String(),
                        PrimaryAbility = c.String(),
                        SecondaryAbility = c.String(),
                        CatchPhrase = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Superheroes");
        }
    }
}
