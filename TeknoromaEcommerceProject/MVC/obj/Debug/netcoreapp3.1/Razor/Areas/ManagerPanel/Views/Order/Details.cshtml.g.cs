#pragma checksum "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73fea738947677a93189d13f185dbe0c539ef1e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ManagerPanel_Views_Order_Details), @"mvc.1.0.view", @"/Areas/ManagerPanel/Views/Order/Details.cshtml")]
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
#line 1 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\_ViewImports.cshtml"
using DAL.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\_ViewImports.cshtml"
using MVC.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73fea738947677a93189d13f185dbe0c539ef1e0", @"/Areas/ManagerPanel/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afcbc5265eabcf33d2f93a9a180f18dd7777044b", @"/Areas/ManagerPanel/Views/_ViewImports.cshtml")]
    public class Areas_ManagerPanel_Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC.Areas.ManagerPanel.Models.OrderVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/ManagerPanel/Views/Shared/_ManagerLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <h2>Sipariş Detayı</h2>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""card-body"">
                    <table class=""table table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th>Sipariş ID</th>
                                <th>Sipariş Onay Durumu</th>
                                <th>Sipariş Tarihi</th>
                                <th>Email</th>
                                <th>Adres</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>");
#nullable restore
#line 35 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                               Write(Model.Order.MasterId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                                 if (Model.Order.Confirmed == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Sipariş durumu : onaylandı</td>\r\n");
#nullable restore
#line 39 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Sipariş durumu : Onay bekliyor</td>\r\n");
#nullable restore
#line 43 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 45 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                           Write(Model.Order.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>Email:");
#nullable restore
#line 47 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                                 Write(userManager.FindByIdAsync(Model.Order.AppUserID.ToString()).Result.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 48 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                             if (Model.UserAdress != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <table>\r\n                                        <tr><td>Adres Adı: ");
#nullable restore
#line 52 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                                                      Write(Model.UserAdress.AdressName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                                        <tr><td>Adı: ");
#nullable restore
#line 53 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                                                Write(Model.UserAdress.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                                        <tr><td>Soyadı: ");
#nullable restore
#line 54 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                                                   Write(Model.UserAdress.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                                        <tr><td>TC No: ");
#nullable restore
#line 55 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                                                  Write(Model.UserAdress.TCNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                                        <tr><td>Email: ");
#nullable restore
#line 56 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                                                  Write(Model.UserAdress.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                                        <tr><td>Telefon: ");
#nullable restore
#line 57 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                                                    Write(Model.UserAdress.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                                        <tr><td>Ülke: ");
#nullable restore
#line 58 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                                                 Write(Model.UserAdress.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                                        <tr><td>Şehir: ");
#nullable restore
#line 59 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                                                  Write(Model.UserAdress.Town);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                                        <tr><td>Açık Adres: ");
#nullable restore
#line 60 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                                                       Write(Model.UserAdress.FullAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                                    </table>\r\n                                </td>\r\n");
#nullable restore
#line 63 "C:\Users\gulsen\Source\Repos\Teknoroma\TeknoromaEcommerceProject\MVC\Areas\ManagerPanel\Views\Order\Details.cshtml"
                                
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    \r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BLL.Abstract.IShipperService shipperService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC.Areas.ManagerPanel.Models.OrderVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
