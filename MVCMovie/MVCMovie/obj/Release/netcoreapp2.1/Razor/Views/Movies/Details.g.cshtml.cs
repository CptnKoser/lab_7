#pragma checksum "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df943d85c823815fadd0640528dcc81f9e2c39e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Details.cshtml", typeof(AspNetCore.Views_Movies_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df943d85c823815fadd0640528dcc81f9e2c39e0", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9169640970f372ab73cabb37e97a40665f5d6725", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCMovie.Models.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
  
    ViewData["Title"] = "Details";
    List<Review> reviews = (List<Review>)ViewData["Reviews"];

#line default
#line hidden
            BeginContext(138, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Movie</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(258, 41, false);
#line 15 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(299, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(343, 37, false);
#line 18 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(380, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(424, 47, false);
#line 21 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(471, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(515, 43, false);
#line 24 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(558, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(602, 41, false);
#line 27 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(643, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(687, 37, false);
#line 30 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(724, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(768, 41, false);
#line 33 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(809, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(853, 37, false);
#line 36 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(890, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(934, 42, false);
#line 39 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(976, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1020, 38, false);
#line 42 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 90, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"dl-horizontal\">\r\n        <dd>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1148, "\"", 1196, 1);
#line 47 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
WriteAttributeValue("", 1154, Html.DisplayFor(model => model.PosterURL), 1154, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1197, 73, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1270, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2bd9dbcc7e74aa0b9b799966f863c44", async() => {
                BeginContext(1340, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
                                                   WriteLiteral(Model.ID);

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
            BeginContext(1348, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1356, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03e2989f7b8e4310988a8b19c647485d", async() => {
                BeginContext(1402, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1418, 109, true);
            WriteLiteral("\r\n</div>\r\n<h3 class=\"bold\">Reviews</h3>\r\n<hr>\r\n\r\n<div class=\"spaceabove\">\r\n    <a class=\"btn btn-lg btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1527, "\"", 1635, 4);
            WriteAttributeValue("", 1534, "/Reviews/Create/", 1534, 16, true);
#line 59 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
WriteAttributeValue("", 1550, Html.DisplayFor(model => model.ID), 1550, 35, false);

#line default
#line hidden
            WriteAttributeValue("", 1585, "?movieTitle=", 1585, 12, true);
#line 59 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
WriteAttributeValue("", 1597, Html.DisplayFor(model => model.Title), 1597, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1636, 86, true);
            WriteLiteral("><span class=\"glyphicon glyphicon-pencil\"></span> Write a Review</a>\r\n</div>\r\n<hr>\r\n\r\n");
            EndContext();
#line 63 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
 foreach (Review review in reviews)
{

#line default
#line hidden
            BeginContext(1762, 70, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-sm-4\">\r\n            <p>");
            EndContext();
            BeginContext(1833, 17, false);
#line 67 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
          Write(review.userReview);

#line default
#line hidden
            EndContext();
            BeginContext(1850, 23, true);
            WriteLiteral("</p>\r\n            <em>-");
            EndContext();
            BeginContext(1874, 15, false);
#line 68 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
            Write(review.Reviewer);

#line default
#line hidden
            EndContext();
            BeginContext(1889, 195, true);
            WriteLiteral("</em>\r\n            <br />\r\n            <br />\r\n        </div>\r\n        <div class=\"col-sm-2\">\r\n            <span class=\"btn-group\" role=\"group\">\r\n                <a class=\"btn btn-sm btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2084, "\"", 2115, 2);
            WriteAttributeValue("", 2091, "/Reviews/Edit/", 2091, 14, true);
#line 74 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
WriteAttributeValue("", 2105, review.ID, 2105, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2116, 59, true);
            WriteLiteral(">Edit</a>\r\n                <a class=\"btn btn-sm btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2175, "\"", 2208, 2);
            WriteAttributeValue("", 2182, "/Reviews/Delete/", 2182, 16, true);
#line 75 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
WriteAttributeValue("", 2198, review.ID, 2198, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2209, 62, true);
            WriteLiteral(">Delete</a>\r\n            </span>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 79 "C:\Users\Brandon Koser\source\repos\lab_6\MVCMovie\MVCMovie\Views\Movies\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCMovie.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
