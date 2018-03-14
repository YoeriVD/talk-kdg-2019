using System;
using System.Collections.Generic;
using mvc_demo.core.Sentiments;

namespace mvc_demo.core.Texts
{
    public class TextAnalysis : IEntity
    {
        public TextAnalysis()
        {
            Id = Guid.NewGuid();
        }

        public string Title { get; set; }
        public string Preview { get; set; }
        public List<Sentiment> Sentiments { get; set; }
        public Guid Id { get; set; }
    }
}