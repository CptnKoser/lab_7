#pragma checksum "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Reviews\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c1eb2b05e9fe8d61953314c82c3f93121535fcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_Delete), @"mvc.1.0.view", @"/Views/Reviews/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reviews/Delete.cshtml", typeof(AspNetCore.Views_Reviews_Delete))]
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
#line 1 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\_ViewImports.cshtml"
using MVCMovie;

#line default
#line hidden
#line 2 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\_ViewImports.cshtml"
using MVCMovie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c1eb2b05e9fe8d61953314c82c3f93121535fcf", @"/Views/Reviews/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9169640970f372ab73cabb37e97a40665f5d6725", @"/Views/_ViewImports.cshtml")]
    public class Views_Reviews_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCMovie.Models.Review>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Reviews\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(75, 155, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this Review?</h3>\r\n<div>\r\n\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(231, 46, false);
#line 15 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MovieTitle));

#line default
#line hidden
            EndContext();
            BeginContext(277, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(321, 42, false);
#line 18 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MovieTitle));

#line default
#line hidden
            EndContext();
            BeginContext(363, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(407, 44, false);
#line 21 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Reviewer));

#line default
#line hidden
            EndContext();
            BeginContext(451, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(495, 40, false);
#line 24 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Reviewer));

#line default
#line hidden
            EndContext();
            BeginContext(535, 93, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Comment\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(629, 42, false);
#line 30 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayFor(model => model.userReview));

#line default
#line hidden
            EndContext();
            BeginContext(671, 50, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt hidden>\r\n            ");
            EndContext();
            BeginContext(722, 43, false);
#line 33 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.movieID));

#line default
#line hidden
            EndContext();
            BeginContext(765, 50, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd hidden>\r\n            ");
            EndContext();
            BeginContext(816, 39, false);
#line 36 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayFor(model => model.movieID));

#line default
#line hidden
            EndContext();
            BeginContext(855, 32, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    ");
            EndContext();
            BeginContext(887, 284, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd833de13faa485a843d2e0ac6c50e50", async() => {
                BeginContext(913, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(923, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "24a6cbf848684bd58d3f00d67ef5722c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 40 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Reviews\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(959, 109, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a class=\"btn btn-default\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1068, "\"", 1131, 2);
                WriteAttributeValue("", 1075, "/Movies/Details/", 1075, 16, true);
#line 42 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Reviews\Delete.cshtml"
WriteAttributeValue("", 1091, Html.DisplayFor(model => model.movieID), 1091, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1132, 32, true);
                WriteLiteral(">Back to Movie Details</a>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1171, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCMovie.Models.Review> Html { get; private set; }
    }
}
#pragma warning restore 1591