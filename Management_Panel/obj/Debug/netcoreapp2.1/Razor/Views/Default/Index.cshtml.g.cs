#pragma checksum "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01057967527a661c081474b69acd418aa6afe404"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Default/Index.cshtml", typeof(AspNetCore.Views_Default_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01057967527a661c081474b69acd418aa6afe404", @"/Views/Default/Index.cshtml")]
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/global/vendor/tablesaw/tablesaw.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/global/vendor/tablesaw/tablesaw.jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/global/js/Plugin/tablesaw.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Default\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(56, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c25bc6d0da594108a6b7b20c6aad58f6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(124, 4091, true);
            WriteLiteral(@"

<div class=""col-xl-12 col md-12"">
    <div class=""panel"">
        <header class=""panel-heading"">
            <h3 class=""panel-title"">Swipe</h3>
        </header>
        <div class=""panel-body"">
            <div class=""tablesaw-bar tablesaw-mode-swipe tablesaw-all-cols-visible""><div class=""tablesaw-advance""><a href=""#"" class=""tablesaw-nav-btn btn btn-micro left disabled waves-effect waves-classic"" title=""Previous Column""></a><a href=""#"" class=""tablesaw-nav-btn btn btn-micro right waves-effect waves-classic disabled"" title=""Next Column""></a></div><div class=""tablesaw-advance minimap"" style=""display: block;""><ul class=""tablesaw-advance-dots""><li><i></i></li><li><i></i></li><li><i></i></li><li><i></i></li><li><i></i></li><li><i></i></li><li><i></i></li><li><i></i></li><li class=""""><i></i></li><li class=""""><i></i></li></ul></div></div><table class=""tablesaw table-hover table-bordered tablesaw-swipe"" data-tablesaw-mode=""swipe"" data-tablesaw-minimap="""" id=""tablesaw-794"">
                <thead>
        ");
            WriteLiteral(@"            <tr>
                        <th data-tablesaw-priority=""persist"" class=""tablesaw-cell-persist"">Name</th>
                        <th>Rank</th>
                        <th>Money</th>
                        <th>Money</th>
                        <th>A (1–5)</th>
                        <th>B (1–5)</th>
                        <th>C (%)</th>
                        <th>D (1–5)</th>
                        <th class="""">E (1–5)</th>
                        <th class="""">F (1–5)</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th class=""tablesaw-cell-persist""><a href=""javascript:void(0)"">Amanda</a></th>
                        <td>1</td>
                        <td>18.72</td>
                        <td>18.72</td>
                        <td>5</td>
                        <td>5</td>
                        <td>98</td>
                        <td>4</td>
                        <td class="""">5</td>
   ");
            WriteLiteral(@"                     <td class=""""><button type=""button"" class=""btn btn-block btn-warning waves-effect waves-classic"" style=""width:100px;"">Detay</button></td>
                    </tr>
                    <tr>
                        <th class=""tablesaw-cell-persist""><a href=""javascript:void(0)"">Dave</a></th>
                        <td>2</td>
                        <td>20.52</td>
                        <td>20.52</td>
                        <td>4</td>
                        <td>3</td>
                        <td>87</td>
                        <td>5</td>
                        <td class="""">3</td>
                        <td class=""""><button type=""button"" class=""btn btn-block btn-info waves-effect waves-classic"">Detay</button></td>
                    </tr>
                    <tr>
                        <th class=""tablesaw-cell-persist""><a href=""javascript:void(0)"">Kristen</a></th>
                        <td>3</td>
                        <td>21.36</td>
                        <td>21.3");
            WriteLiteral(@"6</td>
                        <td>2</td>
                        <td>5</td>
                        <td>89</td>
                        <td>4</td>
                        <td class="""">5</td>
                        <td class="""">3</td>
                    </tr>
                    <tr>
                        <th class=""tablesaw-cell-persist""><a href=""javascript:void(0)"">Kenny</a></th>
                        <td>4</td>
                        <td>27.15</td>
                        <td>27.15</td>
                        <td>4</td>
                        <td>4</td>
                        <td>98</td>
                        <td>5</td>
                        <td class="""">4</td>
                        <td class="""">3</td>
                    </tr>
                </tbody>
            </table>
            <br />
            <button type=""button"" class=""btn btn-block btn-primary waves-effect waves-classic"" style=""width:100px;"">Primary</button>

        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(4215, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55808067769846a9bc22f0b922f0017b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4282, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4284, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76d45537dc1647a79c5bd16a919a9826", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
