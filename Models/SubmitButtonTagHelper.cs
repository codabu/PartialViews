using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewAndTagHelpers.Models
{
    [HtmlTargetElement("submit-button")]
    public class SubmitButtonTagHelper : TagHelper
    {
        public override void Process (TagHelperContext context, TagHelperOutput output)
        {
            //make this a button element with start and end tags
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;

            //make the custom button a submit button
            output.Attributes.SetAttribute("type", "submit");

            //append the classes for a bootstrap button
            string classes = "btn btn-primary";
            output.Attributes.SetAttribute("class", classes);

        }

    }
}
