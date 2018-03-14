using System;

namespace mvc_demo.Models
{
    public class Option
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsSelected { get; set; }
    }
}