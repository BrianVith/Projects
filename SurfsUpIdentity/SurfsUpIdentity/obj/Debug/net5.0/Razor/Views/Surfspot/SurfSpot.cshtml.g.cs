#pragma checksum "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59cab9905c6b903308b20dacdca3688b1e8bf547"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Surfspot_SurfSpot), @"mvc.1.0.view", @"/Views/Surfspot/SurfSpot.cshtml")]
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
#nullable restore
#line 1 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
using SurfsUpIdentity.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59cab9905c6b903308b20dacdca3688b1e8bf547", @"/Views/Surfspot/SurfSpot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d08d4fa350d07a0df3f39a5e55341dac0779c26", @"/Views/_ViewImports.cshtml")]
    public class Views_Surfspot_SurfSpot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SurfsUpIdentity.ViewModels.SurfSpotViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<section class=\"single-page-header\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <h2>");
#nullable restore
#line 8 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<div class=\"text-center m-4\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "59cab9905c6b903308b20dacdca3688b1e8bf5474894", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 376, "~/Upload/", 376, 9, true);
#nullable restore
#line 15 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
AddHtmlAttributeValue("", 385, Model.ImagePath, 385, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n<div>\r\n\r\n\r\n</div>\r\n    <div class=\"text-center\">\r\n");
#nullable restore
#line 23 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
         if (Model.IsNice)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <H2>Forholdendene virker gode for at surfe</H2>\r\n");
#nullable restore
#line 26 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Forholdendene virker dårlige for surfing</h2>\r\n");
#nullable restore
#line 30 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>

<div class=""row justify-content-center mb-4"" style=""width: 100vw"">
    <div class=""col-auto"">

        <table class=""table table-responsive text-center"">
            <tr>
                <th scope=""col"">Tid</th>
                <th scope=""col"">Temperatur °C</th>
                <th scope=""col"">Bølgehøjde m</th>
                <th scope=""col"">Vandtemperatur °C</th>
                <th scope=""col"">Vindstyrke</th>
                <th scope=""col"">Bølgeperiode sek</th>
                <th scope=""col"">Vindhastighed m/s</th>
            </tr>
");
#nullable restore
#line 46 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
             foreach (var hour in Model.weatherData.Hours)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\">");
#nullable restore
#line 49 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                               Write(hour.Time.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Math.Round(hour.AirTemperature.Noaa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(hour.WaveHeight.Noaa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Math.Round(hour.WaterTemperature.Noaa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Math.Round(hour.Gust.Noaa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Math.Round(hour.WavePeriod.Noaa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 55 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Math.Round(hour.WindSpeed.Noaa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 57 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n</div>\r\n<div class=\"container mt-30\">\r\n\r\n    <div class=\"col-10 mt-50\" style=\"width:50vw\">\r\n        <h2 class=\"text-center mt-8\">Beskriv din oplevelse</h2>\r\n");
#nullable restore
#line 66 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
         using (Html.BeginForm("SubmitReview", "SurfSpot", FormMethod.Post, new { enctype = "multipart/form-data" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n\r\n                <div class=\"col\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 72 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Html.LabelFor(x => x.SpotReview.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 73 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Html.TextBoxFor(x => x.SpotReview.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 76 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Html.LabelFor(x => x.SpotReview.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 77 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Html.TextAreaFor(x => x.SpotReview.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 80 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Html.LabelFor(x => x.SpotReview.NumberOfPeople));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 81 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Html.TextAreaFor(x => x.SpotReview.NumberOfPeople, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 84 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Html.LabelFor(x => x.SpotReview.WaveQuality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 85 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Html.DropDownListFor(x => x.SpotReview.WaveQuality, new SelectList(Enum.GetValues(typeof(WaveQuality))), "Vælg bølgekvailitet", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group \">\r\n                        ");
#nullable restore
#line 88 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Html.LabelFor(x => x.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 89 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Html.TextBoxFor(x => x.Image, new { Type = "file", @multiple = "multiple", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 90 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        <div hidden=\"hidden\"> ");
#nullable restore
#line 93 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                                         Write(Html.HiddenFor(x => x.SpotID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <button type=\"submit\" class=\"p-2 btn-primary mb-2\">Send Kommentar</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 98 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"container mt-50\">\r\n        \r\n    <div>\r\n");
#nullable restore
#line 104 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
         if (Model.Reviews != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"col-10\">Hvad siger andre om spottet?</h2>\r\n");
#nullable restore
#line 108 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
             foreach (var review in Model.Reviews)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"mb-5 card\">\r\n                    <div class=\"card-header text-center\">\r\n                        <h3 style=\"font-size: medium\">");
#nullable restore
#line 112 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                                                 Write(review.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <h6>Beskrivelse:</h6> ");
#nullable restore
#line 115 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                                         Write(review.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        <h6>Antal mennesker på stranden:</h6>");
#nullable restore
#line 116 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                                                        Write(review.NumberOfPeople);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        <h6>Bølgekvalitet:</h6>");
#nullable restore
#line 117 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                                          Write(review.WaveQuality);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "59cab9905c6b903308b20dacdca3688b1e8bf54718781", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4709, "~/Upload/", 4709, 9, true);
#nullable restore
#line 118 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
AddHtmlAttributeValue("", 4718, review.Image, 4718, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"card-footer\">\r\n                        <p class=\"float-right\" style=\"color:darkgray\">");
#nullable restore
#line 121 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
                                                                 Write(review.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 124 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Surfspot\SurfSpot.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SurfsUpIdentity.ViewModels.SurfSpotViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
