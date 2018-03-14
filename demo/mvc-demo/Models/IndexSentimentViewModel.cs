using System;

namespace mvc_demo.Models
{
    public class IndexSentimentViewModel
    {
        public string Text { get; set; }
        public MultiSelectFormDto SelectedSentiments { get; set; }
        public string Title { get; set; }
        public Guid Id { get; set; }
    }
}