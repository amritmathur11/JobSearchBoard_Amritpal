#pragma checksum "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Resumes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa3fe1d459d5375a17ad1872ba21102b2f81f0f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resumes_Details), @"mvc.1.0.view", @"/Views/Resumes/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa3fe1d459d5375a17ad1872ba21102b2f81f0f9", @"/Views/Resumes/Details.cshtml")]
    public class Views_Resumes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobSearchBoard_A00218328_Amritpal.Models.Resume>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Resumes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Resume</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Resumes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ResName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Resumes\Details.cshtml"
       Write(Html.DisplayFor(model => model.ResName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Resumes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Resumes\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Resumes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Resumes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Resumes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Resumes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1077, "\"", 1101, 1);
#nullable restore
#line 40 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Resumes\Details.cshtml"
WriteAttributeValue("", 1092, Model.ID, 1092, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobSearchBoard_A00218328_Amritpal.Models.Resume> Html { get; private set; }
    }
}
#pragma warning restore 1591