#pragma checksum "D:\WEBDEV FILES\Anna_ProjectFile\ClubBAIST_Project\GolfBAIST_Project\Pages\ManageApplication\SubmitApplication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f418fd3950e090ea5ff0d3dfa092d9645854649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GolfBAIST_Project.Pages.ManageApplication.Pages_ManageApplication_SubmitApplication), @"mvc.1.0.razor-page", @"/Pages/ManageApplication/SubmitApplication.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f418fd3950e090ea5ff0d3dfa092d9645854649", @"/Pages/ManageApplication/SubmitApplication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e63596aaabe2d4a6393da473a658e86936a10e0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ManageApplication_SubmitApplication : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Submit Application</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f418fd3950e090ea5ff0d3dfa092d96458546494179", async() => {
                WriteLiteral(@"
    <p>Personal Information</p>
    <div class=""col-md-6"">
        <label for=""firstName"" class=""form-label"">First Name</label>
        <input type=""text"" class=""form-control"" id=""firstName"">
    </div>
    <div class=""col-md-6"">
        <label for=""lastName"" class=""form-label"">Last Name</label>
        <input type=""text"" class=""form-control"" id=""lastName"">
    </div>
    <div class=""col-12"">
        <label for=""personalAddress"" class=""form-label"">Address</label>
        <input type=""text"" class=""form-control"" id=""personalAddress"" placeholder=""1234 Main St"">
    </div>
    <div class=""col-md-6"">
        <label for=""personalCity"" class=""form-label"">City</label>
        <input type=""text"" class=""form-control"" id=""personalCity"">
    </div>
    <div class=""col-md-4"">
        <label for=""personalProvince"" class=""form-label"">Province</label>
        <select id=""personalProvince"" class=""form-select"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f418fd3950e090ea5ff0d3dfa092d96458546495435", async() => {
                    WriteLiteral("Choose...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f418fd3950e090ea5ff0d3dfa092d96458546496787", async() => {
                    WriteLiteral("Alberta");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </select>
    </div>
    <div class=""col-md-2"">
        <label for=""personalPostalCode"" class=""form-label"">Postal Code</label>
        <input type=""text"" class=""form-control"" id=""personalPostalCode"">
    </div>
    <div class=""col-md-4"">
        <label for=""dob"" class=""form-label"">Date Of Birth</label>
        <input type=""date"" class=""form-control"" id=""dob"">
    </div>
    <div class=""col-md-4"">
        <label for=""phoneNumber"" class=""form-label"">Phone Number</label>
        <input type=""tel"" class=""form-control"" id=""phoneNumber"">
    </div>
    <div class=""col-md-4"">
        <label for=""email"" class=""form-label"">Email</label>
        <input type=""email"" class=""form-control"" id=""email"">
    </div>
    <p></p>
    <p>Company Information</p>
    <div class=""col-md-6"">
        <label for=""companyName"" class=""form-label"">Occupation</label>
        <input type=""text"" class=""form-control"" id=""occupation"">
    </div>
    <div class=""col-md-6"">
        <label for=""occupation"" class");
                WriteLiteral(@"=""form-label"">Last Name</label>
        <input type=""text"" class=""form-control"" id=""lastName"">
    </div>
    <div class=""col-12"">
        <label for=""companyAddress"" class=""form-label"">Address</label>
        <input type=""text"" class=""form-control"" id=""companyAddress"" placeholder=""1234 Main St"">
    </div>
    <div class=""col-md-6"">
        <label for=""companyCity"" class=""form-label"">City</label>
        <input type=""text"" class=""form-control"" id=""companyCity"">
    </div>
    <div class=""col-md-4"">
        <label for=""companyProvince"" class=""form-label"">Province</label>
        <select id=""companyProvince"" class=""form-select"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f418fd3950e090ea5ff0d3dfa092d96458546499629", async() => {
                    WriteLiteral("Choose...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f418fd3950e090ea5ff0d3dfa092d964585464910981", async() => {
                    WriteLiteral("Alberta");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </select>
    </div>
    <div class=""col-md-2"">
        <label for=""companyPostalCode"" class=""form-label"">Postal Code</label>
        <input type=""text"" class=""form-control"" id=""companyPostalCode"">
    </div>

    <div class=""col-md-4"">
        <label for=""phoneNumber"" class=""form-label"">Phone Number</label>
        <input type=""tel"" class=""form-control"" id=""phoneNumber"">
    </div>
    <p></p>
    <div class=""col-12"">
        <div class=""form-check"">
            <input class=""form-check-input"" type=""checkbox"" id=""personalInfoCheck"">
            <label class=""form-check-label"" for=""personalInfoCheck"">
                I hereby apply to become a Shareholder/Associate of Club of BAIST. If Seleted I agree to pay the annual dues and
                I also agree to become bound by the Memorandum and Articles of Association of Club BAIST, and the rules,
                regulations and By-laws of the Directors of Club BAIST, and all amendments thereto.
            </label>
        </div>");
                WriteLiteral(@"
    </div>
    <div class=""col-md-4"">
        <label for=""memberSignature"" class=""form-label"">Signature</label>
        <input type=""text"" class=""form-control"" id=""memberSignature"">
    </div>

    <div class=""col-md-4"">
        <label for=""memberSignatureDate"" class=""form-label"">Date</label>
        <input type=""date"" class=""form-control"" id=""memberSignatureDate"">
    </div>


    <p></p>
    <p>Reference Information</p>
    <div class=""col-12"">
        <div class=""form-check"">
            <input class=""form-check-input"" type=""checkbox"" id=""refCheck"">
            <label class=""form-check-label"" for=""refCheck"">
                The above named applicant is personally known to me, and I believe him/her to be a suitable persion to be slected
                as a member of Club BAIST.
            </label>
        </div>
    </div>
    <div class=""col-md-6"">
        <label for=""firstShareHolderName"" class=""form-label"">First Share Holder Name</label>
        <input type=""text"" class=""form");
                WriteLiteral(@"-control"" id=""firstShareHolderName"">
    </div>
    <div class=""col-md-6"">
        <label for=""secondShareHolderName"" class=""form-label"">Second Share Holder Name</label>
        <input type=""text"" class=""form-control"" id=""secondShareHolderName"">
    </div>

    <div class=""col-md-6"">
        <label for=""firstShareHolderDate"" class=""form-label"">Date</label>
        <input type=""date"" class=""form-control"" id=""firstShareHolderDate"">
    </div>
    <div class=""col-md-6"">
        <label for=""secondShareHolderDate"" class=""form-label"">Date</label>
        <input type=""date"" class=""form-control"" id=""secondShareHolderDate"">
    </div>
    <p></p>
    <p>PRIVACY INFORMATION</p>
    <div class=""col-12"">
        <div class=""form-check"">
            <input class=""form-check-input"" type=""checkbox"" id=""priCheck"">
            <label class=""form-check-label"" for=""priCheck"">
                The information you provide on this document is requested strictly to update our membership data and the
           ");
                WriteLiteral(@"     Membership Roster. This information will not be used for any other purpose except with your written permission
            </label>
        </div>
    </div>




    <div class=""col-12"">
        <button type=""submit"" class=""btn btn-primary"">Submit Application</button>
        <button type=""reset"" class=""btn btn-secondary"">Clear Application</button>
    </div>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GolfBAIST_Project.Pages.ManageApplication.SubmitApplicationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GolfBAIST_Project.Pages.ManageApplication.SubmitApplicationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GolfBAIST_Project.Pages.ManageApplication.SubmitApplicationModel>)PageContext?.ViewData;
        public GolfBAIST_Project.Pages.ManageApplication.SubmitApplicationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591