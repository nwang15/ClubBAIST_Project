#pragma checksum "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6733f4e70a2a046031152fb4ac2f93c18c1ca4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GolfBAIST_Project.Pages.ManageApplication.Pages_ManageApplication_ReviewApplication), @"mvc.1.0.razor-page", @"/Pages/ManageApplication/ReviewApplication.cshtml")]
namespace GolfBAIST_Project.Pages.ManageApplication
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
#line 1 "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\_ViewImports.cshtml"
using GolfBAIST_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\_ViewImports.cshtml"
using GolfBAIST_Project.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6733f4e70a2a046031152fb4ac2f93c18c1ca4b", @"/Pages/ManageApplication/ReviewApplication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e63596aaabe2d4a6393da473a658e86936a10e0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ManageApplication_ReviewApplication : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <td>Application Id</td>\r\n                <td>Name</td>\r\n                <td></td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 17 "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
             foreach (var application in Model.memberApplications)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 20 "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
                   Write(application.ApplicationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
                   Write(application.MemberLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 21 "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
                                                Write(application.MemberFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 618, "\"", 686, 2);
            WriteAttributeValue("", 625, "/ManageApplication/EditApplication/", 625, 35, true);
#nullable restore
#line 22 "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
WriteAttributeValue("", 660, application.ApplicationId, 660, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 24 "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GolfBAIST_Project.Pages.ManageApplication.ReviewApplicationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GolfBAIST_Project.Pages.ManageApplication.ReviewApplicationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GolfBAIST_Project.Pages.ManageApplication.ReviewApplicationModel>)PageContext?.ViewData;
        public GolfBAIST_Project.Pages.ManageApplication.ReviewApplicationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
