#pragma checksum "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Urun\UrunEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6204d638320bc2da589a1b3a43fc9f6cfd5608e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Urun_UrunEkle), @"mvc.1.0.view", @"/Views/Urun/UrunEkle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Urun/UrunEkle.cshtml", typeof(AspNetCore.Views_Urun_UrunEkle))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6204d638320bc2da589a1b3a43fc9f6cfd5608e3", @"/Views/Urun/UrunEkle.cshtml")]
    public class Views_Urun_UrunEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Urun\UrunEkle.cshtml"
  
    ViewData["Title"] = "UrunEkle";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(91, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Urun\UrunEkle.cshtml"
 if (ViewBag.Eklenen != "")
{

#line default
#line hidden
            BeginContext(125, 96, true);
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n        <strong>");
            EndContext();
            BeginContext(222, 15, false);
#line 9 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Urun\UrunEkle.cshtml"
           Write(ViewBag.Eklenen);

#line default
#line hidden
            EndContext();
            BeginContext(237, 206, true);
            WriteLiteral(" ürünü başarıyla eklendi!</strong>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
            EndContext();
#line 14 "C:\Users\Harun Demir\Desktop\balbocegigida_panel\Management_Panel\Management_Panel\Views\Urun\UrunEkle.cshtml"
}

#line default
#line hidden
            BeginContext(446, 2329, true);
            WriteLiteral(@"<div class=""panel"">
    <header class=""panel-heading"">
        <div class=""panel-actions""></div>
        <h3 class=""panel-title"">Ürün Ekle</h3>
    </header>
    <div class=""panel-body"">
        <form action=""/Urun/UrunEkle"" method=""post"">
            <div class=""row"">
                <div class=""col-md-3"">Ad: </div>
                <div class=""col-md-3""><input type=""text"" name=""name"" placeholder=""Ürün adını giriniz."" class=""form-control"" /> </div>
            </div>
            <div class=""row"" style=""margin-top:15px"">
                <div class=""col-md-3""><label for=""description"">Açıklama: </label> </div>
                <div class=""col-md-3"">  <textarea id=""description"" name=""description"" rows=""5"" placeholder=""Ürün açıklamasını giriniz."" class=""form-control""></textarea></div>
            </div>
            <div class=""row"" style=""margin-top:15px"">
                <div class=""col-md-3"">Fiyat: </div>
                <div class=""col-md-3""><input type=""text"" name=""price"" placeholder=""Ürün fiya");
            WriteLiteral(@"tı giriniz."" class=""form-control"" /> </div>
            </div>
            <div class=""row"" style=""margin-top:15px"">
                <div class=""col-md-3"">Resim: </div>
                <div class=""col-md-3""><input type=""file"" name=""image"" class=""form-control"" /> </div>
            </div>
            <div class=""row"" style=""margin-top:15px"">
                <div class=""col-md-3"">Stok Durumu: </div>
                <div class=""col-md-3"">
                    <select name=""isStock"" class=""form-control"">
                        <option value=""1"" selected>Var</option>
                        <option value=""0"">Yok</option>
                    </select>
                </div>
            </div>
            <div class=""row"" style=""margin-top:15px"">
                <div class=""col-md-3"">Miktar: </div>
                <div class=""col-md-3""><input type=""text"" name=""quantity"" placeholder=""Ürün miktarını giriniz."" class=""form-control"" /> </div>
            </div>
            <div class=""row"" style=""margi");
            WriteLiteral(@"n-top:15px"">
                <div class=""col-md-3""></div>
                <div class=""col-md-3"">
                    <input type=""submit"" value=""Kaydet"" class=""btn-block btn-info form-control"" />
                </div>
            </div>
        </form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
