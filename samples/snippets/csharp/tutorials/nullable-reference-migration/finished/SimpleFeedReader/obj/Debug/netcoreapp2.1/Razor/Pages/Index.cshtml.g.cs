#pragma checksum "C:\code\work\dotnet\dotnet-docs\samples\csharp\tutorials\nullable-reference-migration\finished\SimpleFeedReader\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75313b9607a8792c20cf3f4cef31dca9d793f0b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SimpleFeedReader.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(SimpleFeedReader.Pages.Pages_Index), null)]
namespace SimpleFeedReader.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\code\work\dotnet\dotnet-docs\samples\csharp\tutorials\nullable-reference-migration\finished\SimpleFeedReader\Pages\_ViewImports.cshtml"
using SimpleFeedReader;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75313b9607a8792c20cf3f4cef31dca9d793f0b0", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00052b1514320e9bae4bdce4ba52474f7e91bb57", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\code\work\dotnet\dotnet-docs\samples\csharp\tutorials\nullable-reference-migration\finished\SimpleFeedReader\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 75, true);
            WriteLiteral("<h2>Simple Feed Reader</h2>\r\n<hr />\r\n<div class=\"row\">\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(146, 443, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa1aab38d6274caf8a5f677697b3ba2b", async() => {
                BeginContext(165, 179, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label>\r\n                    Enter a feed URL:\r\n                    <input name=\"FeedUrl\" id=\"FeedUrl\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 344, "\"", 377, 1);
#line 14 "C:\code\work\dotnet\dotnet-docs\samples\csharp\tutorials\nullable-reference-migration\finished\SimpleFeedReader\Pages\Index.cshtml"
WriteAttributeValue("", 352, Request.Query["feedurl"], 352, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(378, 204, true);
                WriteLiteral(" />\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Retrieve Feed\" class=\"btn btn-default\" />\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(589, 20, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n");
            EndContext();
#line 23 "C:\code\work\dotnet\dotnet-docs\samples\csharp\tutorials\nullable-reference-migration\finished\SimpleFeedReader\Pages\Index.cshtml"
     if (!string.IsNullOrEmpty(Model.ErrorText))
    {

#line default
#line hidden
            BeginContext(666, 51, true);
            WriteLiteral("        <div>\r\n            <h3 class=\"text-danger\">");
            EndContext();
            BeginContext(718, 15, false);
#line 26 "C:\code\work\dotnet\dotnet-docs\samples\csharp\tutorials\nullable-reference-migration\finished\SimpleFeedReader\Pages\Index.cshtml"
                               Write(Model.ErrorText);

#line default
#line hidden
            EndContext();
            BeginContext(733, 23, true);
            WriteLiteral("</h3>\r\n        </div>\r\n");
            EndContext();
#line 28 "C:\code\work\dotnet\dotnet-docs\samples\csharp\tutorials\nullable-reference-migration\finished\SimpleFeedReader\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(763, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "C:\code\work\dotnet\dotnet-docs\samples\csharp\tutorials\nullable-reference-migration\finished\SimpleFeedReader\Pages\Index.cshtml"
     if (Model.NewsItems?.Count > 0)
    {

#line default
#line hidden
            BeginContext(810, 184, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>Title</th>\r\n                <th>Published</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 40 "C:\code\work\dotnet\dotnet-docs\samples\csharp\tutorials\nullable-reference-migration\finished\SimpleFeedReader\Pages\Index.cshtml"
             foreach (var item in Model.NewsItems)
            {

#line default
#line hidden
            BeginContext(1061, 74, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1135, "\"", 1151, 1);
#line 44 "C:\code\work\dotnet\dotnet-docs\samples\csharp\tutorials\nullable-reference-migration\finished\SimpleFeedReader\Pages\Index.cshtml"
WriteAttributeValue("", 1142, item.Uri, 1142, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1152, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(1170, 10, false);
#line 44 "C:\code\work\dotnet\dotnet-docs\samples\csharp\tutorials\nullable-reference-migration\finished\SimpleFeedReader\Pages\Index.cshtml"
                                                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1180, 83, true);
            WriteLiteral("</a>\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1264, 48, false);
#line 47 "C:\code\work\dotnet\dotnet-docs\samples\csharp\tutorials\nullable-reference-migration\finished\SimpleFeedReader\Pages\Index.cshtml"
                   Write(item.Published.ToString("MMM dd, yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 50 "C:\code\work\dotnet\dotnet-docs\samples\csharp\tutorials\nullable-reference-migration\finished\SimpleFeedReader\Pages\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1379, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 53 "C:\code\work\dotnet\dotnet-docs\samples\csharp\tutorials\nullable-reference-migration\finished\SimpleFeedReader\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1418, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
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
