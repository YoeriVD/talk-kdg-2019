namespace mvc_demo.migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TextAnalysis",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Preview = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sentiments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EmotionName = c.String(),
                        EmotionKind = c.Int(nullable: false),
                        TextAnalysis_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TextAnalysis", t => t.TextAnalysis_Id)
                .Index(t => t.TextAnalysis_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sentiments", "TextAnalysis_Id", "dbo.TextAnalysis");
            DropIndex("dbo.Sentiments", new[] { "TextAnalysis_Id" });
            DropTable("dbo.Sentiments");
            DropTable("dbo.TextAnalysis");
        }
    }
}
