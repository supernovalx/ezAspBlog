#pragma checksum "D:\Documents\Desktop\temp\ezAspBlog\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beae964e752aed80eafe02ec0bfb3d2d181465e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(temp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(temp.Pages.Pages_Index), null)]
namespace temp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Documents\Desktop\temp\ezAspBlog\Pages\_ViewImports.cshtml"
using temp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beae964e752aed80eafe02ec0bfb3d2d181465e3", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4e9507489ffa43b22cffc497a9b577f0b69b0f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "NewComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-delete-comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Documents\Desktop\temp\ezAspBlog\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\Documents\Desktop\temp\ezAspBlog\Pages\Index.cshtml"
 foreach (var post in Model.Posts)
{

#line default
#line hidden
            BeginContext(112, 69, true);
            WriteLiteral("    <div class=\"post\">\r\n        <h1 class=\"post-title\">\r\n            ");
            EndContext();
            BeginContext(182, 10, false);
#line 11 "D:\Documents\Desktop\temp\ezAspBlog\Pages\Index.cshtml"
       Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(192, 106, true);
            WriteLiteral("\r\n        </h1>\r\n        <hr>\r\n        <h4 class=\"post-author\">Author: \r\n            <b>\r\n                ");
            EndContext();
            BeginContext(299, 11, false);
#line 16 "D:\Documents\Desktop\temp\ezAspBlog\Pages\Index.cshtml"
           Write(post.Author);

#line default
#line hidden
            EndContext();
            BeginContext(310, 60, true);
            WriteLiteral("\r\n            </b>\r\n        </h4>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(371, 12, false);
#line 20 "D:\Documents\Desktop\temp\ezAspBlog\Pages\Index.cshtml"
       Write(post.Content);

#line default
#line hidden
            EndContext();
            BeginContext(383, 65, true);
            WriteLiteral("\r\n        </p>\r\n        <hr>\r\n        <h4>Comments</h4>\r\n        ");
            EndContext();
            BeginContext(448, 395, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beae964e752aed80eafe02ec0bfb3d2d181465e36126", async() => {
                BeginContext(468, 34, true);
                WriteLiteral("\r\n            <input name=\"postId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 502, "\"", 518, 1);
#line 25 "D:\Documents\Desktop\temp\ezAspBlog\Pages\Index.cshtml"
WriteAttributeValue("", 510, post.ID, 510, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(519, 248, true);
                WriteLiteral(" type=\"hidden\">\r\n            <input class=\"comment-input-name\" type=\"text\" name=\"author\" placeholder=\"Your name\" required/>\r\n            <textarea class=\"comment-input-content\" name=\"content\" placeholder=\"Comment\" required></textarea>\r\n            ");
                EndContext();
                BeginContext(767, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beae964e752aed80eafe02ec0bfb3d2d181465e37195", async() => {
                    BeginContext(805, 12, true);
                    WriteLiteral("Post comment");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(826, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(843, 18, true);
            WriteLiteral("\r\n        <hr />\r\n");
            EndContext();
#line 31 "D:\Documents\Desktop\temp\ezAspBlog\Pages\Index.cshtml"
         foreach (var comment in post.Comments)
        {

#line default
#line hidden
            BeginContext(921, 51, true);
            WriteLiteral("            <div class=\"comment\">\r\n                ");
            EndContext();
            BeginContext(972, 230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beae964e752aed80eafe02ec0bfb3d2d181465e310291", async() => {
                BeginContext(992, 45, true);
                WriteLiteral("\r\n                    <input name=\"commentId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1037, "\"", 1056, 1);
#line 35 "D:\Documents\Desktop\temp\ezAspBlog\Pages\Index.cshtml"
WriteAttributeValue("", 1045, comment.ID, 1045, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1057, 37, true);
                WriteLiteral(" type=\"hidden\">\r\n                    ");
                EndContext();
                BeginContext(1094, 83, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beae964e752aed80eafe02ec0bfb3d2d181465e311152", async() => {
                    BeginContext(1162, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1177, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1202, 44, true);
            WriteLiteral("\r\n                <h5>\r\n                    ");
            EndContext();
            BeginContext(1247, 14, false);
#line 39 "D:\Documents\Desktop\temp\ezAspBlog\Pages\Index.cshtml"
               Write(comment.Author);

#line default
#line hidden
            EndContext();
            BeginContext(1261, 101, true);
            WriteLiteral(" <i>said</i>:\r\n                </h5>\r\n                <hr>\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(1363, 15, false);
#line 43 "D:\Documents\Desktop\temp\ezAspBlog\Pages\Index.cshtml"
               Write(comment.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1378, 44, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n");
            EndContext();
#line 46 "D:\Documents\Desktop\temp\ezAspBlog\Pages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1433, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 48 "D:\Documents\Desktop\temp\ezAspBlog\Pages\Index.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
