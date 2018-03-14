using System;
using System.Collections.Generic;

namespace mvc_demo.Models
{
    public class MultiSelectFormDto
    {
        public List<Guid> SelectedOptions { get; set; }
        public List<Option> AvailableOptions { get; set; }
    }
}