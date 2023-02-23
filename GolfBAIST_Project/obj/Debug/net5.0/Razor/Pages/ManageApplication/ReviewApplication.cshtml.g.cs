#pragma checksum "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbf5dc4f50574072a85de55f42b48333fb5f3ed7"
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
#line 1 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\_ViewImports.cshtml"
using GolfBAIST_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\_ViewImports.cshtml"
using GolfBAIST_Project.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbf5dc4f50574072a85de55f42b48333fb5f3ed7", @"/Pages/ManageApplication/ReviewApplication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e63596aaabe2d4a6393da473a658e86936a10e0", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_ManageApplication_ReviewApplication : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
  
    var message = (string)ViewData["MessageDescription"];


#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
 if (!string.IsNullOrWhiteSpace(message.ToString()))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"alert alert-success alert-dismissible fade show mb-5\" role=\"alert\">\r\n            ");
#nullable restore
#line 14 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
       Write(Html.Raw(message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 22 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
 if (Model.MemberApplications != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <table class=""table"">
            <thead>
                <tr>
                    <td>Application Id</td>
                    <td>Name</td>
                    <td></td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 34 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
                 foreach (var application in Model.MemberApplications)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
                       Write(application.ApplicationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
                       Write(application.MemberLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 38 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
                                                    Write(application.MemberFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1131, "\"", 1199, 2);
            WriteAttributeValue("", 1138, "/ManageApplication/EditApplication/", 1138, 35, true);
#nullable restore
#line 39 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
WriteAttributeValue("", 1173, application.ApplicationId, 1173, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 45 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <p>No Member Applications Were Found.</p>\r\n    </div>\r\n");
#nullable restore
#line 51 "C:\Users\ACChi\Documents\GitHub\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\ReviewApplication.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GolfBAIST_Project.Pages.ManageApplication.ReviewApplicationModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GolfBAIST_Project.Pages.ManageApplication.ReviewApplicationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GolfBAIST_Project.Pages.ManageApplication.ReviewApplicationModel>)PageContext?.ViewData;
        public GolfBAIST_Project.Pages.ManageApplication.ReviewApplicationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
