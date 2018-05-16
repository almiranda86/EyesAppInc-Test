namespace EyesAppIncTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CocktailModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PercentageOfAlcohol = c.Double(nullable: false),
                        HexadecimalColor = c.String(),
                        Creation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IngredientModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Quantity = c.Int(nullable: false),
                        QuantityUnit = c.String(),
                        Alcohol = c.Double(nullable: false),
                        HexaColor = c.String(),
                        CocktailModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CocktailModels", t => t.CocktailModel_Id)
                .Index(t => t.CocktailModel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IngredientModels", "CocktailModel_Id", "dbo.CocktailModels");
            DropIndex("dbo.IngredientModels", new[] { "CocktailModel_Id" });
            DropTable("dbo.IngredientModels");
            DropTable("dbo.CocktailModels");
        }
    }
}
