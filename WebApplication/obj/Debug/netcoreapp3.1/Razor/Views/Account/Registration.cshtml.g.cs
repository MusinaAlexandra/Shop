#pragma checksum "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81d74c4067ac68061b458ed31d9076ee17075eec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Registration), @"mvc.1.0.view", @"/Views/Account/Registration.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81d74c4067ac68061b458ed31d9076ee17075eec", @"/Views/Account/Registration.cshtml")]
    public class Views_Account_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.ViewModels.RegisterModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<h2>Регистрация нового пользователя</h2>\r\n<form method=\"post\">\r\n    <div>\r\n        <label>Введите имя пользователя</label><br />\r\n        <input  type=\"text\" name=\"userName\" required/>\r\n        ");
#nullable restore
#line 8 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Registration.cshtml"
   Write(Html.ValidationMessageFor(model => model.userName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>Введиет пароль</label><br />\r\n        <input  type=\"password\" name=\"password\" required/>\r\n        ");
#nullable restore
#line 13 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Registration.cshtml"
   Write(Html.ValidationMessageFor(model => model.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label asp-for=\"PasswordConfirm\">Повторите пароль</label><br />\r\n        <input  type=\"password\" name=\"checkPassword\" required/>\r\n        ");
#nullable restore
#line 18 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Registration.cshtml"
   Write(Html.ValidationMessageFor(model => model.checkPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>Введите Email</label><br />\r\n        <input  type=\"text\" name=\"email\" required/>\r\n        ");
#nullable restore
#line 23 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Registration.cshtml"
   Write(Html.ValidationMessageFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <input type=\"submit\" value=\"Регистрация\" />\r\n    </div>\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.ViewModels.RegisterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
