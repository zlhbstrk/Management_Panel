#pragma checksum "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Siparis\SiparisListele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fc20fef441afb28a69b8ffa80c1d240d3948de8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Siparis_SiparisListele), @"mvc.1.0.view", @"/Views/Siparis/SiparisListele.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Siparis/SiparisListele.cshtml", typeof(AspNetCore.Views_Siparis_SiparisListele))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fc20fef441afb28a69b8ffa80c1d240d3948de8", @"/Views/Siparis/SiparisListele.cshtml")]
    public class Views_Siparis_SiparisListele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Management_Panel.Models.Siparis>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Siparis\SiparisListele.cshtml"
  
    ViewData["Title"] = "SiparisListele";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 3686, true);
            WriteLiteral(@"
<div class=""panel"">
    <header class=""panel-heading"">
        <div class=""panel-actions""></div>
        <h3 class=""panel-title"">Sipariş Listele</h3>
    </header>
    <div class=""panel-body"">
        <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper form-inline dt-bootstrap"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <table class=""table table-hover dataTable table-striped w-full dtr-inline"" data-plugin=""dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                        <thead>
                            <tr role=""row"">
                                <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 160px;"" aria-sort=""ascending"" aria-label=""Name: activate to sort column descending"">İsim</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width:");
            WriteLiteral(@" 100px;"" aria-label=""Price: activate to sort column ascending"">Telefon</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 70px;"" aria-label=""E-mail: activate to sort column ascending"">E-Mail</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 110px;"" aria-label=""Price: activate to sort column ascending"">Fiyat</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 110px;"" aria-label=""Date: activate to sort column ascending"">Tarih</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 110px;"" aria-label=""Note: activate to sort column ascending"">Not</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" ro");
            WriteLiteral(@"wspan=""1"" colspan=""1"" style=""width: 110px;"" aria-label=""Address: activate to sort column ascending"">Adres</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 110px;"" aria-label=""Province: activate to sort column ascending"">Şehir</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 110px;"" aria-label=""Country: activate to sort column ascending"">Ülke</th>
                                <th tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 30px;"">Detay</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th rowspan=""1"" colspan=""1"">İsim</th>
                                <th rowspan=""1"" colspan=""1"">Telefon</th>
                                <th rowspan=""1"" colspan=""1"">E-");
            WriteLiteral(@"Mail</th>
                                <th rowspan=""1"" colspan=""1"">Fiyat</th>
                                <th rowspan=""1"" colspan=""1"">Tarih</th>
                                <th rowspan=""1"" colspan=""1"">Not</th>
                                <th rowspan=""1"" colspan=""1"">Adres</th>
                                <th rowspan=""1"" colspan=""1"">Şehir</th>
                                <th rowspan=""1"" colspan=""1"">Ülke</th>
                                <th rowspan=""1"" colspan=""1"">Detay</th>
                            </tr>
                        </tfoot>
                        <tbody>
");
            EndContext();
#line 46 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Siparis\SiparisListele.cshtml"
                             foreach (var s in Model)
                            {

#line default
#line hidden
            BeginContext(3915, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(3986, 6, false);
#line 49 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Siparis\SiparisListele.cshtml"
                               Write(s.name);

#line default
#line hidden
            EndContext();
            BeginContext(3992, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4036, 11, false);
#line 50 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Siparis\SiparisListele.cshtml"
                               Write(s.telephone);

#line default
#line hidden
            EndContext();
            BeginContext(4047, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4091, 6, false);
#line 51 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Siparis\SiparisListele.cshtml"
                               Write(s.mail);

#line default
#line hidden
            EndContext();
            BeginContext(4097, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4141, 7, false);
#line 52 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Siparis\SiparisListele.cshtml"
                               Write(s.price);

#line default
#line hidden
            EndContext();
            BeginContext(4148, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4192, 6, false);
#line 53 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Siparis\SiparisListele.cshtml"
                               Write(s.date);

#line default
#line hidden
            EndContext();
            BeginContext(4198, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4242, 6, false);
#line 54 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Siparis\SiparisListele.cshtml"
                               Write(s.note);

#line default
#line hidden
            EndContext();
            BeginContext(4248, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4292, 9, false);
#line 55 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Siparis\SiparisListele.cshtml"
                               Write(s.address);

#line default
#line hidden
            EndContext();
            BeginContext(4301, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4345, 10, false);
#line 56 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Siparis\SiparisListele.cshtml"
                               Write(s.province);

#line default
#line hidden
            EndContext();
            BeginContext(4355, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4399, 9, false);
#line 57 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Siparis\SiparisListele.cshtml"
                               Write(s.country);

#line default
#line hidden
            EndContext();
            BeginContext(4408, 238, true);
            WriteLiteral("</td>\r\n                                <td><button type=\"button\" onclick=\"location.href=\'SiparisDetay\'\" class=\"btn btn-block btn-info waves-effect waves-classic\" style=\"width:30px;\">Detay</button></td>\r\n                            </tr>\r\n");
            EndContext();
#line 60 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Siparis\SiparisListele.cshtml"
                            }

#line default
#line hidden
            BeginContext(4677, 142, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Management_Panel.Models.Siparis>> Html { get; private set; }
    }
}
#pragma warning restore 1591
