#pragma checksum "C:\Users\HP\source\repos\yazlab2\yazlab2\Views\Login\_MessageLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6c272bee20e1ddea24edcdac1939ce94bf8e28f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login__MessageLogin), @"mvc.1.0.view", @"/Views/Login/_MessageLogin.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\yazlab2\yazlab2\Views\_ViewImports.cshtml"
using yazlab2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\yazlab2\yazlab2\Views\_ViewImports.cshtml"
using yazlab2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\source\repos\yazlab2\yazlab2\Views\Login\_MessageLogin.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6c272bee20e1ddea24edcdac1939ce94bf8e28f", @"/Views/Login/_MessageLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c64fe3579604812865825a56b74faf59e1365aa4", @"/Views/_ViewImports.cshtml")]
    public class Views_Login__MessageLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"modal-content\">\r\n\r\n   \r\n    <div class=\"modal-header\">\r\n    \r\n    </div>\r\n\r\n    <div style=\"text-align:center;align-items:center;\"class=\"modal-body form-horizontal\">\r\n");
#nullable restore
#line 13 "C:\Users\HP\source\repos\yazlab2\yazlab2\Views\Login\_MessageLogin.cshtml"
           if (Context.Session.GetString("sayac") == "3")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a> ");
#nullable restore
#line 15 "C:\Users\HP\source\repos\yazlab2\yazlab2\Views\Login\_MessageLogin.cshtml"
               Write(Context.Session.GetString("sayac"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Kere Yanlış Giriş Yaptınız.\r\n                     Lütfen Testi Doğrulayınız. </a>\r\n");
#nullable restore
#line 17 "C:\Users\HP\source\repos\yazlab2\yazlab2\Views\Login\_MessageLogin.cshtml"

            }

            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a>\r\n        Hatalı Kullanıcı Adı veya Şifre.\r\n        Tekrar Deneyiniz.\r\n    </a>\r\n");
#nullable restore
#line 26 "C:\Users\HP\source\repos\yazlab2\yazlab2\Views\Login\_MessageLogin.cshtml"
            }

        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div style=\"text-align:center;align-items:center\">\r\n        <button type=\"button\" style=\"width:100px;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 724, "\"", 828, 3);
            WriteAttributeValue("", 734, "location.href=\'", 734, 15, true);
#nullable restore
#line 32 "C:\Users\HP\source\repos\yazlab2\yazlab2\Views\Login\_MessageLogin.cshtml"
WriteAttributeValue("", 749, Url.Action("Error2","Login", new {id = @Context.Session.GetString("sayac") }), 749, 78, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 827, "\'", 827, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Tamam</button>\r\n    </div>\r\n       \r\n\r\n        <div class=\"modal-footer\">\r\n           \r\n\r\n        </div>\r\n  \r\n</div>\r\n\r\n\r\n");
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
