#pragma checksum "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10f26dc907c219f26ca61a376b1487411b4abefe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10f26dc907c219f26ca61a376b1487411b4abefe", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("animsition dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 61, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html class=\"no-js css-menubar\" lang=\"en\">\r\n");
            EndContext();
            BeginContext(61, 2554, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "371d9e88e9d2402f9df5f24d309229f9", async() => {
                BeginContext(67, 2541, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui"">
    <meta name=""description"" content=""bootstrap admin template"">
    <meta name=""author"" content="""">
    <title>Dashboard | Remark Admin Template</title>
    <link rel=""apple-touch-icon"" href=""/assets/images/apple-touch-icon.png"">
    <link rel=""shortcut icon"" href=""/assets/images/favicon.ico"">
    <link rel=""stylesheet"" href=""/global/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""/global/css/bootstrap-extend.min.css"">
    <link rel=""stylesheet"" href=""/assets/css/site.min.css"">
    <!-- Plugins -->
    <link rel=""stylesheet"" href=""/global/vendor/animsition/animsition.css"">
    <link rel=""stylesheet"" href=""/global/vendor/asscrollable/asScrollable.css"">
    <link rel=""stylesheet"" href=""/global/vendor/switchery/switchery.css"">
    <link rel=""stylesheet"" href=""/global/vendor/intro-js/introjs.css"">
  ");
                WriteLiteral(@"  <link rel=""stylesheet"" href=""/global/vendor/slidepanel/slidePanel.css"">
    <link rel=""stylesheet"" href=""/global/vendor/flag-icon-css/flag-icon.css"">
    <link rel=""stylesheet"" href=""/global/vendor/waves/waves.css"">
    <link rel=""stylesheet"" href=""/global/vendor/datatables-bootstrap/dataTables.bootstrap.css"">
    <link rel=""stylesheet"" href=""/global/vendor/datatables-fixedheader/dataTables.fixedHeader.css"">
    <link rel=""stylesheet"" href=""/global/vendor/datatables-responsive/dataTables.responsive.css"">
    <link rel=""stylesheet"" href=""/global/vendor/datatables-buttons/dataTables.buttons.css"">
    <link rel=""stylesheet"" href=""/assets/examples/css/tables/datatable.css"">
    <!-- Fonts -->
    <link rel=""stylesheet"" href=""/global/fonts/font-awesome/font-awesome.css"">
    <link rel=""stylesheet"" href=""/global/fonts/material-design/material-design.min.css"">
    <link rel=""stylesheet"" href=""/global/fonts/brand-icons/brand-icons.min.css"">
    <link rel='stylesheet' href='http://fonts.googleapis.com/cs");
                WriteLiteral(@"s?family=Roboto:300,400,500,300italic'>
    <!--[if lt IE 9]>
      <script src=""/global/vendor/html5shiv/html5shiv.min.js""></script>
      <![endif]-->
    <!--[if lt IE 10]>
      <script src=""/global/vendor/media-match/media.match.min.js""></script>
      <script src=""/global/vendor/respond/respond.min.js""></script>
      <![endif]-->
    <!-- Scripts -->
    <script src=""/global/vendor/breakpoints/breakpoints.js""></script>
    <script>
        Breakpoints();
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2615, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2617, 12058, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdda0d7b98b0486d9d29857fc3bd23f3", async() => {
                BeginContext(2652, 8553, true);
                WriteLiteral(@"
    <!--[if lt IE 8]>
          <p class=""browserupgrade"">You are using an <strong>outdated</strong> browser. Please <a href=""http://browsehappy.com/"">upgrade your browser</a> to improve your experience.</p>
      <![endif]-->
    <nav class=""site-navbar navbar navbar-default navbar-fixed-top navbar-mega"" role=""navigation"">
        <div class=""navbar-header"">
            <button type=""button"" class=""navbar-toggler hamburger hamburger-close navbar-toggler-left hided""
                    data-toggle=""menubar"">
                <span class=""sr-only"">Toggle navigation</span>
                <span class=""hamburger-bar""></span>
            </button>
            <button type=""button"" class=""navbar-toggler collapsed"" data-target=""#site-navbar-collapse""
                    data-toggle=""collapse"">
                <i class=""icon md-more"" aria-hidden=""true""></i>
            </button>
            <div class=""navbar-brand navbar-brand-center site-gridmenu-toggle"" data-toggle=""gridmenu"">
                <img");
                WriteLiteral(@" class=""navbar-brand-logo"" src=""/assets/images/logo.png"" title=""Remark"">
                <span class=""navbar-brand-text hidden-xs-down"">Balböceği Gıda</span>
            </div>
            <button type=""button"" class=""navbar-toggler collapsed"" data-target=""#site-navbar-search""
                    data-toggle=""collapse"">
                <span class=""sr-only"">Toggle Search</span>
                <i class=""icon md-search"" aria-hidden=""true""></i>
            </button>
        </div>
        <div class=""navbar-container container-fluid"">
            <!-- Navbar Collapse -->
            <div class=""collapse navbar-collapse navbar-collapse-toolbar"" id=""site-navbar-collapse"">
                <!-- Navbar Toolbar -->
                <ul class=""nav navbar-toolbar"">
                    <li class=""nav-item hidden-float"" id=""toggleMenubar"">
                        <a class=""nav-link"" data-toggle=""menubar"" href=""#"" role=""button"">
                            <i class=""icon hamburger hamburger-arrow-left"">
  ");
                WriteLiteral(@"                              <span class=""sr-only"">Toggle menubar</span>
                                <span class=""hamburger-bar""></span>
                            </i>
                        </a>
                    </li>
                </ul>
                <!-- End Navbar Toolbar -->
                <!-- Navbar Toolbar Right -->
                <ul class=""nav navbar-toolbar navbar-right navbar-toolbar-right"">
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link navbar-avatar"" data-toggle=""dropdown"" href=""#"" aria-expanded=""false""
                           data-animation=""scale-up"" role=""button"">
                            <span class=""avatar avatar-online"">
                                <img src=""/global/portraits/5.jpg"" alt=""..."">
                                <i></i>
                            </span>
                        </a>
                        <div class=""dropdown-menu"" role=""menu"">
                            <a class=""dr");
                WriteLiteral(@"opdown-item"" href=""javascript:void(0)"" role=""menuitem""><i class=""icon md-account"" aria-hidden=""true""></i> Profile</a>
                            <a class=""dropdown-item"" href=""javascript:void(0)"" role=""menuitem""><i class=""icon md-card"" aria-hidden=""true""></i> Billing</a>
                            <a class=""dropdown-item"" href=""javascript:void(0)"" role=""menuitem""><i class=""icon md-settings"" aria-hidden=""true""></i> Settings</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""javascript:void(0)"" role=""menuitem""><i class=""icon md-power"" aria-hidden=""true""></i> Logout</a>
                        </div>
                    </li>
                </ul>
                <!-- End Navbar Toolbar Right -->
            </div>
            <!-- End Navbar Collapse -->
            <!-- Site Navbar Seach -->
            <div class=""collapse navbar-search-overlap"" id=""site-navbar-search"">
                <form role=""search"">
           ");
                WriteLiteral(@"         <div class=""form-group"">
                        <div class=""input-search"">
                            <i class=""input-search-icon md-search"" aria-hidden=""true""></i>
                            <input type=""text"" class=""form-control"" name=""site-search"" placeholder=""Search..."">
                            <button type=""button"" class=""input-search-close icon md-close"" data-target=""#site-navbar-search""
                                    data-toggle=""collapse"" aria-label=""Close""></button>
                        </div>
                    </div>
                </form>
            </div>
            <!-- End Site Navbar Seach -->
        </div>
    </nav>
    <div class=""site-menubar"">
        <div class=""site-menubar-body"">
            <div>
                <div>
                    <ul class=""site-menu"" data-plugin=""menu"">
                        <li class=""site-menu-item active"">
                            <a class=""animsition-link"" href=""#"">
                                <i c");
                WriteLiteral(@"lass=""site-menu-icon md-view-dashboard"" aria-hidden=""true""></i>
                                <span class=""site-menu-title"">Kullanıcı Listele</span>
                            </a>
                        </li>
                        <li class=""site-menu-item"">
                            <a class=""animsition-link"" href=""#"">
                                <i class=""site-menu-icon md-view-dashboard"" aria-hidden=""true""></i>
                                <span class=""site-menu-title"">Sipariş Listele</span>
                            </a>
                        </li>
                        <li class=""site-menu-item has-sub"">
                            <a href=""javascript:void(0)"">
                                <i class=""site-menu-icon md-view-compact"" aria-hidden=""true""></i>
                                <span class=""site-menu-title"">Ürün</span>
                                <span class=""site-menu-arrow""></span>
                            </a>
                            <ul clas");
                WriteLiteral(@"s=""site-menu-sub"">
                                <li class=""site-menu-item"">
                                    <a class=""animsition-link"" href=""#"">
                                        <span class=""site-menu-title"">Ürün Listele</span>
                                    </a>
                                </li>
                                <li class=""site-menu-item"">
                                    <a class=""animsition-link"" href=""#"">
                                        <span class=""site-menu-title"">Ürün Ekle</span>
                                    </a>
                                </li>
                            </ul>
                        </li>
                        <li class=""site-menu-item has-sub"">
                            <a href=""javascript:void(0)"">
                                <i class=""site-menu-icon md-view-compact"" aria-hidden=""true""></i>
                                <span class=""site-menu-title"">Kategori</span>
                             ");
                WriteLiteral(@"   <span class=""site-menu-arrow""></span>
                            </a>
                            <ul class=""site-menu-sub"">
                                <li class=""site-menu-item"">
                                    <a class=""animsition-link"" href=""#"">
                                        <span class=""site-menu-title"">Kategori Listele</span>
                                    </a>
                                </li>
                                <li class=""site-menu-item"">
                                    <a class=""animsition-link"" href=""#"">
                                        <span class=""site-menu-title"">Kategori Ekle</span>
                                    </a>
                                </li>
                            </ul>
                        </li>
                        <li class=""site-menu-item"">
                            <a class=""animsition-link"" href=""#"">
                                <i class=""site-menu-icon md-view-dashboard"" aria-hidden=");
                WriteLiteral(@"""true""></i>
                                <span class=""site-menu-title"">Kargo Firma Seçeneği</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>

    <!-- Page -->
    <div class=""page"">
        <div class=""page-content"">
            ");
                EndContext();
                BeginContext(11206, 12, false);
#line 194 "C:\Users\zlhbs\Desktop\Management_Panel\Management_Panel\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(11218, 3450, true);
                WriteLiteral(@"
        </div>
    </div>
    <!-- End Page -->
    <!-- Footer -->
    <footer class=""site-footer"">
        <div class=""site-footer-legal"">© 2020 <a href=""http://www.balbocegigida.com/"">www.balbocegigida.com</a></div>
        <div class=""site-footer-right"">
            Crafted with <i class=""red-600 icon md-favorite""></i> by <a href=""#"">Hazel</a>
        </div>
    </footer>

    <!-- Core  -->
    <script src=""/global/vendor/babel-external-helpers/babel-external-helpers.js""></script>
    <script src=""/global/vendor/jquery/jquery.js""></script>
    <script src=""/global/vendor/tether/tether.js""></script>
    <script src=""/global/vendor/bootstrap/bootstrap.js""></script>
    <script src=""/global/vendor/animsition/animsition.js""></script>
    <script src=""/global/vendor/mousewheel/jquery.mousewheel.js""></script>
    <script src=""/global/vendor/asscrollbar/jquery-asScrollbar.js""></script>
    <script src=""/global/vendor/asscrollable/jquery-asScrollable.js""></script>
    <script src=""/global/v");
                WriteLiteral(@"endor/ashoverscroll/jquery-asHoverScroll.js""></script>
    <script src=""/global/vendor/waves/waves.js""></script>
    <!-- Plugins -->
    <script src=""/global/vendor/switchery/switchery.min.js""></script>
    <script src=""/global/vendor/intro-js/intro.js""></script>
    <script src=""/global/vendor/screenfull/screenfull.js""></script>
    <script src=""/global/vendor/slidepanel/jquery-slidePanel.js""></script>
    <script src=""/global/vendor/datatables/jquery.dataTables.js""></script>
    <script src=""/global/vendor/datatables-fixedheader/dataTables.fixedHeader.js""></script>
    <script src=""/global/vendor/datatables-bootstrap/dataTables.bootstrap.js""></script>
    <script src=""/global/vendor/datatables-responsive/dataTables.responsive.js""></script>
    <script src=""/global/vendor/datatables-buttons/dataTables.buttons.js""></script>
    <script src=""/global/vendor/datatables-buttons/buttons.html5.js""></script>
    <script src=""/global/vendor/datatables-buttons/buttons.flash.js""></script>
    <script src");
                WriteLiteral(@"=""/global/vendor/datatables-buttons/buttons.print.js""></script>
    <script src=""/global/vendor/asrange/jquery-asRange.min.js""></script>
    <script src=""/global/vendor/bootbox/bootbox.js""></script>
    <!-- Scripts -->
    <script src=""/global/js/State.js""></script>
    <script src=""/global/js/Component.js""></script>
    <script src=""/global/js/Plugin.js""></script>
    <script src=""/global/js/Base.js""></script>
    <script src=""/global/js/Config.js""></script>
    <script src=""/assets/js/Section/Menubar.js""></script>
    <script src=""/assets/js/Section/GridMenu.js""></script>
    <script src=""/assets/js/Section/Sidebar.js""></script>
    <script src=""/assets/js/Section/PageAside.js""></script>
    <script src=""/assets/js/Plugin/menu.js""></script>
    <script src=""/global/js/config/colors.js""></script>
    <script src=""/assets/js/config/tour.js""></script>
    <script>
        Config.set('assets', '../../assets');
    </script>
    <!-- Page -->
    <script src=""/assets/js/Site.js""></script>
 ");
                WriteLiteral(@"   <script src=""/global/js/Plugin/asscrollable.js""></script>
    <script src=""/global/js/Plugin/slidepanel.js""></script>
    <script src=""/global/js/Plugin/switchery.js""></script>
    <script src=""/global/js/Plugin/datatables.js""></script>
    <script src=""/assets/examples/js/tables/datatable.js""></script>
    <script src=""/assets/examples/js/uikit/icon.js""></script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14675, 9, true);
            WriteLiteral("\r\n</html>");
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
