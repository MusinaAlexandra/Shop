#pragma checksum "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7176e3bcc13b2d114c67188dd75416c7c87c2999"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7176e3bcc13b2d114c67188dd75416c7c87c2999", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<link");
            BeginWriteAttribute("href", " href=\"", 7, "\"", 55, 1);
#nullable restore
#line 2 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Login.cshtml"
WriteAttributeValue("", 14, Url.Content("~/Views/Account/login.css"), 14, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n<div>\r\n    Current user: <span>");
#nullable restore
#line 4 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Login.cshtml"
                   Write(ViewContext.HttpContext.User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
</div>
<a href=""Registration"">Регистрация</a>
<form  method=""post"">
    <table>
        <tr>
            <td>
                UserName
            </td>
            <td>
                <input  type=""text"" name=""userName"" required/>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td><input type=""password"" name=""password"" required/></td>
        </tr>
    </table>
    <div><input type=""submit"" value=""Войти""/></div>
    <div>");
#nullable restore
#line 23 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Login.cshtml"
    Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n</form>");
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
