#pragma checksum "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "379edb992e7ac6634b4430e552a06911533b5e90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"379edb992e7ac6634b4430e552a06911533b5e90", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d08d4fa350d07a0df3f39a5e55341dac0779c26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""single-page-header"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h2>Kontakt os</h2>
                
            </div>
        </div>
    </div>
</section>

<!--Start Contact Us-->
<section class=""contact-us"" id=""contact"">
    <div class=""container"">
        <div class=""row"">

            <div class=""contact-details col-md-6 "">
                <h3>Kontakt Formular</h3>

");
#nullable restore
#line 21 "C:\Users\brian\Desktop\git\surfupreloaded\SurfsUpIdentity\SurfsUpIdentity\Views\Home\Contact.cshtml"
                  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
				<section class=""single-page-header"">
					<div class=""container"">
						<div class=""row"">
							<div class=""col-md-12"">
								<h2>Kontakt os</h2>
								
							</div>
						</div>
					</div>
				</section>

				 <!--Start Contact Us -->		
				<section class=""contact-us"" id=""contact"">
					<div class=""container"">
						<div class=""row"">
			
			
							<!-- Contact Details -->
							<div class=""contact-details col-md-12 "" >
								<h3>Kontakt Information</h3>
								<p>Ved spørgsmål kan vi kontaktes enten via kontaktformularen på siden, eller via mail/telefon som ses herunder.</p>
								<ul class=""contact-short-info"">
									<li>
										<i class=""tf-ion-android-home""></i>
										<span>Adresse: University College Lillebælt, Seebladsgade 1, 5000 Odense</span>
									</li>
									<li>
										<i class=""tf-ion-android-phone-portrait""></i>
										<span>Telefon: +45 12 34 56 78</span>
									</li>
									<li>
										<i class=""tf-ion-android-mail""");
            WriteLiteral(@"></i>
										<span>Email: Surfsup@mail.com</span>
									</li>
								</ul>

							</div>
							<!-- / End Contact Details -->
           

						</div> <!-- end row -->
					</div> <!-- end container -->
				</section> <!-- end section -->

				<!-- Footer Social Links -->
				<div class=""social-icon"">
					<ul>
						<li><a href=""#!""><i class=""tf-ion-social-facebook""></i></a></li>
						<li><a href=""#!""><i class=""tf-ion-social-twitter""></i></a></li>
						<li><a href=""#!""><i class=""tf-ion-social-dribbble-outline""></i></a></li>
						<li><a href=""#!""><i class=""tf-ion-social-linkedin-outline""></i></a></li>
					</ul>
				</div>
				<!--/. End Footer Social Links -->
			</div>
			<!-- / End Contact Details -->
				
			<!-- Contact Form -->
			<div class=""contact-form col-md-6 "" >
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "379edb992e7ac6634b4430e552a06911533b5e907166", async() => {
                WriteLiteral(@"
					<div class=""form-group"">
						<input type=""text"" placeholder=""Dit navn"" class=""form-control"" name=""name"" id=""name"">
					</div>
					
					<div class=""form-group"">
						<input type=""email"" placeholder=""Din Email"" class=""form-control"" name=""email"" id=""email"">
					</div>
					
					<div class=""form-group"">
						<input type=""text"" placeholder=""Emne"" class=""form-control"" name=""subject"" id=""subject"">
					</div>
					
					<div class=""form-group"">
						<textarea rows=""6"" placeholder=""Besked"" class=""form-control"" name=""message"" id=""message""></textarea>	
					</div>
					
					<div id=""success"" class=""success"">
						Thank you. The Mailman is on His Way :)
					</div>
					
					<div id=""error"" class=""error"">
						Sorry, don't know what happened. Try later :(
					</div>
					<div id=""cf-submit"">
						<input type=""submit"" id=""contact-submit"" class=""btn btn-transparent"" value=""Send"">
					</div>						
					
				");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<!-- ./End Contact Form -->\r\n\t\t\r\n\t\t</div> <!-- end row -->\r\n\t</div> <!-- end container -->\r\n</section> <!-- end section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
