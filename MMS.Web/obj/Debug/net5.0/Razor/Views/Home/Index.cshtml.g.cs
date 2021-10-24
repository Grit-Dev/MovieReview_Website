#pragma checksum "/home/runner/Assignment-PaulMcGinley/MMS.Web/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7e4e5f4c1593ac8577bead240d2549c10b639df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e4e5f4c1593ac8577bead240d2549c10b639df", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0506793228845158aa31be8aed1f7fa5f22dd091", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-----Styles created to manipulate the Carasousel and imagges as well-->
<style type=""text/css"">


    .carousel-inner > .carousel-item > img {
        padding-top: 35px;
        margin: auto;
        border-radius: 10px 10px 10px 10px;
        max-height: 500px;
        width: 750px;
        position: center;
    }



    .carousel-control.left, .carousel-control.right {
        background-image: none;
    }

    #carousel {
        margin: auto;
    }

    #carousel-example {
        margin: 0;
        position: absolute;
        top: 45%;
        left: 50%;
        margin-right: -50%;
        transform: translate(-50%, -50%)
    }
</style>

<!--------Id required to allow the carasousel to work by the bootstrap functions-->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7e4e5f4c1593ac8577bead240d2549c10b639df3883", async() => {
                WriteLiteral(@"
    <div id=""carousel-example"" class=""carousel slide"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#carousel-example"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#carousel-example"" data-slide-to=""1""></li>
            <li data-target=""#carousel-example"" data-slide-to=""2""></li> <!----Data targer attribute points to the id of the carasousel-->
            <li data-target=""#carousel-example"" data-slide-to=""3""></li>
            <li data-target=""#carousel-example"" data-slide-to=""4""></li>
        </ol>
        <div class=""carousel-inner"" role=""listbox"">
            <!----- Divs created to allow the carasousel to function with be active-->
            <div class=""carousel-item active"">
                <img src=""/Images/THe Joker2.jpg"" alt=""first slide""> <!---- Images internally sources at wwwroot/Images(Filename)-->
            </div>
            <div class=""carousel-item"">
                <img src=""/Images/John Wick.jpg"" alt=""second slide"">

   ");
                WriteLiteral(@"         </div>
            <div class=""carousel-item"">
                <img src=""/Images/1158102.jpg"" alt=""third slide"" />
            </div>
            <div class=""carousel-item"">
                <img src=""/Images/Jason Bourne.jpg"" alt=""fourth slide"">

            </div>
            <div class=""carousel-item"">
                <img src=""/Images/Thor.jpg"" alt=""fifth slide"">
            </div>


        </div>
        <a class=""left carousel-control"" href=""#carousel-example"" role=""button"" data-slide=""prev"">
            <span class=""icon-prev"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span> <!------Controls used to move between images-->
        </a>
        <a class=""right carousel-control"" href=""#carousel-example"" role=""button"" data-slide=""next"">
            <span class=""icon-next"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
