namespace mvc_demo.migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rename : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TextAnalysis", "TextContent", c => c.String());
            DropColumn("dbo.TextAnalysis", "Preview");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TextAnalysis", "Preview", c => c.String());
            DropColumn("dbo.TextAnalysis", "TextContent");
        }
    }
}
