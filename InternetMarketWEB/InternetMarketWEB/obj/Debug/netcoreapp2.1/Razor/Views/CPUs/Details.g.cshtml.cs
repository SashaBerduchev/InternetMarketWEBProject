#pragma checksum "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fc6dd03fb734259caf82e4f85b9d7d6da6bfb5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CPUs_Details), @"mvc.1.0.view", @"/Views/CPUs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CPUs/Details.cshtml", typeof(AspNetCore.Views_CPUs_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\_ViewImports.cshtml"
using InternetMarketWEB;

#line default
#line hidden
#line 2 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\_ViewImports.cshtml"
using InternetMarketWEB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fc6dd03fb734259caf82e4f85b9d7d6da6bfb5f", @"/Views/CPUs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40101702d9b26b93817f2445587aee78e67c7870", @"/Views/_ViewImports.cshtml")]
    public class Views_CPUs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InternetMarketWEB.Models.CPU>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 117, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>CPU</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(247, 40, false);
#line 15 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(287, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(331, 36, false);
#line 18 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(367, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(411, 48, false);
#line 21 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Architecture));

#line default
#line hidden
            EndContext();
            BeginContext(459, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(503, 44, false);
#line 24 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Architecture));

#line default
#line hidden
            EndContext();
            BeginContext(547, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(591, 41, false);
#line 27 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cores));

#line default
#line hidden
            EndContext();
            BeginContext(632, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(676, 37, false);
#line 30 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cores));

#line default
#line hidden
            EndContext();
            BeginContext(713, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(757, 44, false);
#line 33 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Chastota));

#line default
#line hidden
            EndContext();
            BeginContext(801, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(845, 40, false);
#line 36 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Chastota));

#line default
#line hidden
            EndContext();
            BeginContext(885, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(929, 42, false);
#line 39 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.KESHL1));

#line default
#line hidden
            EndContext();
            BeginContext(971, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1015, 38, false);
#line 42 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayFor(model => model.KESHL1));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1097, 42, false);
#line 45 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.KESHL2));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1183, 38, false);
#line 48 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayFor(model => model.KESHL2));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1265, 42, false);
#line 51 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.KESHL3));

#line default
#line hidden
            EndContext();
            BeginContext(1307, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1351, 38, false);
#line 54 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayFor(model => model.KESHL3));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1433, 39, false);
#line 57 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GPU));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1516, 35, false);
#line 60 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayFor(model => model.GPU));

#line default
#line hidden
            EndContext();
            BeginContext(1551, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1595, 39, false);
#line 63 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RAM));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1678, 35, false);
#line 66 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayFor(model => model.RAM));

#line default
#line hidden
            EndContext();
            BeginContext(1713, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1757, 39, false);
#line 69 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TDP));

#line default
#line hidden
            EndContext();
            BeginContext(1796, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1840, 35, false);
#line 72 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
       Write(Html.DisplayFor(model => model.TDP));

#line default
#line hidden
            EndContext();
            BeginContext(1875, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1922, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5192a7ff1a584c80915f7cf7da7d1a15", async() => {
                BeginContext(1968, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "D:\InternetMarketWEBProject\InternetMarketWEB\InternetMarketWEB\Views\CPUs\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1976, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1984, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f89e397c4829415ea057c58eed2687f8", async() => {
                BeginContext(2006, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2022, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InternetMarketWEB.Models.CPU> Html { get; private set; }
    }
}
#pragma warning restore 1591
