#pragma checksum "D:\A_Githup\thisOnline\two\Againmvc\E-commerce-platform-MVC\UI\Views\Tabycx\AllTapStatistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d6e0a7020af40d3922978c7624ec1d72df32d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tabycx_AllTapStatistics), @"mvc.1.0.view", @"/Views/Tabycx/AllTapStatistics.cshtml")]
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
#line 1 "D:\A_Githup\thisOnline\two\Againmvc\E-commerce-platform-MVC\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\A_Githup\thisOnline\two\Againmvc\E-commerce-platform-MVC\UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89d6e0a7020af40d3922978c7624ec1d72df32d7", @"/Views/Tabycx/AllTapStatistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eda6175a700d803f9eca1cfda22b4c408c40741", @"/Views/_ViewImports.cshtml")]
    public class Views_Tabycx_AllTapStatistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/YcxTool/MySelf.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\A_Githup\thisOnline\two\Againmvc\E-commerce-platform-MVC\UI\Views\Tabycx\AllTapStatistics.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "89d6e0a7020af40d3922978c7624ec1d72df32d74101", async() => {
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
            WriteLiteral(@"

<script src=""https://code.highcharts.com.cn/highcharts/highcharts.js""></script>
<script src=""https://code.highcharts.com.cn/highcharts/modules/exporting.js""></script>
<script src=""https://code.highcharts.com.cn/highcharts/modules/series-label.js""></script>
<script src=""https://code.highcharts.com.cn/highcharts/modules/oldie.js""></script>
<script src=""https://code.highcharts.com.cn/highcharts-plugins/highcharts-zh_CN.js""></script>

<script>
    $(tool());
    function tool() {
        $.ajax({
            url: 'http://localhost:50222/data/user',
            type: 'get',
            dataType: 'json',
            success: function (data) {
                $(data).each(
                    function () {
                        $(""#xx"").append('<input type=""text"" name=""name""  value=""' + data + '"" />');
                    }

                );
            }

        });
    }

    $(tool());
    function tool() {
        $.ajax({
            url: 'http://localhost:50222/data/aiz',
");
            WriteLiteral(@"            type: 'get',
            dataType: 'json',
            success: function (data) {
                $(data).each(
                    function () {
                        $(""#xx"").append('<input type=""text"" name=""name""  value=""' + data + '"" />');
                    }

                );
            }

        });
    }
    $(tool());
    function tool() {
        $.ajax({
            url: 'http://localhost:50222/data/shopOne',
            type: 'get',
            dataType: 'json',
            success: function (data) {
                $(data).each(
                    function () {
                        $(""#xx"").append('<input type=""text"" name=""name""  value=""' + data + '"" />');
                    }

                );
            }

        });
    }
    $(tool());
    function tool() {
        $.ajax({
            url: 'http://localhost:50222/data/shopTow',
            type: 'get',
            dataType: 'json',
            success: function (data) {
       ");
            WriteLiteral(@"         $(data).each(
                    function () {
                        $(""#xx"").append('<input type=""text"" name=""name""  value=""' + data + '"" />');
                    }

                );
            }

        });
    }
    $(tool());
    function tool() {
        $.ajax({
            url: 'http://localhost:50222/data/shopThree',
            type: 'get',
            dataType: 'json',
            success: function (data) {
                $(data).each(
                    function () {
                        $(""#xx"").append('<input type=""text"" name=""name""  value=""' + data + '"" />');
                    }

                );
            }

        });
    }
    $(tool());
    function tool() {
        $.ajax({
            url: 'http://localhost:50222/data/shopfore',
            type: 'get',
            dataType: 'json',
            success: function (data) {
                $(data).each(
                    function () {
                        $(""#xx"").append('<");
            WriteLiteral(@"input type=""text"" name=""name""  value=""' + data + '"" />');
                    }

                );
            }

        });
    }
    $(tool());
    function tool() {
        $.ajax({
            url: 'http://localhost:50222/data/userone',
            type: 'get',
            dataType: 'json',
            success: function (data) {
                $(data).each(
                    function () {
                        $(""#xx"").append('<input type=""text"" name=""name""  value=""' + data + '"" />');
                    }

                );
            }

        });
    }
    $(tool());
    function tool() {
        $.ajax({
            url: 'http://localhost:50222/data/usertwo',
            type: 'get',
            dataType: 'json',
            success: function (data) {
                $(data).each(
                    function () {
                        $(""#xx"").append('<input type=""text"" name=""name""  value=""' + data + '"" />');
                    }

                );
");
            WriteLiteral("            }\r\n\r\n        });\r\n    }\r\n\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
