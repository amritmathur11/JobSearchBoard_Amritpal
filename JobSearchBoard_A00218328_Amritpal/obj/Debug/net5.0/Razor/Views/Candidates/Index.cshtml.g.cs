#pragma checksum "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8135ba711547fde85c9379155f92967dd65e66ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidates_Index), @"mvc.1.0.view", @"/Views/Candidates/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8135ba711547fde85c9379155f92967dd65e66ed", @"/Views/Candidates/Index.cshtml")]
    public class Views_Candidates_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JobSearchBoard_A00218328_Amritpal.Models.Candidate>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.District));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.KeySkills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 52 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.District));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.KeySkills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2569, "\"", 2592, 1);
#nullable restore
#line 88 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
WriteAttributeValue("", 2584, item.ID, 2584, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2645, "\"", 2668, 1);
#nullable restore
#line 89 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
WriteAttributeValue("", 2660, item.ID, 2660, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2723, "\"", 2746, 1);
#nullable restore
#line 90 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
WriteAttributeValue("", 2738, item.ID, 2738, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 93 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Candidates\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JobSearchBoard_A00218328_Amritpal.Models.Candidate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
