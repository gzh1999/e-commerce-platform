#pragma checksum "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\Orders\OrdersShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "589bddc4db0cd27168d04d8074f45d1651eaf5d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_OrdersShow), @"mvc.1.0.view", @"/Views/Orders/OrdersShow.cshtml")]
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
#line 1 "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"589bddc4db0cd27168d04d8074f45d1651eaf5d6", @"/Views/Orders/OrdersShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eda6175a700d803f9eca1cfda22b4c408c40741", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_OrdersShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/zdy/layui-v2.5.6/layui/css/layui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/zdy/layui-v2.5.6/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\Orders\OrdersShow.cshtml"
  
    ViewData["Title"] = "订单管理";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>订单管理</h2>\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "589bddc4db0cd27168d04d8074f45d1651eaf5d65086", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Layui</title>
    <meta name=""renderer"" content=""webkit"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "589bddc4db0cd27168d04d8074f45d1651eaf5d65621", async() => {
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
                WriteLiteral("\r\n  \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "589bddc4db0cd27168d04d8074f45d1651eaf5d66805", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "589bddc4db0cd27168d04d8074f45d1651eaf5d67904", async() => {
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
                WriteLiteral("\r\n    <!-- 注意：如果你直接复制所有代码到本地，上述css路径需要改成你本地的 -->\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "589bddc4db0cd27168d04d8074f45d1651eaf5d69757", async() => {
                WriteLiteral(@"

    <div class=""layui-tab layui-tab-card"">
        <ul class=""layui-tab-title"">
            <li class=""layui-this"" style=""width:100px"">全部</li>
            <li style=""width:100px"">待发货</li>
            <li style=""width:100px"">已发货</li>
            <li style=""width:100px"">已完成</li>
            <li style=""width:100px"">已关闭</li>
        </ul>
        <div class=""layui-tab-content"" style=""height:100%;"">
            <div class=""layui-tab-item layui-show"">

                <table>
                    <thead></thead>
                    <tbody id=""dt""></tbody>
                </table>
            </div>
            <div class=""layui-tab-item"">
                <table>
                    <thead></thead>
                    <tbody id=""dt1""></tbody>
                </table>
            </div>
            <div class=""layui-tab-item"">
                <table>
                    <thead></thead>
                    <tbody id=""dt2""></tbody>
                </table>
            </div>
            <");
                WriteLiteral(@"div class=""layui-tab-item"">
                <table>
                    <thead></thead>
                    <tbody id=""dt3""></tbody>
                </table>
            </div>
            <div class=""layui-tab-item"">
                <table>
                    <thead></thead>
                    <tbody id=""dt4""></tbody>
                </table>
            </div>
            <div class=""layui-tab-item"">6</div>
        </div>
    </div>

    <!-- 注意：如果你直接复制所有代码到本地，上述js路径需要改成你本地的 -->
    <script>
        layui.use('element', function () {
            var $ = layui.jquery
                , element = layui.element; //Tab的切换功能，切换事件监听等，需要依赖element模块

            //触发事件
            var active = {
                tabAdd: function () {
                    //新增一个Tab项
                    element.tabAdd('demo', {
                        title: '新选项' + (Math.random() * 1000 | 0) //用于演示
                        , content: '内容' + (Math.random() * 1000 | 0)
                        , id: new Date(");
                WriteLiteral(@").getTime() //实际使用一般是规定好的id，这里以时间戳模拟下
                    })
                }
                , tabDelete: function (othis) {
                    //删除指定Tab项
                    element.tabDelete('demo', '44'); //删除：“商品管理”


                    othis.addClass('layui-btn-disabled');
                }
                , tabChange: function () {
                    //切换到指定Tab项
                    element.tabChange('demo', '22'); //切换到：用户管理
                }
            };

            $('.site-demo-active').on('click', function () {
                var othis = $(this), type = othis.data('type');
                active[type] ? active[type].call(this, othis) : '';
            });

            //Hash地址的定位
            var layid = location.hash.replace(/^#test=/, '');
            element.tabChange('test', layid);

            element.on('tab(test)', function (elem) {
                location.hash = 'test=' + $(this).attr('lay-id');
            });

        });


        $(function () {");
                WriteLiteral(@"
            Show(); Show1(); Show2(); Show3(); Show4();
        })
        function Show() {
            $.ajax({
                url: 'http://localhost:50222/Api/Orders/OrdersShow',
                type: 'get',
                dataType: 'json',
                async: true,
                crossDomain: true,
                success: function (d) {
                    $(""#dt"").empty();
                    $(d).each(function () {
                        var s = '   <div  width=""80%"">'
                            + '<br/>'
                            + ' <br/>'
                            + '   <div style=""float:left"">'
                            + '       <img src = ' + this.goodsIIImg + ' alt = """" width=""100"" height=""60""/>'
                            + ' </div>'
                            + '   <div style=""float:left"">'
                            + '       <h4><span>名称:</span>' + this.goodsName + '<span></h4>'
                            + ' <br/>'
                            + ' <spa");
                WriteLiteral(@"n>创建时间:</span><span>' + this.startTime + '</span>'
                            + ' <span>&nbsp;&nbsp;&nbsp;&nbsp;共' + this.goodsSum + '件&nbsp;&nbsp;&nbsp;&nbsp;</span>'
                            + ' <span>订单总额:' + this.goodsPrice + '&nbsp;&nbsp;&nbsp;&nbsp;</span>'
                            + ' <span>交易状态:' + (this.states == 1 ? ""待发货"" : (this.zt == 2 ? ""已发货"" : this.zt == 3 ? ""已完成"" : ""已关闭"")) + '</span>'
                            + '  <span>&nbsp;&nbsp;&nbsp;&nbsp;收货人:</span><span>' + this.conName + '' + this.conMobile + '</span>'
                            + '&nbsp;&nbsp;&nbsp;&nbsp;<input type=""button""  class=""layui-btn layui-btn-normal layui-btn-radius"" value=""详情"" onclick=""Dtio(' + this.ordersId + ')""/>&nbsp;&nbsp;&nbsp;&nbsp;<input  class=""layui-btn layui-btn-normal layui-btn-radius"" type=""button"" value=""发货"" onclick=""Dtio2(' + this.ordersId + ')""/>'
                            + ' <br/>'
                            + ' <br/>'
                            + ' </div>'
                          ");
                WriteLiteral(@"  + ' </div>'
                        $(""#dt"").append(s);
                    })
                }
            })
        }
        function Dtio(id) {
            location.href = '/Orders/Find/' + id;
        }
        function Dtio2(id) {
            location.href = '/Orders/FindId/' + id;
        }
        function Show1() {
            $.ajax({
                url: 'http://localhost:50222/Api/Orders/StatesShow1',
                type: 'get',
                dataType: 'json',
                async: true,
                crossDomain: true,
                success: function (d) {
                    $(""#dt1"").empty();
                    $(d).each(function () {
                        var s = '   <div  width=""80%"">'
                            + '<br/>'
                            + ' <br/>'
                            + '   <div style=""float:left"">'
                            + '       <img src = ' + this.goodsIIImg + ' alt = """" width=""100"" height=""60""/>'
                        ");
                WriteLiteral(@"    + ' </div>'
                            + '   <div style=""float:left"">'
                            + '       <h4><span>名称:</span>' + this.goodsName + '<span></h4>'
                            + ' <br/>'
                            + ' <span>创建时间:</span><span>' + this.startTime + '</span>'
                            + ' <span>&nbsp;&nbsp;&nbsp;&nbsp;共' + this.goodsSum + '件&nbsp;&nbsp;&nbsp;&nbsp;</span>'
                            + ' <span>订单总额:' + this.goodsPrice + '&nbsp;&nbsp;&nbsp;&nbsp;</span>'
                            + ' <span>交易状态:' + (this.states == 1 ? ""待发货"" : (this.zt == 2 ? ""已发货"" : this.zt == 3 ? ""已完成"" : ""已关闭"")) + '</span>'
                            + '  <span>&nbsp;&nbsp;&nbsp;&nbsp;收货人:</span><span>' + this.conName + '' + this.conMobile + '</span>'
                            + '&nbsp;&nbsp;&nbsp;&nbsp;<input type=""button""  class=""layui-btn layui-btn-normal layui-btn-radius"" value=""详情"" onclick=""Dtio(' + this.ordersId + ')""/>&nbsp;&nbsp;&nbsp;&nbsp;<input  class=""layui-btn la");
                WriteLiteral(@"yui-btn-normal layui-btn-radius"" type=""button"" value=""发货"" onclick=""Dtio2(' + this.ordersId + ')""/>'
                            + ' <br/>'
                            + ' <br/>'
                            + ' </div>'
                            + ' </div>'
                        $(""#dt1"").append(s);
                    })
                }
            })
        }
        function Show2() {
            $.ajax({
                url: 'http://localhost:50222/Api/Orders/StatesShow2',
                type: 'get',
                dataType: 'json',
                async: true,
                crossDomain: true,
                success: function (d) {
                    $(""#dt2"").empty();
                    $(d).each(function () {
                        var s = '   <div  width=""80%"">'
                            + '<br/>'
                            + ' <br/>'
                            + '   <div style=""float:left"">'
                            + '       <img src = ' + this.goodsIIImg +");
                WriteLiteral(@" ' alt = """" width=""100"" height=""60""/>'
                            + ' </div>'
                            + '   <div style=""float:left"">'
                            + '       <h4><span>名称:</span>' + this.goodsName + '<span></h4>'
                            + ' <br/>'
                            + ' <span>创建时间:</span><span>' + this.startTime + '</span>'
                            + ' <span>&nbsp;&nbsp;&nbsp;&nbsp;共' + this.goodsSum + '件&nbsp;&nbsp;&nbsp;&nbsp;</span>'
                            + ' <span>订单总额:' + this.goodsPrice + '&nbsp;&nbsp;&nbsp;&nbsp;</span>'
                            + ' <span>交易状态:' + (this.states == 1 ? ""待发货"" : (this.zt == 2 ? ""已发货"" : this.zt == 3 ? ""已完成"" : ""已关闭"")) + '</span>'
                            + '  <span>&nbsp;&nbsp;&nbsp;&nbsp;收货人:</span><span>' + this.conName + '' + this.conMobile + '</span>'
                            + '&nbsp;&nbsp;&nbsp;&nbsp;<input type=""button""  class=""layui-btn layui-btn-normal layui-btn-radius"" value=""详情"" onclick=""Dtio(' + this.ord");
                WriteLiteral(@"ersId + ')""/>&nbsp;&nbsp;&nbsp;&nbsp;<input  class=""layui-btn layui-btn-normal layui-btn-radius"" type=""button"" value=""发货"" onclick=""Dtio2(' + this.ordersId + ')""/>'
                            + ' <br/>'
                            + ' <br/>'
                            + ' </div>'
                            + ' </div>'
                        $(""#dt2"").append(s);
                    })
                }
            })
        }
        function Show3() {
            $.ajax({
                url: 'http://localhost:50222/Api/Orders/StatesShow3',
                type: 'get',
                dataType: 'json',
                async: true,
                crossDomain: true,
                success: function (d) {
                    $(""#dt3"").empty();
                    $(d).each(function () {
                        var s = '   <div  width=""80%"">'
                            + '<br/>'
                            + ' <br/>'
                            + '   <div style=""float:left"">'
      ");
                WriteLiteral(@"                      + '       <img src = ' + this.goodsIIImg + ' alt = """" width=""100"" height=""60""/>'
                            + ' </div>'
                            + '   <div style=""float:left"">'
                            + '       <h4><span>名称:</span>' + this.goodsName + '<span></h4>'
                            + ' <br/>'
                            + ' <span>创建时间:</span><span>' + this.startTime + '</span>'
                            + ' <span>&nbsp;&nbsp;&nbsp;&nbsp;共' + this.goodsSum + '件&nbsp;&nbsp;&nbsp;&nbsp;</span>'
                            + ' <span>订单总额:' + this.goodsPrice + '&nbsp;&nbsp;&nbsp;&nbsp;</span>'
                            + ' <span>交易状态:' + (this.states == 1 ? ""待发货"" : (this.zt == 2 ? ""已发货"" : this.zt == 3 ? ""已完成"" : ""已关闭"")) + '</span>'
                            + '  <span>&nbsp;&nbsp;&nbsp;&nbsp;收货人:</span><span>' + this.conName + '' + this.conMobile + '</span>'
                            + '&nbsp;&nbsp;&nbsp;&nbsp;<input type=""button""  class=""layui-btn layui-bt");
                WriteLiteral(@"n-normal layui-btn-radius"" value=""详情"" onclick=""Dtio(' + this.ordersId + ')""/>&nbsp;&nbsp;&nbsp;&nbsp;<input  class=""layui-btn layui-btn-normal layui-btn-radius"" type=""button"" value=""发货"" onclick=""Dtio2(' + this.ordersId + ')""/>'
                            + ' <br/>'
                            + ' <br/>'
                            + ' </div>'
                            + ' </div>'
                        $(""#dt3"").append(s);
                    })
                }
            })
        }
        function Show4() {
            $.ajax({
                url: 'http://localhost:50222/Api/Orders/StatesShow4',
                type: 'get',
                dataType: 'json',
                async: true,
                crossDomain: true,
                success: function (d) {
                    $(""#dt4"").empty();
                    $(d).each(function () {
                        var s = '   <div  width=""80%"">'
                            + '<br/>'
                            + ' <br/>'
   ");
                WriteLiteral(@"                         + '   <div style=""float:left"">'
                            + '       <img src = ' + this.goodsIIImg + ' alt = """" width=""100"" height=""60""/>'
                            + ' </div>'
                            + '   <div style=""float:left"">'
                            + '       <h4><span>名称:</span>' + this.goodsName + '<span></h4>'
                            + ' <br/>'
                            + ' <span>创建时间:</span><span>' + this.startTime + '</span>'
                            + ' <span>&nbsp;&nbsp;&nbsp;&nbsp;共' + this.goodsSum + '件&nbsp;&nbsp;&nbsp;&nbsp;</span>'
                            + ' <span>订单总额:' + this.goodsPrice + '&nbsp;&nbsp;&nbsp;&nbsp;</span>'
                            + ' <span>交易状态:' + (this.states == 1 ? ""待发货"" : (this.zt == 2 ? ""已发货"" : this.zt == 3 ? ""已完成"" : ""已关闭"")) + '</span>'
                            + '  <span>&nbsp;&nbsp;&nbsp;&nbsp;收货人:</span><span>' + this.conName + '' + this.conMobile + '</span>'
                            + '&nbsp;&");
                WriteLiteral(@"nbsp;&nbsp;&nbsp;<input type=""button""  class=""layui-btn layui-btn-normal layui-btn-radius"" value=""详情"" onclick=""Dtio(' + this.ordersId + ')""/>&nbsp;&nbsp;&nbsp;&nbsp;<input  class=""layui-btn layui-btn-normal layui-btn-radius"" type=""button"" value=""发货"" onclick=""Dtio2(' + this.ordersId + ')""/>'
                            + ' <br/>'
                            + ' <br/>'
                            + ' </div>'
                            + ' </div>'
                        $(""#dt4"").append(s);
                    })
                }
            })
        }
    </script>

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
            WriteLiteral("\r\n</html>");
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
