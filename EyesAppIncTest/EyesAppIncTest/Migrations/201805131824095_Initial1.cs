namespace EyesAppIncTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CocktailModels", "Creation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CocktailModels", "Creation", c => c.DateTime(nullable: false));
        }
    }
}
