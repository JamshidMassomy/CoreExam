
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace XM.Util.HTags
{
    //[HtmlTargetElement("input", Attributes = "input-type",ParentTag = "div")]


    [HtmlTargetElement("row")]
    public class Row : TagHelper
    {
        [HtmlAttributeName("T-Type")]
        public  string Type { get; set; }
        
        private string AttributeName { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
           
            output.TagName = "row";
            output.Attributes.SetAttribute("class", "form-group");
            output.Attributes.SetAttribute("style", "margin-bottom: 0.35rem !important ;margin-right: 0.90rem;margin-top: 0.02rem;");
            //output.PreElement.SetHtmlContent("<div class='form-group row'><div class='col-lg-12'>");
            //output.PostElement.SetHtmlContent("</div></div>");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}
