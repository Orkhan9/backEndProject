#pragma checksum "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c219f4235a8bce0f197b6348b2eedd4bba3ba88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Header/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Header_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c219f4235a8bce0f197b6348b2eedd4bba3ba88", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6947c1ce694fa0ad05958ff03fd3e7684bd80f46", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 253, true);
            WriteLiteral("<header>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <nav class=\"navbar navbar-expand-lg d-flex d-lg-block justify-content-between d-xl-flex navbar-light py-3 py-lg-0\">\r\n                    ");
            EndContext();
            BeginContext(265, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4b83370fa1f42de92bc3639be01b506", async() => {
                BeginContext(330, 30, true);
                WriteLiteral("\r\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 360, "\"", 381, 2);
                WriteAttributeValue("", 366, "img/", 366, 4, true);
#line 8 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 370, Model.Logo, 370, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(382, 40, true);
                WriteLiteral(" alt=\"\" id=\"logo\">\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(426, 6244, true);
            WriteLiteral(@"
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"" id=""mobile-navbar-show"">
                        <span class=""navbar-toggler-icon"" style=""font-size: 12px;""></span>
                    </button>

                    <div class=""collapse navbar-collapse d-none d-lg-block"" id=""navbarSupportedContent"">
                        <ul class=""navbar-nav ml-auto"">
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Home</a>
                                <ul class=""list-unstyled py-3"">
                                    <li class=""""><a class=""px-1"" href="""">Home 1</a></li>
                                    <li class=""""><a class=""px-1"" href="""">Home 2</a></li>
                                    <li class=""""><a class=""px-1"" href="""">Home 3</a></li>
                                <");
            WriteLiteral(@"/ul>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Pages</a>
                                <ul class=""list-unstyled py-3"">
                                    <li class=""""><a class=""px-1"" href="""">Page 1</a></li>
                                    <li class=""""><a class=""px-1"" href="""">Page 2</a></li>
                                    <li class=""""><a class=""px-1"" href="""">Page 3</a></li>
                                </ul>
                            </li>
                            <li class=""nav-item shop-li"">
                                <a class=""nav-link"" href=""#"">Shop</a>
                                <div class=""container"">
                                    <div class=""row shop py-5"">
                                        <div class=""col-lg-3"">
                                            <div class=""item px-4"">
                                                <h5>Product Types<");
            WriteLiteral(@"/h5>
                                                <ul class=""list-unstyled py-3"">
                                                    <li class=""""><a class=""px-3"" href="""">Product Types 1</a></li>
                                                    <li class=""""><a class=""px-3"" href="""">Product Types 2</a></li>
                                                    <li class=""""><a class=""px-3"" href="""">Product Types 3</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                        <div class=""col-lg-3"">
                                            <div class=""item px-4"">
                                                <h5>Shop Pages</h5>
                                                <ul class=""list-unstyled py-3"">
                                                    <li class=""""><a class=""px-3"" href="""">Shop Pages 1</a></li>
                                          ");
            WriteLiteral(@"          <li class=""""><a class=""px-3"" href="""">Shop Pages 2</a></li>
                                                    <li class=""""><a class=""px-3"" href="""">Shop Pages 3</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                        <div class=""col-lg-3"">
                                            <div class=""item px-4"">
                                                <h5>Shop Types</h5>
                                                <ul class=""list-unstyled py-3"">
                                                    <li class=""""><a class=""px-3"" href="""">Shop Types 1</a></li>
                                                    <li class=""""><a class=""px-3"" href="""">Shop Types 2</a></li>
                                                    <li class=""""><a class=""px-3"" href="""">Shop Types 3</a></li>
                                                </ul>
             ");
            WriteLiteral(@"                               </div>
                                        </div>
                                        <div class=""col-lg-3"">
                                            <div class=""item px-4"">
                                                <h5>Shop Layouts</h5>
                                                <ul class=""list-unstyled py-3"">
                                                    <li class=""""><a class=""px-3"" href="""">Shop Layouts 1</a></li>
                                                    <li class=""""><a class=""px-3"" href="""">Shop Layouts 2</a></li>
                                                    <li class=""""><a class=""px-3"" href="""">Shop Layouts 3</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li clas");
            WriteLiteral(@"s=""nav-item"">
                                <a class=""nav-link"" href=""#"">Portfolio</a>
                                <ul class=""list-unstyled py-3"">
                                    <li class=""""><a class=""px-1"" href="""">Portfolio 1</a></li>
                                    <li class=""""><a class=""px-1"" href="""">Portfolio 2</a></li>
                                    <li class="""">
                                        <a class=""px-1 mr-5"" href="""">Portfolio 3</a>
                                        <i class=""fas fa-chevron-right fa-sm""></i>
                                        <ul class=""list-unstyled py-3"">
                                            <li class=""""><a class=""px-3"" href="""">Shop Layouts 1</a></li>
                                            <li class=""""><a class=""px-3"" href="""">Shop Layouts 2</a></li>
                                            <li class=""""><a class=""px-3"" href="""">Shop Layouts 3</a></li>
                                        </ul>
                   ");
            WriteLiteral("                 </li>\r\n                                </ul>\r\n                            </li>\r\n\r\n");
            EndContext();
#line 96 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\Components\Header\Default.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
            BeginContext(6766, 91, true);
            WriteLiteral("                                <li class=\"nav-item\">\r\n                                    ");
            EndContext();
            BeginContext(6858, 16, false);
#line 99 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\Components\Header\Default.cshtml"
                               Write(ViewBag.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(6874, 132, true);
            WriteLiteral("\r\n                                </li>\r\n                                <li class=\"nav-item\">\r\n                                    ");
            EndContext();
            BeginContext(7006, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88506ce4a4ae4602b6163348a191c480", async() => {
                BeginContext(7071, 7, true);
                WriteLiteral("Log out");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7082, 41, true);
            WriteLiteral("\r\n                                </li>\r\n");
            EndContext();
#line 104 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\Components\Header\Default.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(7219, 91, true);
            WriteLiteral("                                <li class=\"nav-item\">\r\n                                    ");
            EndContext();
            BeginContext(7310, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "744934a74cbb4e49adc6bd4a5c3ba124", async() => {
                BeginContext(7374, 5, true);
                WriteLiteral("Login");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7383, 132, true);
            WriteLiteral("\r\n                                </li>\r\n                                <li class=\"nav-item\">\r\n                                    ");
            EndContext();
            BeginContext(7515, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6fcd5fc53e41ebbf385a788e5014c8", async() => {
                BeginContext(7582, 8, true);
                WriteLiteral("Register");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7594, 41, true);
            WriteLiteral("\r\n                                </li>\r\n");
            EndContext();
#line 113 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\Components\Header\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(7666, 697, true);
            WriteLiteral(@"
                            <li class=""nav-item my-auto search"">
                                <i class=""fas fa-search"" id=""search""></i>
                                <ul class=""list-unstyled py-3"" id=""searchList"">
                                    <li class=""d-flex px-3"">
                                        <input id=""input-search"" type=""text"" placeholder=""Search"">
                                        <i class=""fas fa-search my-auto"" id=""search""></i>
                                    </li>

                                </ul>
                            </li>
                            <li class=""nav-item my-auto shop-cart"">
                                ");
            EndContext();
            BeginContext(8363, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc4b190d747746deb1a604a620d47abf", async() => {
                BeginContext(8409, 107, true);
                WriteLiteral("\r\n                                    <i class=\"fas fa-shopping-bag\"></i>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8520, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 129 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\Components\Header\Default.cshtml"
                                 if (User.Identity.IsAuthenticated)
                                {

#line default
#line hidden
            BeginContext(8626, 102, true);
            WriteLiteral("                                    <sup class=\"rounded-circle countProductBasket\" id=\"totalCountNav\">");
            EndContext();
            BeginContext(8729, 19, false);
#line 131 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\Components\Header\Default.cshtml"
                                                                                                 Write(ViewBag.BasketCount);

#line default
#line hidden
            EndContext();
            BeginContext(8748, 75, true);
            WriteLiteral("</sup>\r\n                                    <span id=\"totalPriceNav\">CART (");
            EndContext();
            BeginContext(8824, 18, false);
#line 132 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\Components\Header\Default.cshtml"
                                                              Write(ViewBag.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(8842, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 133 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\Components\Header\Default.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(8960, 189, true);
            WriteLiteral("                                    <sup class=\"rounded-circle countProductBasket\" id=\"totalCountNav\">0</sup>\r\n                                    <span id=\"totalPriceNav\">CART (0)</span>\r\n");
            EndContext();
#line 138 "C:\Users\User\Desktop\my projects\ASP\FiorelloFrontToBack\FiorelloFrontToBack\Views\Shared\Components\Header\Default.cshtml"
                                }

#line default
#line hidden
            BeginContext(9184, 8272, true);
            WriteLiteral(@"                                <ul class=""list-unstyled py-3"">
                                    <li class="""">No products in the cart.</li>
                                </ul>
                            </li>
                        </ul>
                    </div>

                </nav>
            </div>
        </div>
        <div class=""mobile-navbar position-absolute shadow-lg h-100 p-5"">
            <i class=""fas fa-times fa-lg"" id=""mobile-navbar-close""></i>
            <ul class=""list-unstyled"">
                <li><a href=""#"">Home <i class=""fas fa-caret-right fa-sm""></i></a></li>
                <ul class=""list-unstyled"">
                    <li class=""""><a class=""px-1"" href="""">Home 1</a></li>
                    <li class=""""><a class=""px-1"" href="""">Home 2</a></li>
                    <li class=""""><a class=""px-1"" href="""">Home 3</a></li>
                </ul>
                <li><a href=""#"">Pages <i class=""fas fa-caret-right fa-sm""></i></a></li>
                <ul class=""lis");
            WriteLiteral(@"t-unstyled"">
                    <li class=""""><a class=""px-1"" href="""">Page 1</a></li>
                    <li class=""""><a class=""px-1"" href="""">Page 2</a></li>
                    <li class=""""><a class=""px-1"" href="""">Page 3</a></li>
                </ul>
                <li>
                    <a href=""#"">Shop <i class=""fas fa-caret-right fa-sm""></i></a>
                </li>
                <ul class=""list-unstyled py-3"">
                    <li class="""">
                        <a class=""px-3"" href=""#"">PRODUCT TYPES <i class=""fas fa-caret-right fa-sm""></i></a>
                    </li>
                    <ul class=""list-unstyled py-3"">
                        <li class=""""><a class=""px-3"" href="""">Product Types 1</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 2</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 3</a></li>
                    </ul>
                    <li class="""">
                        <a class=""px-3"" h");
            WriteLiteral(@"ref=""#"">SHOP PAGES <i class=""fas fa-caret-right fa-sm""></i></a>
                    </li>
                    <ul class=""list-unstyled py-3"">
                        <li class=""""><a class=""px-3"" href="""">Product Types 1</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 2</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 3</a></li>
                    </ul>
                    <li class="""">
                        <a class=""px-3"" href=""#"">SHOP TYPES <i class=""fas fa-caret-right fa-sm""></i></a>
                    </li>
                    <ul class=""list-unstyled py-3"">
                        <li class=""""><a class=""px-3"" href="""">Product Types 1</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 2</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 3</a></li>
                    </ul>
                </ul>
                <li>
                    <a href=""#"">Portf");
            WriteLiteral(@"olio <i class=""fas fa-caret-right fa-sm""></i></a>
                </li>
                <ul class=""list-unstyled py-3"">
                    <li class="""">
                        <a class=""px-3"" href=""#"">PRODUCT TYPES <i class=""fas fa-caret-right fa-sm""></i></a>
                    </li>
                    <ul class=""list-unstyled py-3"">
                        <li class=""""><a class=""px-3"" href="""">Product Types 1</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 2</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 3</a></li>
                    </ul>
                    <li class="""">
                        <a class=""px-3"" href=""#"">SHOP PAGES <i class=""fas fa-caret-right fa-sm""></i></a>
                    </li>
                    <ul class=""list-unstyled py-3"">
                        <li class=""""><a class=""px-3"" href="""">Product Types 1</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 2</a><");
            WriteLiteral(@"/li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 3</a></li>
                    </ul>
                    <li class="""">
                        <a class=""px-3"" href=""#"">SHOP TYPES <i class=""fas fa-caret-right fa-sm""></i></a>
                    </li>
                    <ul class=""list-unstyled py-3"">
                        <li class=""""><a class=""px-3"" href="""">Product Types 1</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 2</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 3</a></li>
                    </ul>
                </ul>
                <li>
                    <a href=""#"">Blog <i class=""fas fa-caret-right fa-sm""></i></a>
                </li>
                <ul class=""list-unstyled py-3"">
                    <li class="""">
                        <a class=""px-3"" href=""#"">PRODUCT TYPES <i class=""fas fa-caret-right fa-sm""></i></a>
                    </li>
                    <ul ");
            WriteLiteral(@"class=""list-unstyled py-3"">
                        <li class=""""><a class=""px-3"" href="""">Product Types 1</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 2</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 3</a></li>
                    </ul>
                    <li class="""">
                        <a class=""px-3"" href=""#"">SHOP PAGES <i class=""fas fa-caret-right fa-sm""></i></a>
                    </li>
                    <ul class=""list-unstyled py-3"">
                        <li class=""""><a class=""px-3"" href="""">Product Types 1</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 2</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 3</a></li>
                    </ul>
                    <li class="""">
                        <a class=""px-3"" href=""#"">SHOP TYPES <i class=""fas fa-caret-right fa-sm""></i></a>
                    </li>
                    <ul class=");
            WriteLiteral(@"""list-unstyled py-3"">
                        <li class=""""><a class=""px-3"" href="""">Product Types 1</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 2</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 3</a></li>
                    </ul>
                </ul>
                <li>
                    <a href=""#"">Elements <i class=""fas fa-caret-right fa-sm""></i></a>
                </li>
                <ul class=""list-unstyled py-3"">
                    <li class="""">
                        <a class=""px-3"" href=""#"">PRODUCT TYPES <i class=""fas fa-caret-right fa-sm""></i></a>
                    </li>
                    <ul class=""list-unstyled py-3"">
                        <li class=""""><a class=""px-3"" href="""">Product Types 1</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 2</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 3</a></li>
                    </ul");
            WriteLiteral(@">
                    <li class="""">
                        <a class=""px-3"" href=""#"">SHOP PAGES <i class=""fas fa-caret-right fa-sm""></i></a>
                    </li>
                    <ul class=""list-unstyled py-3"">
                        <li class=""""><a class=""px-3"" href="""">Product Types 1</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 2</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 3</a></li>
                    </ul>
                    <li class="""">
                        <a class=""px-3"" href=""#"">SHOP TYPES <i class=""fas fa-caret-right fa-sm""></i></a>
                    </li>
                    <ul class=""list-unstyled py-3"">
                        <li class=""""><a class=""px-3"" href="""">Product Types 1</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 2</a></li>
                        <li class=""""><a class=""px-3"" href="""">Product Types 3</a></li>
                    </ul>
   ");
            WriteLiteral("             </ul>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n\r\n</header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591
