#pragma checksum "C:\Users\User\Desktop\visual studio me\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0952009679f93451a92dc8599f5a286395577196"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "C:\Users\User\Desktop\visual studio me\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\_ViewImports.cshtml"
using FiorelloFrontToBack.Models;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\visual studio me\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\_ViewImports.cshtml"
using FiorelloFrontToBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0952009679f93451a92dc8599f5a286395577196", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6947c1ce694fa0ad05958ff03fd3e7684bd80f46", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 112, true);
            WriteLiteral("\r\n<section id=\"products\">\r\n    <div class=\"container\">\r\n        <div class=\"row\" id=\"productList\">\r\n            ");
            EndContext();
            BeginContext(142, 41, false);
#line 6 "C:\Users\User\Desktop\visual studio me\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml"
       Write(await Component.InvokeAsync("Products",8));

#line default
#line hidden
            EndContext();
            BeginContext(183, 64, true);
            WriteLiteral("\r\n        </div>\r\n        <input type=\"hidden\" id=\"ProductCount\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 247, "\"", 276, 1);
#line 8 "C:\Users\User\Desktop\visual studio me\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Product\Index.cshtml"
WriteAttributeValue("", 255, ViewBag.ProductCount, 255, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(277, 183, true);
            WriteLiteral(" />\r\n        <div class=\"row mt-3 mb-3 justify-content-center\">\r\n            <button class=\"btn btn-success\" id=\"loadMore\">Load more</button>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591