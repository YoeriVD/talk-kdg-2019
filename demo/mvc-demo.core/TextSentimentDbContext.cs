using System;
using System.Data.Entity;
using mvc_demo.core.Sentiments;
using mvc_demo.core.Texts;

namespace mvc_demo.core
{
    public class TextSentimentDbContext : DbContext
    {
        public IDbSet<TextAnalysis> TextAnalyses { get; set; }
        public IDbSet<Sentiment> TextSentimentses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }

    public interface IEntity
    {
        Guid Id { get; set; }
    }
}