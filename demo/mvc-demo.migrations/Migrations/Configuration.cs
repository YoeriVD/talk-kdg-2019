using mvc_demo.core.Sentiments;

namespace mvc_demo.migrations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<mvc_demo.core.TextSentimentDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(mvc_demo.core.TextSentimentDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Sentiments.AddOrUpdate(s => s.EmotionName, new Sentiment()
            {
                EmotionKind = EmotionKind.Negative,
                EmotionName = "angry"
            });
            context.Sentiments.AddOrUpdate(s => s.EmotionName, new Sentiment()
            {
                EmotionKind = EmotionKind.Negative,
                EmotionName = "sad"
            });
            context.Sentiments.AddOrUpdate(s => s.EmotionName, new Sentiment()
            {
                EmotionKind = EmotionKind.Negative,
                EmotionName = "dissapointment"
            });
            context.Sentiments.AddOrUpdate(s => s.EmotionName, new Sentiment()
            {
                EmotionKind = EmotionKind.Positive,
                EmotionName = "happy"
            });
            context.Sentiments.AddOrUpdate(s => s.EmotionName, new Sentiment()
            {
                EmotionKind = EmotionKind.Positive,
                EmotionName = "joyfull"
            });
            context.Sentiments.AddOrUpdate(s => s.EmotionName, new Sentiment()
            {
                EmotionKind = EmotionKind.Positive,
                EmotionName = "relieved"
            });
        }
    }
}
