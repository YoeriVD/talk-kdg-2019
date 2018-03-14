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
        public string[] Sentiments { get; set; }
    }
}