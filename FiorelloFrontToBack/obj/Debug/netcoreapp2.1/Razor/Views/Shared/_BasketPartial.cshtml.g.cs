#pragma checksum "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cec85ce0d3bb79a8fb3b80edc1130884c34d2080"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasketPartial), @"mvc.1.0.view", @"/Views/Shared/_BasketPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_BasketPartial.cshtml", typeof(AspNetCore.Views_Shared__BasketPartial))]
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
#line 1 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\_ViewImports.cshtml"
using FiorelloFrontToBack.Models;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\_ViewImports.cshtml"
using FiorelloFrontToBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cec85ce0d3bb79a8fb3b80edc1130884c34d2080", @"/Views/Shared/_BasketPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6947c1ce694fa0ad05958ff03fd3e7684bd80f46", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BasketPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasketVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductCountMinus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml"
  
    Layout = null;
    double Total = 0;

#line default
#line hidden
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml"
 foreach (BasketVM item in Model)
{
    double total = item.Count * item.Price;
    Total += total;


#line default
#line hidden
            BeginContext(188, 36, true);
            WriteLiteral("    <tr id=\"parentTr\">\r\n        <td>");
            EndContext();
            BeginContext(224, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "57c741f9242746e8bfb726510bf64c2e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 234, "~/img/", 234, 6, true);
#line 13 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml"
AddHtmlAttributeValue("", 240, item.Image, 240, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(267, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(287, 10, false);
#line 14 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml"
       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(297, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(317, 10, false);
#line 15 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml"
       Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(327, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(347, 5, false);
#line 16 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml"
       Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(352, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(372, 22, false);
#line 17 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml"
       Write(ViewBag.dbProductCount);

#line default
#line hidden
            EndContext();
            BeginContext(394, 54, true);
            WriteLiteral("</td>\r\n        <td class=\"productCount\">\r\n            ");
            EndContext();
            BeginContext(449, 10, false);
#line 19 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml"
       Write(item.Count);

#line default
#line hidden
            EndContext();
            BeginContext(459, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(502, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa48a10b2c0142c38aad9a01e525ea59", async() => {
                BeginContext(584, 60, true);
                WriteLiteral("\r\n                <i class=\"fas fa-minus\"></i>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml"
                                                                        WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(648, 31, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n");
            EndContext();
#line 27 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml"
             if (item.Count < ViewBag.dbProductCount)
            {

#line default
#line hidden
            BeginContext(749, 106, true);
            WriteLiteral("                <a>\r\n                    <i class=\"fas fa-plus plusProduct\" onclick=\"Increase()\" data-id=\"");
            EndContext();
            BeginContext(856, 7, false);
#line 30 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml"
                                                                                Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(863, 30, true);
            WriteLiteral("\"></i>\r\n                </a>\r\n");
            EndContext();
#line 32 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(908, 113, true);
            WriteLiteral("        </td>\r\n        <td>\r\n            <a>\r\n                <i class=\"fas fa-trash-alt removeProduct\" data-id=\"");
            EndContext();
            BeginContext(1022, 7, false);
#line 36 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml"
                                                              Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1029, 52, true);
            WriteLiteral("\"></i>\r\n            </a>\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 40 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\_BasketPartial.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
