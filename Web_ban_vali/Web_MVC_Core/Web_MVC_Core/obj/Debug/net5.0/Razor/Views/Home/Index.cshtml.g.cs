#pragma checksum "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8726559112ceade56e0928e1a7e6ab2a39429288"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\_ViewImports.cshtml"
using Web_MVC_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\_ViewImports.cshtml"
using Web_MVC_Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8726559112ceade56e0928e1a7e6ab2a39429288", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a78e386efeba08aae6dd3ea5d099146cb9ffba5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<TDanhMucSp>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_LayoutOgani.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\Home\Index.cshtml"
 foreach(var item in Model) { 
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("PartialSanPham", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\Home\Index.cshtml"
                                                    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"margin:0 auto\">\r\n    ");
#nullable restore
#line 12 "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\Home\Index.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page = page }), new PagedListRenderOptions
{
    LiElementClasses = new string[] { "page-item" },
    UlElementClasses = new string[] { "pagination justify-content-center" },
    PageClasses = new string[] { "page-link" }
}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n    \r\n    \r\n          \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<TDanhMucSp>> Html { get; private set; }
    }
}
#pragma warning restore 1591
