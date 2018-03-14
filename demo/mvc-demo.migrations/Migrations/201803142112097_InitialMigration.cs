namespace mvc_demo.migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sentiments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EmotionName = c.String(),
                        EmotionKind = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.TextAnalysisSentiments",
                c => new
                    {
                        TextAnalysis_Id = c.Guid(nullable: false),
                        Sentiment_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.TextAnalysis_Id, t.Sentiment_Id })
                .ForeignKey("dbo.TextAnalysis", t => t.TextAnalysis_Id, cascadeDelete: true)
                .ForeignKey("dbo.Sentiments", t => t.Sentiment_Id, cascadeDelete: true)
                .Index(t => t.TextAnalysis_Id)
                .Index(t => t.Sentiment_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TextAnalysisSentiments", "Sentiment_Id", "dbo.Sentiments");
            DropForeignKey("dbo.TextAnalysisSentiments", "TextAnalysis_Id", "dbo.TextAnalysis");
            DropIndex("dbo.TextAnalysisSentiments", new[] { "Sentiment_Id" });
            DropIndex("dbo.TextAnalysisSentiments", new[] { "TextAnalysis_Id" });
            DropTable("dbo.TextAnalysisSentiments");
            DropTable("dbo.TextAnalysis");
            DropTable("dbo.Sentiments");
        }
    }
}
