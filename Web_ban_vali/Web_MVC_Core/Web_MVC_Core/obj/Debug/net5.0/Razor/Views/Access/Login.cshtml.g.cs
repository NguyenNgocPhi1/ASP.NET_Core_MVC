#pragma checksum "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\Access\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a83cb75e24c5c58bce715cde8befa9a9e9c4f63d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Access_Login), @"mvc.1.0.view", @"/Views/Access/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83cb75e24c5c58bce715cde8befa9a9e9c4f63d", @"/Views/Access/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a78e386efeba08aae6dd3ea5d099146cb9ffba5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Access_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TUser>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\Access\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a83cb75e24c5c58bce715cde8befa9a9e9c4f63d3464", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Purple Admin</title>
    <!-- plugins:css -->
    <link rel=""stylesheet"" href=""../../LayoutAdmin/assets/vendors/mdi/css/materialdesignicons.min.css"">
    <link rel=""stylesheet"" href=""../../LayoutAdmin/assets/vendors/css/vendor.bundle.base.css"">
    <!-- endinject -->
    <!-- Plugin css for this page -->
    <!-- End plugin css for this page -->
    <!-- inject:css -->
    <!-- endinject -->
    <!-- Layout styles -->
    <link rel=""stylesheet"" href=""../../LayoutAdmin/assets/css/style.css"">
    <!-- End layout styles -->
    <link rel=""shortcut icon"" href=""../../LayoutAdmin/assets/images/favicon.ico"" />
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a83cb75e24c5c58bce715cde8befa9a9e9c4f63d5239", async() => {
                WriteLiteral(@"
    <div class=""container-scroller"">
        <div class=""container-fluid page-body-wrapper full-page-wrapper"">
            <div class=""content-wrapper d-flex align-items-center auth"">
                <div class=""row flex-grow"">
                    <div class=""col-lg-4 mx-auto"">
                        <div class=""auth-form-light text-left p-5"">
                            <div class=""brand-logo"">
                                <img src=""../../LayoutAdmin/assets/images/logo.svg"">
                            </div>
                            <h4>Hello! let's get started</h4>
                            <h6 class=""font-weight-light"">Sign in to continue.</h6>
");
#nullable restore
#line 40 "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\Access\Login.cshtml"
                                 using (Html.BeginForm("Login", "Access", FormMethod.Post))
                                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"form-group\">\r\n                                    ");
#nullable restore
#line 44 "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\Access\Login.cshtml"
                               Write(Html.TextBoxFor(x => x.Username, new { @class = "form-control form-control-lg", placeholder = "Username", required = "required", autofocus = "autofocus" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                                </div>\r\n                                <div class=\"form-group\">\r\n                                    ");
#nullable restore
#line 48 "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\Access\Login.cshtml"
                               Write(Html.TextBoxFor(x => x.Password, new { @class = "form-control form-control-lg", type = "password", placeholder = "Password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                                </div>
                                <div class=""mt-3"">
                                    <button class=""btn btn-block btn-gradient-primary btn-lg font-weight-medium auth-form-btn"" type=""submit"">
                                        SIGN IN
                                    </button>
");
                WriteLiteral(@"                                </div>
                                <div class=""my-2 d-flex justify-content-between align-items-center"">
                                    <div class=""form-check"">
                                        <label class=""form-check-label text-muted"">
                                            <input type=""checkbox"" class=""form-check-input""> Keep me signed in
                                        </label>
                                    </div>
                                    <a href=""#"" class=""auth-link text-black"">Forgot password?</a>
                                </div>
");
                WriteLiteral("                                <div class=\"text-center mt-4 font-weight-light\">\r\n                                    Don\'t have an account? <a href=\"register.html\" class=\"text-primary\">Create</a>\r\n                                </div>\r\n");
#nullable restore
#line 69 "D:\Web_ban_vali\Web_MVC_Core\Web_MVC_Core\Views\Access\Login.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <!-- content-wrapper ends -->
        </div>
        <!-- page-body-wrapper ends -->
    </div>
    <!-- container-scroller -->
    <!-- plugins:js -->
    <script src=""../../LayoutAdmin/assets/vendors/js/vendor.bundle.base.js""></script>
    <!-- endinject -->
    <!-- Plugin js for this page -->
    <!-- End plugin js for this page -->
    <!-- inject:js -->
    <script src=""../../LayoutAdmin/assets/js/off-canvas.js""></script>
    <script src=""../../LayoutAdmin/assets/js/hoverable-collapse.js""></script>
    <script src=""../../LayoutAdmin/assets/js/misc.js""></script>
    <!-- endinject -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
