#pragma checksum "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c175bd7cfea81b05d023729f1b8e0e7ee38bdee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Posting_Index), @"mvc.1.0.view", @"/Views/Job_Posting/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c175bd7cfea81b05d023729f1b8e0e7ee38bdee", @"/Views/Job_Posting/Index.cshtml")]
    public class Views_Job_Posting_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JobSearchBoard_A00218328_Amritpal.Models.Job_Posting>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Jobtitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobSkills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PostingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Jobtitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobSkills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PostingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1425, "\"", 1448, 1);
#nullable restore
#line 52 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
WriteAttributeValue("", 1440, item.ID, 1440, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1501, "\"", 1524, 1);
#nullable restore
#line 53 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
WriteAttributeValue("", 1516, item.ID, 1516, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1579, "\"", 1602, 1);
#nullable restore
#line 54 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
WriteAttributeValue("", 1594, item.ID, 1594, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Job_Posting\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JobSearchBoard_A00218328_Amritpal.Models.Job_Posting>> Html { get; private set; }
    }
}
#pragma warning restore 1591