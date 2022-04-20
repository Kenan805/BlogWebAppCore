#pragma checksum "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Admin\AdminNavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6458c72c9c52e5fba54ebd28e4eb6edb6345d50e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminNavbarPartial), @"mvc.1.0.view", @"/Views/Admin/AdminNavbarPartial.cshtml")]
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
#line 1 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6458c72c9c52e5fba54ebd28e4eb6edb6345d50e", @"/Views/Admin/AdminNavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f33039d47efbf86f0686833dd0d216dada1e8708", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_AdminNavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin_pages/img/profile_small.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("<nav class=\"navbar-default navbar-static-side\" role=\"navigation\">\r\n\t\t\t<div class=\"sidebar-collapse\">\r\n\t\t\t\t<ul class=\"nav metismenu\" id=\"side-menu\">\r\n\t\t\t\t\t<li class=\"nav-header\">\r\n\t\t\t\t\t\t<div class=\"dropdown profile-element\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6458c72c9c52e5fba54ebd28e4eb6edb6345d50e4875", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
							<a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""#"">
								<span class=""block m-t-xs font-bold"">Kənan İdayatov</span>
								<span class=""text-muted text-xs block"">Proqlaşdırma mühəndisi <b class=""caret""></b></span>
							</a>
							<ul class=""dropdown-menu animated fadeInRight m-t-xs"">
								<li><a class=""dropdown-item"" href=""profile.html"">Profile</a></li>
								<li><a class=""dropdown-item"" href=""contacts.html"">Contacts</a></li>
								<li><a class=""dropdown-item"" href=""mailbox.html"">Mailbox</a></li>
								<li class=""dropdown-divider""></li>
								<li><a class=""dropdown-item"" href=""login.html"">Logout</a></li>
							</ul>
						</div>
						<div class=""logo-element"">
							IN+
						</div>
					</li>
					<li>
						<a href=""index.html""><i class=""fa fa-th-large""></i> <span class=""nav-label"">Dashboards</span> <span class=""fa arrow""></span></a>
						<ul class=""nav nav-second-level collapse"">
							<li><a href=""index.html"">Dashboard v.1</a></li>
							<li><a ");
            WriteLiteral(@"href=""dashboard_2.html"">Dashboard v.2</a></li>
							<li><a href=""dashboard_3.html"">Dashboard v.3</a></li>
							<li><a href=""dashboard_4_1.html"">Dashboard v.4</a></li>
							<li><a href=""dashboard_5.html"">Dashboard v.5 </a></li>
						</ul>
					</li>
					<li>
						<a href=""#""><i class=""fa fa-bar-chart-o""></i> <span class=""nav-label"">Qrafiklər</span><span class=""fa arrow""></span></a>
						<ul class=""nav nav-second-level collapse"">
							<li><a href=""graph_flot.html"">Flot Charts</a></li>
							<li><a href=""graph_morris.html"">Morris.js Charts</a></li>
							<li><a href=""graph_rickshaw.html"">Rickshaw Charts</a></li>
							<li><a href=""graph_chartjs.html"">Chart.js</a></li>
							<li><a href=""graph_chartist.html"">Chartist</a></li>
							<li><a href=""c3.html"">c3 charts</a></li>
							<li><a href=""graph_peity.html"">Peity Charts</a></li>
							<li><a href=""graph_sparkline.html"">Sparkline Charts</a></li>
						</ul>
					</li>
					<li>
						<a href=""mailbox.html""><i class=""fa fa-en");
            WriteLiteral(@"velope""></i> <span class=""nav-label"">Mesajlar </span><span class=""label label-warning float-right"">16/24</span></a>
						<ul class=""nav nav-second-level collapse"">
							<li><a href=""mailbox.html"">Inbox</a></li>
							<li><a href=""mail_detail.html"">Email view</a></li>
							<li><a href=""mail_compose.html"">Compose email</a></li>
							<li><a href=""email_template.html"">Email templates</a></li>
						</ul>
					</li>
					<li>
						<a href=""metrics.html""><i class=""fa fa-pie-chart""></i> <span class=""nav-label"">Metriklər</span>  </a>
					</li>
					<li>
						<a href=""metrics.html""><i class=""fa fa-group""></i> <span class=""nav-label"">Kateqoriyalar</span>  </a>
					</li>
					<li>
						<a href=""metrics.html""><i class=""fa fa-list""></i> <span class=""nav-label"">Bloqlar</span>  </a>
					</li>
					<li>
						<a href=""metrics.html""><i class=""fa fa-comment""></i> <span class=""nav-label"">Rəylər</span>  </a>
					</li>
					<li>
						<a href=""metrics.html""><i class=""fa fa-user""></i> <span clas");
            WriteLiteral(@"s=""nav-label"">Yazıçılar</span>  </a>
					</li>
					<li>
						<a href=""metrics.html""><i class=""fa fa-info""></i> <span class=""nav-label"">Ayarlar</span>  </a>
					</li>
					<li>
						<a href=""metrics.html""><i class=""fa fa-diamond""></i> <span class=""nav-label"">Bildirişlər</span>  </a>
					</li>
					<li>
						<a href=""metrics.html""><i class=""fa fa-phone""></i> <span class=""nav-label"">Əlaqə</span>  </a>
					</li>
					<li>
						<a href=""metrics.html""><i class=""fa fa-address-book""></i> <span class=""nav-label"">Haqqımızda</span>  </a>
					</li>
					<li>
						<a href=""widgets.html""><i class=""fa fa-flask""></i> <span class=""nav-label"">Statistika</span></a>m
					</li>
					<li>
						<a href=""#""><i class=""fa fa-edit""></i> <span class=""nav-label"">Formlar</span><span class=""fa arrow""></span></a>
						<ul class=""nav nav-second-level collapse"">
							<li><a href=""form_basic.html"">Basic form</a></li>
							<li><a href=""form_advanced.html"">Advanced Plugins</a></li>
							<li><a href=""form");
            WriteLiteral(@"_wizard.html"">Wizard</a></li>
							<li><a href=""form_file_upload.html"">File Upload</a></li>
							<li><a href=""form_editors.html"">Text Editor</a></li>
							<li><a href=""form_autocomplete.html"">Autocomplete</a></li>
							<li><a href=""form_markdown.html"">Markdown</a></li>
						</ul>
					</li>
					<li class=""active"">
						<a href=""#""><i class=""fa fa-table""></i> <span class=""nav-label"">Cədvəllər</span><span class=""fa arrow""></span></a>
						<ul class=""nav nav-second-level"">
							<li class=""active""><a href=""table_basic.html"">Static Tables</a></li>
							<li><a href=""table_data_tables.html"">Data Tables</a></li>
							<li><a href=""table_foo_table.html"">Foo Tables</a></li>
							<li><a href=""jq_grid.html"">jqGrid</a></li>
						</ul>
					</li>
					<li>
						<a href=""#""><i class=""fa fa-picture-o""></i> <span class=""nav-label"">Qaleriya</span><span class=""fa arrow""></span></a>
						<ul class=""nav nav-second-level collapse"">
							<li><a href=""basic_gallery.html"">Lightbox Gallery</a");
            WriteLiteral("></li>\r\n\t\t\t\t\t\t\t<li><a href=\"slick_carousel.html\">Slick Carousel</a></li>\r\n\t\t\t\t\t\t\t<li><a href=\"carousel.html\">Bootstrap Carousel</a></li>\r\n\r\n\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t</li>\r\n\t\t\t\t</ul>\r\n\r\n\t\t\t</div>\r\n\t\t</nav>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591