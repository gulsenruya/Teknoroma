#pragma checksum "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Cart\Shipment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a7f563c7ebdb4e3f4a02138fc9de338a3ca6fea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Shipment), @"mvc.1.0.view", @"/Views/Cart/Shipment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a7f563c7ebdb4e3f4a02138fc9de338a3ca6fea", @"/Views/Cart/Shipment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaaca86df9a2e925f44bf37d85db8c818e9b1add", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Shipment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddressVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Cart\Shipment.cshtml"
  
    ViewData["Title"] = "Shipment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""container"">
        <div class=""card-header"">
            <h6>Kargo Firması Seçiniz</h6>
        </div>
        <div class=""card-body"">
            <div class=""col-md-6 col-sm-12"" style=""float: left;"">
                <div class=""main-content-box checkout-products-box"">
                    <div class=""list-group"" id=""shipmentList"">
");
#nullable restore
#line 16 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Cart\Shipment.cshtml"
                         if (Model.Shippers.Count > 0)
                        {

                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Cart\Shipment.cshtml"
                             foreach (var item in Model.Shippers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <article class=\"list-group-item\">\r\n                                    <header class=\"filter-header\">\r\n                                        <a href=\"#\" data-toggle=\"collapse\" data-target=\"#collapse1\" aria-expanded=\"true\"");
            BeginWriteAttribute("class", " class=\"", 926, "\"", 934, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"icon-control fa fa-chevron-down\"></i>\r\n                                            <h6 class=\"title\">");
#nullable restore
#line 25 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Cart\Shipment.cshtml"
                                                         Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        </a>\r\n                                    </header>\r\n\r\n                                    <div class=\"text-right\">\r\n                                        <button class=\"btn btn-success btn-md chooseal\"");
            BeginWriteAttribute("id", " id=\"", 1361, "\"", 1374, 1);
#nullable restore
#line 30 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Cart\Shipment.cshtml"
WriteAttributeValue("", 1366, item.ID, 1366, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Seç</button>\r\n                                    </div>\r\n                                </article>\r\n");
#nullable restore
#line 33 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Cart\Shipment.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Views\Cart\Shipment.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
         $('#shipmentList').on('click', 'button', function () {
            var shipmentId = $(this).attr('id');
            var buttonValue = $(this).attr('class');
            if (buttonValue == 'btn btn-success btn-md chooseal') {
                var path = '/Cart/ShipmentSelect/' + shipmentId;
                $.ajax({
                    url: path,
                    type: 'GET',
                    success: function () {
                        $(location).attr('href', 'https://localhost:44347/Cart/CompleteCart');
                    }
                });
            }
        });

    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddressVM> Html { get; private set; }
    }
}
#pragma warning restore 1591