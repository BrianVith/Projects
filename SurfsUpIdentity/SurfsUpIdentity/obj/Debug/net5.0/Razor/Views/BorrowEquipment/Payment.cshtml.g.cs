#pragma checksum "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\BorrowEquipment\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a0bd7c8d5f83241b5faf71b46276065bcba345e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BorrowEquipment_Payment), @"mvc.1.0.view", @"/Views/BorrowEquipment/Payment.cshtml")]
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
#line 1 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\_ViewImports.cshtml"
using SurfsUpIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\_ViewImports.cshtml"
using SurfsUpIdentity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\_ViewImports.cshtml"
using SurfsUpIdentity.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a0bd7c8d5f83241b5faf71b46276065bcba345e", @"/Views/BorrowEquipment/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d08d4fa350d07a0df3f39a5e55341dac0779c26", @"/Views/_ViewImports.cshtml")]
    public class Views_BorrowEquipment_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SurfsUpIdentity.Models.Equipment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" height: 450px; width: auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("No image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""single-page-header"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h2>Lej Vandsportsudstyr</h2>
            </div>
        </div>
    </div>
</section>

<div class=""text-center mt-30"">


    <h4 class=""mt-30"">");
#nullable restore
#line 16 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\BorrowEquipment\Payment.cshtml"
                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a0bd7c8d5f83241b5faf71b46276065bcba345e5109", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 428, "~/Upload/", 428, 9, true);
#nullable restore
#line 18 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\BorrowEquipment\Payment.cshtml"
AddHtmlAttributeValue("", 437, Model.Pictures, 437, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n    <h4 class=\"mt-30\">Tilstand: ");
#nullable restore
#line 21 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\BorrowEquipment\Payment.cshtml"
                           Write(Model.Condition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n    <h4 class=\"mt-30\">Type: ");
#nullable restore
#line 23 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\BorrowEquipment\Payment.cshtml"
                       Write(Model.BoardType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n    <h4 class=\"mt-30\">Beskrivelse</h4>\r\n    <p class=\"mt-30\">\r\n        ");
#nullable restore
#line 27 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\BorrowEquipment\Payment.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n\r\n    <h4 class=\"mt-30\">");
#nullable restore
#line 30 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\BorrowEquipment\Payment.cshtml"
                 Write(Model.User.City.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n    <h4 class=\"mt-30\">");
#nullable restore
#line 32 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\BorrowEquipment\Payment.cshtml"
                 Write(Model.User.City.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n    <h4 class=\"mt-30\">");
#nullable restore
#line 34 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\BorrowEquipment\Payment.cshtml"
                 Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n    <h4 class=\"mt-30\">");
#nullable restore
#line 36 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\BorrowEquipment\Payment.cshtml"
                 Write(Model.Deposit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n</div>\r\n\r\n<div class=\"border\"></div>\r\n\r\n<div class=\"container text-center\">\r\n    <button class=\"PaymentButton mt-30\" style=\"margin-bottom:30px\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1035, "\'", 1124, 3);
            WriteAttributeValue("", 1045, "window.location.href=\"", 1045, 22, true);
#nullable restore
#line 43 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\BorrowEquipment\Payment.cshtml"
WriteAttributeValue("", 1067, Url.Action("LenderInfo", "BorrowEquipment", Model.User), 1067, 56, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1123, "\"", 1123, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Betal!</button>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SurfsUpIdentity.Models.Equipment> Html { get; private set; }
    }
}
#pragma warning restore 1591
