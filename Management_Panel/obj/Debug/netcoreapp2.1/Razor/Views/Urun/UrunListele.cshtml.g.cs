#pragma checksum "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Urun\UrunListele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03cd5444c909f05d42fbf8c90cf486aad2cb0a4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Urun_UrunListele), @"mvc.1.0.view", @"/Views/Urun/UrunListele.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Urun/UrunListele.cshtml", typeof(AspNetCore.Views_Urun_UrunListele))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03cd5444c909f05d42fbf8c90cf486aad2cb0a4d", @"/Views/Urun/UrunListele.cshtml")]
    public class Views_Urun_UrunListele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Management_Panel.Models.Urun>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Urun\UrunListele.cshtml"
  
    ViewData["Title"] = "UrunListele";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 3276, true);
            WriteLiteral(@"
<div class=""panel"">
    <header class=""panel-heading"">
        <div class=""panel-actions""></div>
        <h3 class=""panel-title"">Ürün Listele</h3>
    </header>
    <div class=""panel-body"">
        <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper form-inline dt-bootstrap"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <table class=""table table-hover dataTable table-striped w-full dtr-inline"" data-plugin=""dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                        <thead>
                            <tr role=""row"">
                                <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 160px;"" aria-sort=""ascending"" aria-label=""Name: activate to sort column descending"">Ad</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 100p");
            WriteLiteral(@"x;"" aria-label=""Price: activate to sort column ascending"">Fiyat</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 70px;"" aria-label=""Quantity: activate to sort column ascending"">Miktar</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 110px;"" aria-label=""Stock: activate to sort column ascending"">Stok Durumu</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 110px;"" aria-label=""Stock: activate to sort column ascending"">Faaliyet Durumu</th>
                                <th tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 30px;"" aria-label=""Image: activate to sort column ascending"">Resim</th>
                                <th tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=");
            WriteLiteral(@"""1"" style=""width: 30px;"">Sil</th>
                                <th tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 30px;"">Güncelle</th>
                                <th tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 30px;"">Askıya Al</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th rowspan=""1"" colspan=""1"">Ad</th>
                                <th rowspan=""1"" colspan=""1"">Fiyat</th>
                                <th rowspan=""1"" colspan=""1"">Mitar</th>
                                <th rowspan=""1"" colspan=""1"">Stok Durumu</th>
                                <th rowspan=""1"" colspan=""1"">Faaliyet Durumu</th>
                                <th rowspan=""1"" colspan=""1"">Resim</th>
                                <th rowspan=""1"" colspan=""1"">Sil</th>
                                <th rowspan=""1"" c");
            WriteLiteral("olspan=\"1\">Güncelle</th>\r\n                                <th rowspan=\"1\" colspan=\"1\">Askıya Al</th>\r\n                            </tr>\r\n                        </tfoot>\r\n                        <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Urun\UrunListele.cshtml"
                             foreach (var u in Model)
                            {

#line default
#line hidden
            BeginContext(3499, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(3570, 6, false);
#line 47 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Urun\UrunListele.cshtml"
                               Write(u.name);

#line default
#line hidden
            EndContext();
            BeginContext(3576, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3620, 7, false);
#line 48 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Urun\UrunListele.cshtml"
                               Write(u.price);

#line default
#line hidden
            EndContext();
            BeginContext(3627, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3671, 10, false);
#line 49 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Urun\UrunListele.cshtml"
                               Write(u.quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3681, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3725, 9, false);
#line 50 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Urun\UrunListele.cshtml"
                               Write(u.isStock);

#line default
#line hidden
            EndContext();
            BeginContext(3734, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3778, 8, false);
#line 51 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Urun\UrunListele.cshtml"
                               Write(u.status);

#line default
#line hidden
            EndContext();
            BeginContext(3786, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3830, 7, false);
#line 52 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Urun\UrunListele.cshtml"
                               Write(u.image);

#line default
#line hidden
            EndContext();
            BeginContext(3837, 45, true);
            WriteLiteral("</td>\r\n                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3882, "\"", 3908, 2);
            WriteAttributeValue("", 3889, "/Urun/UrunSil/", 3889, 14, true);
#line 53 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Urun\UrunListele.cshtml"
WriteAttributeValue("", 3903, u.id, 3903, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3909, 109, true);
            WriteLiteral(" style=\"width:30px; color:red;\"><i class=\"fa fa-remove\"></i></a></td>\r\n                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4018, "\"", 4049, 2);
            WriteAttributeValue("", 4025, "/Urun/UrunGuncelle/", 4025, 19, true);
#line 54 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Urun\UrunListele.cshtml"
WriteAttributeValue("", 4044, u.id, 4044, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4050, 112, true);
            WriteLiteral(" style=\"width:50px; color:limegreen\"><i class=\"fa fa-edit\"></i></a></td>\r\n                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4162, "\"", 4189, 2);
            WriteAttributeValue("", 4169, "/Urun/AskiyaAl/", 4169, 15, true);
#line 55 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Urun\UrunListele.cshtml"
WriteAttributeValue("", 4184, u.id, 4184, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4190, 113, true);
            WriteLiteral(" style=\"width:50px; color:saddlebrown\"><i class=\"fa fa-repeat\"></i></a></td>\r\n                            </tr>\r\n");
            EndContext();
#line 57 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Urun\UrunListele.cshtml"
                            }

#line default
#line hidden
            BeginContext(4334, 142, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Management_Panel.Models.Urun>> Html { get; private set; }
    }
}
#pragma warning restore 1591
