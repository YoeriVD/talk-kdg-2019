using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.TagHelpers
{
    [HtmlTargetElement(Attributes = "policy")]
    public class PolicyTagHelper : TagHelper
    {
        public PolicyTagHelper()
        {
        }

        public string Policy { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("policy");
            if (!string.Equals(Policy, "yoeri"))
            {
                output.Content.SetContent("Sorry, u mag dit niet uitvoeren");
                //output.Content.Clear();
            }
        }
    }
}
