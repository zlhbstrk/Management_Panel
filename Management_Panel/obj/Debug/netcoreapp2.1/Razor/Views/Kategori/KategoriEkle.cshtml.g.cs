#pragma checksum "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kategori\KategoriEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31b0d0eae5717374e737dab75615940b4d830802"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kategori_KategoriEkle), @"mvc.1.0.view", @"/Views/Kategori/KategoriEkle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kategori/KategoriEkle.cshtml", typeof(AspNetCore.Views_Kategori_KategoriEkle))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31b0d0eae5717374e737dab75615940b4d830802", @"/Views/Kategori/KategoriEkle.cshtml")]
    public class Views_Kategori_KategoriEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Management_Panel.Models.Kategori>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kategori\KategoriEkle.cshtml"
  
    ViewData["Title"] = "KategoriEkle";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 6 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kategori\KategoriEkle.cshtml"
 if (ViewBag.Sonuc != "")
{

#line default
#line hidden
            BeginContext(172, 304, true);
            WriteLiteral(@"    <div class=""alert alert-success alert-dismissible fade show"" role=""alert"">
        <strong>Kategori başarıyla eklendi!</strong>
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
");
            EndContext();
#line 14 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kategori\KategoriEkle.cshtml"
}

#line default
#line hidden
            BeginContext(479, 776, true);
            WriteLiteral(@"<div class=""panel"">
    <header class=""panel-heading"">
        <div class=""panel-actions""></div>
        <h3 class=""panel-title"">Kategori Ekle</h3>
    </header>
    <div class=""panel-body"">
        <form action=""/Kategori/KategoriEkle"" method=""post"">
            <div class=""row"">
                <div class=""col-md-3"">Ad: </div>
                <div class=""col-md-3""><input type=""text"" name=""name"" placeholder=""Kategori adını giriniz."" class=""form-control"" /> </div>
            </div>
            <div class=""row"" style=""margin-top:15px"">
                <div class=""col-md-3"">Üst Kategori Ad: </div>
                <div class=""col-md-3"">
                    <select name=""id"" class=""form-control"">
                        <option value=""yok"">Yok</option>
");
            EndContext();
#line 31 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kategori\KategoriEkle.cshtml"
                         foreach (var k in Model)
                        {

#line default
#line hidden
            BeginContext(1333, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1368, "\"", 1381, 1);
#line 33 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kategori\KategoriEkle.cshtml"
WriteAttributeValue("", 1376, k.id, 1376, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1382, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1384, 6, false);
#line 33 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kategori\KategoriEkle.cshtml"
                                             Write(k.name);

#line default
#line hidden
            EndContext();
            BeginContext(1390, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 34 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Kategori\KategoriEkle.cshtml"
                        }

#line default
#line hidden
            BeginContext(1428, 401, true);
            WriteLiteral(@"                    </select>
                </div>
            </div>
            <div class=""row"" style=""margin-top:15px"">
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Management_Panel.Models.Kategori>> Html { get; private set; }
    }
}
#pragma warning restore 1591
