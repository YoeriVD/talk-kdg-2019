using System.Collections.Generic;

namespace mvc_demo.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<TextCard> TextCards { get; set; }
    }

    public class TextCard
    {
        public string Title { get; set; }
        public string Preview { get; set; }
        public List<Sentiment> Sentiments { get; set; }
    }

    public class Sentiment
    {
        public string EmotionName { get; set; }
        public EmotionKind EmotionKind { get; set; }
    }

    public enum EmotionKind
    {
        Positive = 1,
        Neutral = 0,
        Negative = -1
    }
}