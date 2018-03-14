using System;
using System.Collections.Generic;
using mvc_demo.core.Texts;

namespace mvc_demo.core.Sentiments
{
    public class Sentiment : IEntity
    {
        public Sentiment()
        {
            Id = Guid.NewGuid();
            Texts = new HashSet<TextAnalysis>();
        }

        public virtual ICollection<TextAnalysis> Texts { get; set; }

        public string EmotionName { get; set; }
        public EmotionKind EmotionKind { get; set; }
        public Guid Id { get; set; }
    }
}