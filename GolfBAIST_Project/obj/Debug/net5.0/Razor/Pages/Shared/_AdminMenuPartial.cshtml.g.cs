#pragma checksum "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\Shared\_AdminMenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d07c6c3d5fd1790904d405d702885bf9ae974bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GolfBAIST_Project.Pages.Shared.Pages_Shared__AdminMenuPartial), @"mvc.1.0.view", @"/Pages/Shared/_AdminMenuPartial.cshtml")]
namespace GolfBAIST_Project.Pages.Shared
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
#line 1 "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\Shared\_AdminMenuPartial.cshtml"
using Microsoft.AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\Shared\_AdminMenuPartial.cshtml"
using GolfBAIST_Project.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d07c6c3d5fd1790904d405d702885bf9ae974bb", @"/Pages/Shared/_AdminMenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e63596aaabe2d4a6393da473a658e86936a10e0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__AdminMenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\Shared\_AdminMenuPartial.cshtml"
     if (SignInManager.IsSignedIn(User) && await UserManager.IsInRoleAsync(UserManager.GetUserAsync(User).Result,"admin")){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <li class=""nav-item dropdown show"">
            <a class=""dropdown-toggle nav-link text-dark"" href=""#"" data-toggle = ""dropdown"">Admin</a>

            <div class=""dropdown-menu"">
                <a class=""dropdown-item"" href=""#"">1</a>
                <a class=""dropdown-item"" href=""#"">2</a>
                <a class=""dropdown-item"" href=""#"">3</a>
            </div>
        </li>
");
#nullable restore
#line 17 "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\Shared\_AdminMenuPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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
