#pragma checksum "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kullanici\KullaniciListele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4202591b1b198e400b248056933957bc17b233c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kullanici_KullaniciListele), @"mvc.1.0.view", @"/Views/Kullanici/KullaniciListele.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kullanici/KullaniciListele.cshtml", typeof(AspNetCore.Views_Kullanici_KullaniciListele))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4202591b1b198e400b248056933957bc17b233c4", @"/Views/Kullanici/KullaniciListele.cshtml")]
    public class Views_Kullanici_KullaniciListele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Management_Panel.Models.Kullanici>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kullanici\KullaniciListele.cshtml"
  
    ViewData["Title"] = "KullaniciListele";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 2622, true);
            WriteLiteral(@"
<div class=""panel"">
    <header class=""panel-heading"">
        <div class=""panel-actions""></div>
        <h3 class=""panel-title"">Kullanıcı Listele</h3>
    </header>
    <div class=""panel-body"">
        <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper form-inline dt-bootstrap"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <table class=""table table-hover dataTable table-striped w-full dtr-inline"" data-plugin=""dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                        <thead>
                            <tr role=""row"">
                                <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 178px;"" aria-sort=""ascending"" aria-label=""Name: activate to sort column descending"">İsim</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""widt");
            WriteLiteral(@"h: 244px;"" aria-label=""Position: activate to sort column ascending"">E-mail</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 198px;"" aria-label=""Office: activate to sort column ascending"">Telefon</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 47px;"" aria-label=""Age: activate to sort column ascending"">Ülke</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 106px;"" aria-label=""Date: activate to sort column ascending"">Şehir</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 84px;"" aria-label=""Salary: activate to sort column ascending"">Adres</th>
                            </tr>
                        </thead>
                        <tfo");
            WriteLiteral(@"ot>
                            <tr>
                                <th rowspan=""1"" colspan=""1"">İsim</th>
                                <th rowspan=""1"" colspan=""1"">E-mail</th>
                                <th rowspan=""1"" colspan=""1"">Telefon</th>
                                <th rowspan=""1"" colspan=""1"">Ülke</th>
                                <th rowspan=""1"" colspan=""1"">Şehir</th>
                                <th rowspan=""1"" colspan=""1"">Adres</th>
                            </tr>
                        </tfoot>
                        <tbody>
");
            EndContext();
#line 38 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kullanici\KullaniciListele.cshtml"
                             foreach (var k in Model)
                            {

#line default
#line hidden
            BeginContext(2855, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(2934, 6, false);
#line 41 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kullanici\KullaniciListele.cshtml"
                                   Write(k.name);

#line default
#line hidden
            EndContext();
            BeginContext(2940, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2988, 6, false);
#line 42 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kullanici\KullaniciListele.cshtml"
                                   Write(k.mail);

#line default
#line hidden
            EndContext();
            BeginContext(2994, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3042, 11, false);
#line 43 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kullanici\KullaniciListele.cshtml"
                                   Write(k.telephone);

#line default
#line hidden
            EndContext();
            BeginContext(3053, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3101, 9, false);
#line 44 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kullanici\KullaniciListele.cshtml"
                                   Write(k.country);

#line default
#line hidden
            EndContext();
            BeginContext(3110, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3158, 10, false);
#line 45 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kullanici\KullaniciListele.cshtml"
                                   Write(k.province);

#line default
#line hidden
            EndContext();
            BeginContext(3168, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3216, 9, false);
#line 46 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kullanici\KullaniciListele.cshtml"
                                   Write(k.address);

#line default
#line hidden
            EndContext();
            BeginContext(3225, 46, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n");
            EndContext();
#line 48 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kullanici\KullaniciListele.cshtml"
                            }

#line default
#line hidden
            BeginContext(3302, 142, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Management_Panel.Models.Kullanici>> Html { get; private set; }
    }
}
#pragma warning restore 1591
