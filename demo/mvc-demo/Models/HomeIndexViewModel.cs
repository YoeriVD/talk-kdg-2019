using System.Collections.Generic;
using mvc_demo.core.Texts;

namespace mvc_demo.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<TextAnalysis> TextCards { get; set; }
    }
}