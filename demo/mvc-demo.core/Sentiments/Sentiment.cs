using System;

namespace mvc_demo.core.Sentiments
{
    public class Sentiment : IEntity
    {
        public Sentiment()
        {
            Id = Guid.NewGuid();
        }

        public string EmotionName { get; set; }
        public EmotionKind EmotionKind { get; set; }
        public Guid Id { get; set; }
    }
}