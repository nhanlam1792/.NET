#pragma checksum "E:\TEDU_OJT_2024\UserManagementWithIdentity\UserManagementWithIdentity\UserManagementWithIdentity\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9c98bf70624ebf9969770c8202e0f00ed516822a0116134a8c06d6a6e7dedd54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\TEDU_OJT_2024\UserManagementWithIdentity\UserManagementWithIdentity\UserManagementWithIdentity\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 2 "E:\TEDU_OJT_2024\UserManagementWithIdentity\UserManagementWithIdentity\UserManagementWithIdentity\Areas\Identity\Pages\_ViewImports.cshtml"
using UserManagementWithIdentity.Areas.Identity

#nullable disable
    ;
#nullable restore
#line 3 "E:\TEDU_OJT_2024\UserManagementWithIdentity\UserManagementWithIdentity\UserManagementWithIdentity\Areas\Identity\Pages\_ViewImports.cshtml"
using UserManagementWithIdentity.Areas.Identity.Pages

#nullable disable
    ;
#nullable restore
#line 4 "E:\TEDU_OJT_2024\UserManagementWithIdentity\UserManagementWithIdentity\UserManagementWithIdentity\Areas\Identity\Pages\_ViewImports.cshtml"
using UserManagementWithIdentity.Models

#nullable disable
    ;
#nullable restore
#line 1 "E:\TEDU_OJT_2024\UserManagementWithIdentity\UserManagementWithIdentity\UserManagementWithIdentity\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using UserManagementWithIdentity.Areas.Identity.Pages.Account

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9c98bf70624ebf9969770c8202e0f00ed516822a0116134a8c06d6a6e7dedd54", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9ac9e4dfceaee7a247d8eb07af68e1c4808396559855df574d20707fb0ea3636", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4e8f4c1d0a8a9ed922811cfe18792e0190de920f9710762431b28ccd3a2537a4", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\TEDU_OJT_2024\UserManagementWithIdentity\UserManagementWithIdentity\UserManagementWithIdentity\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>");
            Write(
#nullable restore
#line 7 "E:\TEDU_OJT_2024\UserManagementWithIdentity\UserManagementWithIdentity\UserManagementWithIdentity\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
     ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n");
            WriteLiteral("    <p>\r\n        Please check your email to confirm your account.\r\n    </p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591