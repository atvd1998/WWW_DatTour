#pragma checksum "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a7f6c1d9126fc7b232cd85f8620d9a164565aed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
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
#line 1 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
using TourCore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a7f6c1d9126fc7b232cd85f8620d9a164565aed", @"/Views/Shared/Components/Menu/Default.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
  
    string member = ViewBag.Session;

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"menu ml-auto mt-1\">\r\n    <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 137, "\"", 171, 1);
#nullable restore
#line 6 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 144, Url.Action("Index","Home"), 144, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trang chủ</a></li>\r\n    <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 218, "\"", 255, 1);
#nullable restore
#line 7 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 225, Url.Action("Domestic","Tour"), 225, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trong Nước</a></li>\r\n    <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 303, "\"", 340, 1);
#nullable restore
#line 8 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 310, Url.Action("National","Tour"), 310, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ngoài Nước</a></li>\r\n");
#nullable restore
#line 9 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
     if (ViewBag.Session != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"active\"><a>Chào ");
#nullable restore
#line 11 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
                              Write(member);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n        <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 487, "\"", 522, 1);
#nullable restore
#line 12 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 494, Url.Action("Logout","Home"), 494, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đăng xuất</a></li>\r\n");
#nullable restore
#line 13 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 597, "\"", 632, 1);
#nullable restore
#line 16 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 604, Url.Action("Login", "Home"), 604, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đăng nhập</a></li>\r\n        <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 683, "\"", 721, 1);
#nullable restore
#line 17 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 690, Url.Action("Register", "Home"), 690, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đăng ký</a></li>\r\n");
#nullable restore
#line 18 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Shared\Components\Menu\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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