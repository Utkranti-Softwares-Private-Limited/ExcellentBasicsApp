#pragma checksum "C:\Users\AmY\source\repos\ExcellentBasicsApp\ExcllentBacisApp\ExcllentBacisApp\Views\Admin\Diary1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd75e72a4c7b11fd63245e58f53ff73be10226ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Diary1), @"mvc.1.0.view", @"/Views/Admin/Diary1.cshtml")]
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
#line 1 "C:\Users\AmY\source\repos\ExcellentBasicsApp\ExcllentBacisApp\ExcllentBacisApp\Views\_ViewImports.cshtml"
using ExcllentBacisApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AmY\source\repos\ExcellentBasicsApp\ExcllentBacisApp\ExcllentBacisApp\Views\_ViewImports.cshtml"
using ExcllentBacisApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd75e72a4c7b11fd63245e58f53ff73be10226ef", @"/Views/Admin/Diary1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff22ff92511992dde5bcfd350226f9b8bbc7469", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Diary1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\AmY\source\repos\ExcellentBasicsApp\ExcllentBacisApp\ExcllentBacisApp\Views\Admin\Diary1.cshtml"
  
    ViewData["Title"] = "Diary1";
    Layout = "~/Views/Shared/layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row m-0"">
    <div class=""col-md-12 ml-5"">
        <label id=""lbname"" class=""ml-5""><span style=""text-align:center""><h5>Naresh saini</h5></span></label>
        <label id=""lbname"" class=""ml-5""><span>Class X A</span></label>




    </div>




    <div class="" col-md-12 mt-3 m-3"">
        <center>

            <h6>Teacher Name</h6>

            <select id="" ddlteachername"" typeof=""text"" style=""width:190px;height:35px"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd75e72a4c7b11fd63245e58f53ff73be10226ef3954", async() => {
                WriteLiteral("Naresh Saini");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd75e72a4c7b11fd63245e58f53ff73be10226ef4934", async() => {
                WriteLiteral("Amit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </select>
        </center>
    </div>



</div>
<div class=""row m-0 mt-4"">
    <div class=""ml-5"">
        <h6>From</h6>

        <input id=""txtfrom"" type=""date"" />
    </div>

    <div class="" ml-5"">
        <h6>To</h6>

        <input id=""txtto"" type=""date"" />
    </div>
</div>

<div class=""row m-3 mt-5"">
    <div class=""ml-3"">
        <center><h6>SNo.</h6> </center>
        <center>1</center>
        <center> 2 </center>
        <center> 3</center>
        <center> 4 </center>
    </div>
    <div class=""ml-2"">
        <center><h6>Date</h6> </center>
        <center> <input id=""txtto"" type=""date"" /></center>
        <center> <input id=""txtto"" type=""date"" /> </center>
        <center>  <input id=""txtto"" type=""date"" /></center>
        <center>  <input id=""txtto"" type=""date"" /></center>

    </div>

    <div class=""ml-4"">

        <center><h6>Teacher</h6> </center>
        <a href=""#"">
            <center><h6>Massage</h6> </center>
        </a>
       ");
            WriteLiteral(@" <a href=""#"">
            <center><h6>Massage</h6> </center>
        </a>
        <a href=""#"">
            <center><h6>Massage</h6> </center>
        </a>
        <a href=""#"">
            <center><h6>Massage</h6> </center>

        </a>
    </div>

    <div class=""ml-3"">
        <center><h6>Parents</h6></center>
        <a href=""#"">
            <center><h6>Massage</h6> </center>
        </a>
        <a href=""#"">
            <center><h6>Massage</h6> </center>
        </a>
        <a href=""#"">
            <center><h6>Massage</h6> </center>
        </a>
        <a href=""#"">
            <center><h6>Massage</h6> </center>
        </a>
    </div>

</div>


<br />


");
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
