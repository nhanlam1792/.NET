#pragma checksum "E:\TEDU_OJT_2024\UserManagementWithIdentity\UserManagementWithIdentity\UserManagementWithIdentity\Areas\Identity\Pages\Account\Manage\_Layout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0d14d3b1d1222727b1fb9ec5c9a9f7af81820acddcdc410fcfdec24e88f49426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage__Layout), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
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

#nullable disable
    ;
#nullable restore
#line 1 "E:\TEDU_OJT_2024\UserManagementWithIdentity\UserManagementWithIdentity\UserManagementWithIdentity\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using UserManagementWithIdentity.Areas.Identity.Pages.Account.Manage

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0d14d3b1d1222727b1fb9ec5c9a9f7af81820acddcdc410fcfdec24e88f49426", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9ac9e4dfceaee7a247d8eb07af68e1c4808396559855df574d20707fb0ea3636", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4e8f4c1d0a8a9ed922811cfe18792e0190de920f9710762431b28ccd3a2537a4", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3194fcf1ff0893ca1d967c2d62349c6b06ad7ae52c57da6d499a632af4552c83", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ManageNav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\TEDU_OJT_2024\UserManagementWithIdentity\UserManagementWithIdentity\UserManagementWithIdentity\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
  
    if (ViewData.TryGetValue("ParentLayout", out var parentLayout))
    {
        Layout = (string)parentLayout;
    }
    else
    {
        Layout = "/Areas/Identity/Pages/_Layout.cshtml";
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h2>Manage your account</h2>\r\n\r\n<div>\r\n    <h4>Change your account settings</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0d14d3b1d1222727b1fb9ec5c9a9f7af81820acddcdc410fcfdec24e88f494265971", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            ");
            Write(
#nullable restore
#line 22 "E:\TEDU_OJT_2024\UserManagementWithIdentity\UserManagementWithIdentity\UserManagementWithIdentity\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
             RenderBody()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                Write(
#nullable restore
#line 28 "E:\TEDU_OJT_2024\UserManagementWithIdentity\UserManagementWithIdentity\UserManagementWithIdentity\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
     RenderSection("Scripts", required: false)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
