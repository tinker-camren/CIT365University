#pragma checksum "C:\Users\CNTin\source\repos\CIT365University\University\University\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26dabbf208ba2dbae0373d3f191368dffbc13f25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\CNTin\source\repos\CIT365University\University\University\Views\_ViewImports.cshtml"
using University;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CNTin\source\repos\CIT365University\University\University\Views\_ViewImports.cshtml"
using University.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26dabbf208ba2dbae0373d3f191368dffbc13f25", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e04dcc244e1469154104359d31508023c653ccb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<University.Models.SchoolViewModels.EnrollmentDateGroup>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\CNTin\source\repos\CIT365University\University\University\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Student Body Statistics";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-center\">Student Body Statistics</h2>\r\n\r\n<table class=\"ml-2\">\r\n    <tr>\r\n        <th>\r\n            Enrollment Date\r\n        </th>\r\n        <th>\r\n            Students\r\n        </th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\CNTin\source\repos\CIT365University\University\University\Views\Home\About.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 23 "C:\Users\CNTin\source\repos\CIT365University\University\University\Views\Home\About.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "C:\Users\CNTin\source\repos\CIT365University\University\University\Views\Home\About.cshtml"
           Write(item.StudentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\CNTin\source\repos\CIT365University\University\University\Views\Home\About.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<section class=\"pl-2\">\r\n    <h2 class=\"text-center\">Contact Info</h2>\r\n    <p>Name: Camren Tinker</p>\r\n    <p>Email Address: <a href=\"mailto:tin16004@byui.edu\">tin16004@byui.edu</a></p>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<University.Models.SchoolViewModels.EnrollmentDateGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
