#pragma checksum "C:\Users\ROBLES\OneDrive\Escritorio\Lenguajes Aplicaciones Comerciales\Primer Proyecto\Primer_Proyecto\Primer_Proyecto\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cb64ec6b990abbe00d55830733f6f35fe1a70e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\ROBLES\OneDrive\Escritorio\Lenguajes Aplicaciones Comerciales\Primer Proyecto\Primer_Proyecto\Primer_Proyecto\Views\_ViewImports.cshtml"
using Primer_Proyecto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ROBLES\OneDrive\Escritorio\Lenguajes Aplicaciones Comerciales\Primer Proyecto\Primer_Proyecto\Primer_Proyecto\Views\_ViewImports.cshtml"
using Primer_Proyecto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cb64ec6b990abbe00d55830733f6f35fe1a70e9", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0bfcf4c1b59b0c48de5e8536e47d23441cb2e24", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cb64ec6b990abbe00d55830733f6f35fe1a70e93459", async() => {
                WriteLiteral("\r\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
#nullable restore
#line 7 "C:\Users\ROBLES\OneDrive\Escritorio\Lenguajes Aplicaciones Comerciales\Primer Proyecto\Primer_Proyecto\Primer_Proyecto\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Mi aplicación ASP.NET</title>\r\n    <!--arrobaStyles.Render(\"~/wwwroot/css\")-->\r\n    <!--arrobaScripts.Render(\"~/bundles/modernizr\")--> \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cb64ec6b990abbe00d55830733f6f35fe1a70e95074", async() => {
                WriteLiteral(@"
    <div class=""navbar navbar-inverse navbar-fixed-top"">
        <div class=""container"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                ");
#nullable restore
#line 20 "C:\Users\ROBLES\OneDrive\Escritorio\Lenguajes Aplicaciones Comerciales\Primer Proyecto\Primer_Proyecto\Primer_Proyecto\Views\Shared\_Layout.cshtml"
           Write(Html.ActionLink("Nombre de la aplicación", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"nav navbar-nav\">\r\n                    <li>");
#nullable restore
#line 24 "C:\Users\ROBLES\OneDrive\Escritorio\Lenguajes Aplicaciones Comerciales\Primer Proyecto\Primer_Proyecto\Primer_Proyecto\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Inicio", "Index", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 25 "C:\Users\ROBLES\OneDrive\Escritorio\Lenguajes Aplicaciones Comerciales\Primer Proyecto\Primer_Proyecto\Primer_Proyecto\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Acerca de", "About", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 26 "C:\Users\ROBLES\OneDrive\Escritorio\Lenguajes Aplicaciones Comerciales\Primer Proyecto\Primer_Proyecto\Primer_Proyecto\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Contacto", "Contact", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"container body-content\">\r\n        ");
#nullable restore
#line 32 "C:\Users\ROBLES\OneDrive\Escritorio\Lenguajes Aplicaciones Comerciales\Primer Proyecto\Primer_Proyecto\Primer_Proyecto\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <hr />\r\n        <footer>\r\n        </footer>\r\n    </div>\r\n\r\n    <!--arroba Scripts.Render(\"~/bundles/jquery\")-->\r\n    <!--arroba Scripts.Render(\"~/bundles/bootstrap\")-->\r\n    <!--arroba RenderSection(\"scripts\", required: false)-->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </html>\r\n");
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
