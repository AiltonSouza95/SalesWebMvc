#pragma checksum "C:\Users\ailto\Documents\Projetos\SalesWebMVC\SalesWebMvc\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83bd1362fbcfd73c79de76b34fe5cd2b1e49c53f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\ailto\Documents\Projetos\SalesWebMVC\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ailto\Documents\Projetos\SalesWebMVC\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83bd1362fbcfd73c79de76b34fe5cd2b1e49c53f", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a921f4b28037c99cd74994d2c5399b3bc3ca6e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ailto\Documents\Projetos\SalesWebMVC\SalesWebMvc\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 4 "C:\Users\ailto\Documents\Projetos\SalesWebMVC\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h3>");
#nullable restore
#line 5 "C:\Users\ailto\Documents\Projetos\SalesWebMVC\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n<p>Professor ");
#nullable restore
#line 7 "C:\Users\ailto\Documents\Projetos\SalesWebMVC\SalesWebMvc\Views\Home\About.cshtml"
        Write(ViewData["Professor"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<address>\n    <strong>More information: </strong> <a href=\"http://linkedin.com\">Ailton Souza</a>\n</address>");
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
