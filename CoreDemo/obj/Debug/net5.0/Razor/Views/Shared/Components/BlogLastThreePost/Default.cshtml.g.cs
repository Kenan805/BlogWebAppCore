#pragma checksum "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f92d91547ae70f2b4d0dbd7364da580e1d4d0e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLastThreePost_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLastThreePost/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f92d91547ae70f2b4d0dbd7364da580e1d4d0e4", @"/Views/Shared/Components/BlogLastThreePost/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca0fc599d5f51e519f75ff6712b592ffabce4a7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogLastThreePost_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n\t<h3>Son Postlar</h3>\r\n");
#nullable restore
#line 5 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
     foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"blog-grids row mb-3\">\r\n\r\n\t\t\t<div class=\"col-md-5 blog-grid-left\">\r\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 190, "\"", 227, 2);
            WriteAttributeValue("", 197, "/Blog/BlogReadAll/", 197, 18, true);
#nullable restore
#line 10 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
WriteAttributeValue("", 215, item.BlogID, 215, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 240, "\"", 261, 1);
#nullable restore
#line 11 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
WriteAttributeValue("", 246, item.BlogImage, 246, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 293, "\"", 299, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t</a>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-md-7 blog-grid-right\">\r\n\r\n\t\t\t\t<h5>\r\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 386, "\"", 423, 2);
            WriteAttributeValue("", 393, "/Blog/BlogReadAll/", 393, 18, true);
#nullable restore
#line 17 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
WriteAttributeValue("", 411, item.BlogID, 411, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
                                                        Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n\t\t\t\t</h5>\r\n\t\t\t\t<div class=\"sub-meta\">\r\n\t\t\t\t\t<span>\r\n\t\t\t\t\t\t<i class=\"far fa-clock\"></i> ");
#nullable restore
#line 21 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
                                                 Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</span>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\r\n\t\t</div>\r\n");
#nullable restore
#line 27 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591