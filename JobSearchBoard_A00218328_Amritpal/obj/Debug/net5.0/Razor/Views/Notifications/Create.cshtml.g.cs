#pragma checksum "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Notifications\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "400c9cc7752cdc3b2dd81cb35705834b32a4762d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notifications_Create), @"mvc.1.0.view", @"/Views/Notifications/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"400c9cc7752cdc3b2dd81cb35705834b32a4762d", @"/Views/Notifications/Create.cshtml")]
    public class Views_Notifications_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobSearchBoard_A00218328_Amritpal.Models.Notification>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Notifications\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Notification</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
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
                <span asp-validation-for=""NotificationTex");
            WriteLiteral(@"t"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ReadCount"" class=""control-label""></label>
                <input asp-for=""ReadCount"" class=""form-control"" />
                <span asp-validation-for=""ReadCount"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
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
#line 47 "C:\Web development\JobSearchBoard_A00218328_Amritpal\JobSearchBoard_A00218328_Amritpal\Views\Notifications\Create.cshtml"
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
