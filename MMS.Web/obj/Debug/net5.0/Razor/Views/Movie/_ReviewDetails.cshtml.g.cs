#pragma checksum "/home/runner/Assignment-PaulMcGinley/MMS.Web/Views/Movie/_ReviewDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27ce4f3dc5d4e1750a1f54357f4b9bc49e60b8e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie__ReviewDetails), @"mvc.1.0.view", @"/Views/Movie/_ReviewDetails.cshtml")]
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
#nullable restore
#line 1 "/home/runner/Assignment-PaulMcGinley/MMS.Web/Views/_ViewImports.cshtml"
using MMS.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/runner/Assignment-PaulMcGinley/MMS.Web/Views/_ViewImports.cshtml"
using MMS.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/runner/Assignment-PaulMcGinley/MMS.Web/Views/_ViewImports.cshtml"
using MMS.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27ce4f3dc5d4e1750a1f54357f4b9bc49e60b8e3", @"/Views/Movie/_ReviewDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0506793228845158aa31be8aed1f7fa5f22dd091", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie__ReviewDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MMS.Data.Models.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral(@"

<br /> <!-- Break line made to create a little space between move details and movie review-->

<h4>Reviewer Details</h4>

<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">Name</th>
            <th scope=""col"">CreatedOn</th>
            <th scope=""col"">Comment</th>
            <th scope=""col"">Rating</th>
            <th scope=""col"">Options</th>
        </tr>
    </thead>



    <tbody>
");
#nullable restore
#line 22 "/home/runner/Assignment-PaulMcGinley/MMS.Web/Views/Movie/_ReviewDetails.cshtml"
         foreach (var reviews in Model.Reviews)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>");
#nullable restore
#line 26 "/home/runner/Assignment-PaulMcGinley/MMS.Web/Views/Movie/_ReviewDetails.cshtml"
               Write(reviews.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "/home/runner/Assignment-PaulMcGinley/MMS.Web/Views/Movie/_ReviewDetails.cshtml"
               Write(Html.DisplayFor(modelItem => reviews.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> <!----Why did I use html.Display? It allowed me to get around the time problem i.e(It was displaying the date and time, I used the tag helper to force it to only display the date-->\r\n                <td>");
#nullable restore
#line 28 "/home/runner/Assignment-PaulMcGinley/MMS.Web/Views/Movie/_ReviewDetails.cshtml"
               Write(reviews.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "/home/runner/Assignment-PaulMcGinley/MMS.Web/Views/Movie/_ReviewDetails.cshtml"
               Write(reviews.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27ce4f3dc5d4e1750a1f54357f4b9bc49e60b8e35801", async() => {
                WriteLiteral("<i class=\"far fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "/home/runner/Assignment-PaulMcGinley/MMS.Web/Views/Movie/_ReviewDetails.cshtml"
                                                                         WriteLiteral(reviews.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                    <!-------- using the controller review and Iaction Delete , and get the review ID. Added in some Icon here to for better visual -->\r\n                </td>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 37 "/home/runner/Assignment-PaulMcGinley/MMS.Web/Views/Movie/_ReviewDetails.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n\r\n</table>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MMS.Data.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591