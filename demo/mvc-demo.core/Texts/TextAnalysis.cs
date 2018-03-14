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
            Sentiments = new HashSet<Sentiment>();
        }

        public string Title { get; set; }
        public string Preview { get; set; }
        public virtual ICollection<Sentiment> Sentiments { get; set; }
        public Guid Id { get; set; }
    }
}