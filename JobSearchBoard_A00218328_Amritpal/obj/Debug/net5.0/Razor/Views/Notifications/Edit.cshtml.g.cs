#pragma checksum "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Notifications\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "069aa51fdeaee05e782e9182ae7bf30d595feaa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notifications_Edit), @"mvc.1.0.view", @"/Views/Notifications/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"069aa51fdeaee05e782e9182ae7bf30d595feaa3", @"/Views/Notifications/Edit.cshtml")]
    public class Views_Notifications_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobSearchBoard_A00218328_Amritpal.Models.Notification>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Notifications\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Notification</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""ID"" />
            <div class=""form-group"">
                <label asp-for=""EmployerId"" class=""control-label""></label>
                <input asp-for=""EmployerId"" class=""form-control"" />
                <span asp-validation-for=""EmployerId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""JobId"" class=""control-label""></label>
                <input asp-for=""JobId"" class=""form-control"" />
                <span asp-validation-for=""JobId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NotificationText"" class=""control-label""></label>
                <input asp-for=""NotificationText"" class=""form-control"" />
           ");
            WriteLiteral(@"     <span asp-validation-for=""NotificationText"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ReadCount"" class=""control-label""></label>
                <input asp-for=""ReadCount"" class=""form-control"" />
                <span asp-validation-for=""ReadCount"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Notifications\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobSearchBoard_A00218328_Amritpal.Models.Notification> Html { get; private set; }
    }
}
#pragma warning restore 1591
