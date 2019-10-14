using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace XM.Util.HTags
{
    [HtmlTargetElement("banner")]
    public class Banner:TagHelper
    {
        public  string Title { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "banner";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.AppendHtml($"<div class='card-title'><div class='card-footer text-center bg-blue border-width-0'><span class='font-size-lg'>{Title}</span></div></div>");
        }
    }
}
