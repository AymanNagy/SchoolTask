#pragma checksum "C:\Users\Ayman Nagy\Desktop\School\School\Views\SchoolClass\ListOfSchool.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "096afb19bf1d7d0b24dd845c59cf2740d6a4e84b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SchoolClass_ListOfSchool), @"mvc.1.0.view", @"/Views/SchoolClass/ListOfSchool.cshtml")]
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
#line 1 "C:\Users\Ayman Nagy\Desktop\School\School\Views\_ViewImports.cshtml"
using School.Models.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ayman Nagy\Desktop\School\School\Views\_ViewImports.cshtml"
using School.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"096afb19bf1d7d0b24dd845c59cf2740d6a4e84b", @"/Views/SchoolClass/ListOfSchool.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02f51d2095af8f38ebd7100218807e4ba28960c6", @"/Views/_ViewImports.cshtml")]
    public class Views_SchoolClass_ListOfSchool : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<School.Models.ViewModel.SchoolClassViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ayman Nagy\Desktop\School\School\Views\SchoolClass\ListOfSchool.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12 mb-3\">\r\n        <input type=\"text\" id=\"myFilter\" class=\"form-control\" onkeyup=\"myFunction()\" placeholder=\"Search for names..\">\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"row\" id=\"myItems\">\r\n\r\n\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Ayman Nagy\Desktop\School\School\Views\SchoolClass\ListOfSchool.cshtml"
     foreach (var School in Model.ListOfSchools)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card card-info col-sm-3"" style=""margin:10px; padding:0"">
                <div class=""card-header"">
                    <h3 class=""card-title"">School</h3>
                </div>
                <div class=""card-body"">
                    Name : ");
#nullable restore
#line 24 "C:\Users\Ayman Nagy\Desktop\School\School\Views\SchoolClass\ListOfSchool.cshtml"
                      Write(School.SchoolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\Ayman Nagy\Desktop\School\School\Views\SchoolClass\ListOfSchool.cshtml"
               Write(Html.ActionLink("View", "ListOfClass", "SchoolClass", new { SchoolID = School.SchoolID }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 30 "C:\Users\Ayman Nagy\Desktop\School\School\Views\SchoolClass\ListOfSchool.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<School.Models.ViewModel.SchoolClassViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
