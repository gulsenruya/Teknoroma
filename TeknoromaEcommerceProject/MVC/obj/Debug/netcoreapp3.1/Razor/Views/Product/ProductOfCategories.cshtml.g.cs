#pragma checksum "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Product\ProductOfCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce362461b40273b1ced485baaed5b0c55dd49d1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductOfCategories), @"mvc.1.0.view", @"/Views/Product/ProductOfCategories.cshtml")]
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
#line 1 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\_ViewImports.cshtml"
using MVC.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\_ViewImports.cshtml"
using MVC.Models.CartModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\_ViewImports.cshtml"
using DAL.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce362461b40273b1ced485baaed5b0c55dd49d1e", @"/Views/Product/ProductOfCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaaca86df9a2e925f44bf37d85db8c818e9b1add", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductOfCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("title mt-2 h5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Product\ProductOfCategories.cshtml"
  
    ViewData["Title"] = "ProductOfCategories";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section-content padding-y bg"">
    <div class=""container"">

        <div class=""row"">

            <main class=""col-md-9"">
                <!-- ============================ COMPONENT 1  ================================= -->
            
");
#nullable restore
#line 15 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Product\ProductOfCategories.cshtml"
                 foreach (var product in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <article class=\"card card-product-list\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"row\">\r\n                                <aside class=\"col-sm-4\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 714, "\"", 733, 2);
            WriteAttributeValue("", 721, "/", 721, 1, true);
#nullable restore
#line 21 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Product\ProductOfCategories.cshtml"
WriteAttributeValue("", 722, product.ID, 722, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-wrap\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ce362461b40273b1ced485baaed5b0c55dd49d1e6858", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 762, "~/images/products/", 762, 18, true);
#nullable restore
#line 21 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Product\ProductOfCategories.cshtml"
AddHtmlAttributeValue("", 780, product.ImagePath, 780, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                </aside> <!-- col.// -->\r\n                                <div class=\"col-sm-8\">\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce362461b40273b1ced485baaed5b0c55dd49d1e8545", async() => {
#nullable restore
#line 25 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Product\ProductOfCategories.cshtml"
                                                                             Write(product.ProductName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 967, "~/", 967, 2, true);
#nullable restore
#line 25 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Product\ProductOfCategories.cshtml"
AddHtmlAttributeValue("", 969, product.ID, 969, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <div class=\"d-flex mb-3\">\r\n                                        <div class=\"price-wrap mr-4\">\r\n                                            <span class=\"price h5\">");
#nullable restore
#line 28 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Product\ProductOfCategories.cshtml"
                                                              Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        </div>
                                    </div>
                                    <div class=""d-flex mb-3"">
                                        <div class=""rating-wrap"">
                                            <ul class=""list-bullet"">
                                                <li>");
#nullable restore
#line 34 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Product\ProductOfCategories.cshtml"
                                               Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>

                                            </ul>
                                        </div>


                                    </div>
                                    <br />
                                    <br />
                                    <div class=""d-flex mb-3"">
                                        <div class=""form-group col-md"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce362461b40273b1ced485baaed5b0c55dd49d1e12033", async() => {
                WriteLiteral(" <span class=\"text\">Sepete Ekle</span> <i class=\"fas fa-shopping-cart\"></i>  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Product\ProductOfCategories.cshtml"
                                                                                              WriteLiteral(product.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                        </div>
                                    </div>
                                    <!-- price-dewrap // -->
                                    <!-- row.// -->

                                </div> <!-- col.// -->
                            </div> <!-- row.// -->
                        </div> <!-- card-body .// -->
                    </article>
");
#nullable restore
#line 56 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Product\ProductOfCategories.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </main> <!-- col.// -->\r\n            <aside class=\"col-md-3\">\r\n                <!-- COMPONENTS SIDEBAR -->\r\n                <output>\r\n");
            WriteLiteral(" <!-- card.// -->\r\n                </output>\r\n                <!-- COMPONENTS SIDEBAR END .// -->\r\n            </aside>\r\n\r\n\r\n        </div> <!-- row.// -->\r\n\r\n    </div> <!-- container .//  -->\r\n</section>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n    $(\'#addToCart\').click(function () {\r\n\r\n        var path = \'/Cart/AddToCart/\' + this.id;\r\n        $.ajax({\r\n                type: \'GET\',\r\n                url: path\r\n        });\r\n     });\r\n\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591