#pragma checksum "C:\Users\Vakıf Global\source\repos\WebApplication13\WebApplication13\Views\Birim\BirimGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "128e169a7a0445806dd3e59b9408d4e8a7d56155"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Birim_BirimGetir), @"mvc.1.0.view", @"/Views/Birim/BirimGetir.cshtml")]
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
#line 1 "C:\Users\Vakıf Global\source\repos\WebApplication13\WebApplication13\Views\_ViewImports.cshtml"
using WebApplication13;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vakıf Global\source\repos\WebApplication13\WebApplication13\Views\Birim\BirimGetir.cshtml"
using WebApplication13.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"128e169a7a0445806dd3e59b9408d4e8a7d56155", @"/Views/Birim/BirimGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee7547f290230a50930d91b1b1f49eae2184d811", @"/Views/_ViewImports.cshtml")]
    public class Views_Birim_BirimGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication13.Models.Birim>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Vakıf Global\source\repos\WebApplication13\WebApplication13\Views\Birim\BirimGetir.cshtml"
  
    ViewData["Title"] = "BirimGetir";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Vakıf Global\source\repos\WebApplication13\WebApplication13\Views\Birim\BirimGetir.cshtml"
 using (Html.BeginForm("BirimGuncelle", "Birim", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b> Birim ID</b>\r\n    <br />\r\n");
#nullable restore
#line 14 "C:\Users\Vakıf Global\source\repos\WebApplication13\WebApplication13\Views\Birim\BirimGetir.cshtml"
Write(Html.TextBoxFor(x => x.BirimID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b> Birim Adı</b>\r\n    <br />\r\n");
#nullable restore
#line 17 "C:\Users\Vakıf Global\source\repos\WebApplication13\WebApplication13\Views\Birim\BirimGetir.cshtml"
Write(Html.TextBoxFor(x => x.BirimAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\" type=\"submit\" style=\"background:#71c4ff\">Birim Günccelle</button>\r\n");
#nullable restore
#line 20 "C:\Users\Vakıf Global\source\repos\WebApplication13\WebApplication13\Views\Birim\BirimGetir.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication13.Models.Birim> Html { get; private set; }
    }
}
#pragma warning restore 1591
