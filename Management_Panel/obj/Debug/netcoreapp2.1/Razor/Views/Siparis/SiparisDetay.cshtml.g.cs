#pragma checksum "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a050f77d1dc02008d9d23f26d6102c19c887bea6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Siparis_SiparisDetay), @"mvc.1.0.view", @"/Views/Siparis/SiparisDetay.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Siparis/SiparisDetay.cshtml", typeof(AspNetCore.Views_Siparis_SiparisDetay))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a050f77d1dc02008d9d23f26d6102c19c887bea6", @"/Views/Siparis/SiparisDetay.cshtml")]
    public class Views_Siparis_SiparisDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Management_Panel.Models.SiparisDetay>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
  
    ViewData["Title"] = "SiparisDetay";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 428, true);
            WriteLiteral(@"<div class=""panel"" onload=""Init()"">
    <header class=""panel-heading"">
        <div class=""panel-actions""></div>
        <h3 class=""panel-title"">Sipariş Detay Listele</h3>
    </header>
    <div class=""panel-body"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <table class=""table"">
                    <tr>
                        <th scope=""row"">Ad: </th>
                        <td>");
            EndContext();
            BeginContext(569, 18, false);
#line 17 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                       Write(Model.siparis.name);

#line default
#line hidden
            EndContext();
            BeginContext(587, 144, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Telefon: </th>\r\n                        <td>");
            EndContext();
            BeginContext(732, 23, false);
#line 21 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                       Write(Model.siparis.telephone);

#line default
#line hidden
            EndContext();
            BeginContext(755, 143, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">E-mail: </th>\r\n                        <td>");
            EndContext();
            BeginContext(899, 18, false);
#line 25 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                       Write(Model.siparis.mail);

#line default
#line hidden
            EndContext();
            BeginContext(917, 142, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Fiyat: </th>\r\n                        <td>");
            EndContext();
            BeginContext(1060, 19, false);
#line 29 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                       Write(Model.siparis.price);

#line default
#line hidden
            EndContext();
            BeginContext(1079, 142, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Tarih: </th>\r\n                        <td>");
            EndContext();
            BeginContext(1222, 18, false);
#line 33 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                       Write(Model.siparis.date);

#line default
#line hidden
            EndContext();
            BeginContext(1240, 140, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Not: </th>\r\n                        <td>");
            EndContext();
            BeginContext(1381, 18, false);
#line 37 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                       Write(Model.siparis.note);

#line default
#line hidden
            EndContext();
            BeginContext(1399, 142, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Adres: </th>\r\n                        <td>");
            EndContext();
            BeginContext(1542, 21, false);
#line 41 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                       Write(Model.siparis.address);

#line default
#line hidden
            EndContext();
            BeginContext(1563, 142, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Şehir: </th>\r\n                        <td>");
            EndContext();
            BeginContext(1706, 22, false);
#line 45 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                       Write(Model.siparis.province);

#line default
#line hidden
            EndContext();
            BeginContext(1728, 141, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Ülke: </th>\r\n                        <td>");
            EndContext();
            BeginContext(1870, 21, false);
#line 49 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                       Write(Model.siparis.country);

#line default
#line hidden
            EndContext();
            BeginContext(1891, 452, true);
            WriteLiteral(@"</td>
                    </tr>
                </table>
            </div>
            <div class=""col-sm-6"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Ürün Adı</th>
                            <th>Ürün Fiyatı</th>
                            <th>Ürün Miktarı</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 63 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                         foreach (var u in Model.urunler)
                        {

#line default
#line hidden
            BeginContext(2429, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2500, 6, false);
#line 66 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                               Write(u.name);

#line default
#line hidden
            EndContext();
            BeginContext(2506, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2550, 7, false);
#line 67 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                               Write(u.price);

#line default
#line hidden
            EndContext();
            BeginContext(2557, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2601, 10, false);
#line 68 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                               Write(u.quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2611, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 70 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                        }

#line default
#line hidden
            BeginContext(2680, 68, true);
            WriteLiteral("                    </tbody>\r\n                    <th>Toplam Fiyat: ");
            EndContext();
            BeginContext(2749, 19, false);
#line 72 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                                 Write(Model.siparis.price);

#line default
#line hidden
            EndContext();
            BeginContext(2768, 114, true);
            WriteLiteral("</th>\r\n                </table>\r\n                <form id=\"frmSiparisOnay\" action=\"SiparisOnayla\" method=\"post\">\r\n");
            EndContext();
#line 75 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                      
                        if (@Model.siparis.status)
                        {

#line default
#line hidden
            BeginContext(2985, 153, true);
            WriteLiteral("                            <label for=\"onay\">Sipariş Onayla: </label>\r\n                            <input type=\"checkbox\" id=\"onay\" readonly checked/>\r\n");
            EndContext();
#line 80 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3222, 137, true);
            WriteLiteral("                            <label for=\"onay\">Sipariş Onayla: </label>\r\n                            <input type=\"checkbox\" id=\"onay\" />\r\n");
            EndContext();
#line 85 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Siparis\SiparisDetay.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(3409, 890, true);
            WriteLiteral(@"
                </form>
                <form action=""KargoBilgisiGir"" method=""post"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label for=""kargoTakip"">Kargo Takip No: </label>
                        </div>
                        <div class=""col-md-6"">
                            <input type=""text"" id=""fname"" name=""kargoTakip"" placeholder=""Kargo takip no giriniz."" class=""form-control"" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6""></div>
                        <div class=""col-md-6""> <input type=""submit"" value=""Kaydet"" class=""btn-block btn-info form-control"" style=""width:100px;"" /></div>
                    </div>
                </form>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Management_Panel.Models.SiparisDetay> Html { get; private set; }
    }
}
#pragma warning restore 1591
