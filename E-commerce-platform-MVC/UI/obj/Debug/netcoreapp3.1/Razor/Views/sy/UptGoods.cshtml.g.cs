#pragma checksum "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\sy\UptGoods.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49c7f029d63367c2722da236b1451972c8a35fc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_sy_UptGoods), @"mvc.1.0.view", @"/Views/sy/UptGoods.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49c7f029d63367c2722da236b1451972c8a35fc7", @"/Views/sy/UptGoods.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eda6175a700d803f9eca1cfda22b4c408c40741", @"/Views/_ViewImports.cshtml")]
    public class Views_sy_UptGoods : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\sy\UptGoods.cshtml"
  
    ViewData["Title"] = "UptGoods";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<br />
<br />

<div>
    <div style=""margin-left:80px"">
        <div style=""float:left"">
            <input id=""Button1"" type=""button"" style=""width:150px;height:50px;background-color:cornflowerblue"" value=""商品管理"" onclick=""location.href='/sy/Show2'"" />
            <input id=""Button1"" type=""button"" style=""width:150px;height:50px;background-color:cornflowerblue"" value=""商品添加"" onclick=""location.href='/sy/AddGoods'"" />
            <input id=""Button1"" type=""button"" style=""width:150px;height:50px;background-color:cornflowerblue"" value=""分类管理"" onclick=""location.href='/sy/ShowType'"" />
        </div>
    </div>
    <div style=""margin-right: 150px"">
        <div style=""float:right"">
            <input id=""GoodsName"" type=""text"" style=""width:300px;height:30px"" placeholder=""请输入关键字"" />
            <input id=""Button1"" type=""button"" style=""width:70px;height:40px;background-color:darkgoldenrod"" value=""搜索"" onclick=""ShowGoods(1)"" />
            <input id=""Button1"" type=""button"" style=""width:150px;height:5");
            WriteLiteral(@"0px;background-color:cornflowerblue"" value=""列表显示"" onclick=""location.href='/sy/ShowGoods'"" />
        </div>
    </div>
</div>
<br />
<br />
<br />



<div style=""margin-left:80px;font-size:28px"">
    <div>
        <div style=""font-weight:bolder"">1.商品基本信息</div>
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span style=""text-align:center"">商品分类：</span><select id=""TypeName""></select>
        </div>
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span style=""text-align:center"">商品类型：</span><select id=""KindName""></select>
        </div>
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span style=""text-align:center"">商品名称：</span><input id=""GoodsNames"" type=""text"" style=""width:1000px"" />
        </div>
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    ");
            WriteLiteral("        <span style=\"text-align:center\">商品副标题：</span><input id=\"GoodsTitle\" type=\"text\" style=\"width:1000px\" />\r\n        </div>\r\n");
            WriteLiteral(@"        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span style=""text-align:center"">商品规格：</span>
            <input id=""yes"" type=""radio"" name=""1"" value=""true"" />需要规格&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input id=""no"" type=""radio"" name=""1"" value=""false"" />不需要规格
");
            WriteLiteral(@"        </div>
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span style=""text-align:center"">原价：</span><input id=""GoodsPrice"" type=""text"" style=""width:1000px"" />
        </div>
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span style=""text-align:center"">赠送积分：</span><input id=""GoodsJifen"" type=""text"" style=""width:1000px"" />
        </div>
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span style=""vertical-align:middle"">商品简介：</span><textarea id=""GoodsIntroductory"" rows=""2"" cols=""20"" style=""width:1000px;height:300px""></textarea>
        </div>
    </div>
    <div>
        <div style=""font-weight:bolder"">2.商品物流服务</div>
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span style=""t");
            WriteLiteral(@"ext-align:center"">实名认证：</span><select id=""SendName""></select>
        </div>
    </div>
    <div>
        <div style=""font-weight:bolder"">3.售后信息设置</div>
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id=""GoodsSale"" type=""radio"" name=""2"" value=""true"" />7天无理由退换
        </div>
    </div>
    <div>
        <div style=""font-weight:bolder"">4.商品其他信息</div>
        <div>
            <div>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <span style=""text-align:center"">库存计数：</span>
                <input id=""GoodsStock"" type=""text"" style=""width:200px"" /><br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input id=""GoodsBuyStock"" type=""radio"" name=""3"" value=""true"" />买家拍下减库存
            </div>
            WriteLiteral(@"
            <div>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <span style=""text-align:center"">上架时间：</span>
                <input id=""Radio1"" type=""radio"" name=""4"" value=""true"" />立即上架
                <input id=""Radio2"" type=""radio"" name=""4"" value=""false"" />定时上架
            </div>
        </div>
    </div>
    <div>
        <input id=""Button1"" style=""width:130px;height:40px"" type=""button"" value=""保存"" class=""btn btn-info"" onclick=""UptGoods()"" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id=""Button2"" style=""width:130px;height:40px"" type=""button"" value=""返回"" class=""btn btn-default"" onclick=""location.href='/Goods/ShowGoods'"" />
    </div>
</div>



");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49c7f029d63367c2722da236b1451972c8a35fc79555", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        //第一次加载
        BandType();
        BandKind();
        BandSend();
        Fill();
        //绑定分类
        function BandType() {
            $.ajax
                ({
                    url: ""http://localhost:50222/api/GoodsBandType/Get"",
                    type: ""get"",
                    dataType: ""json"",
                    success: function (d) {
                        //清空下拉框
                        $(""#TypeName"").empty();
                        $(""#TypeName"").append(""<option value=''>==请选择==</option>"");
                        //拼接一个下拉项
                        $(d).each(function () {
                            var opt = ""<option value="" + this.id + "">"" + this.typeName + ""</option>"";
                            //将数据放入表格
                            $(""#TypeName"").append(opt);
                        });
                    }
                })
        }
        //绑定类型
        function BandKind() {
            $.ajax
                ({
            ");
                WriteLiteral(@"        url: ""http://localhost:50222/api/GoodsKind/Get"",
                    type: ""get"",
                    dataType: ""json"",
                    success: function (d) {
                        //清空下拉框
                        $(""#KindName"").empty();
                        $(""#KindName"").append(""<option value=''>==请选择==</option>"");
                        //拼接一个下拉项
                        $(d).each(function () {
                            var opt = ""<option value="" + this.id + "">"" + this.kindName + ""</option>"";
                            //将数据放入表格
                            $(""#KindName"").append(opt);
                        });
                    }
                })
        }
        //绑定快递
        function BandSend() {
            $.ajax
                ({
                    url: ""http://localhost:50222/api/GoodsSend/Get"",
                    type: ""get"",
                    dataType: ""json"",
                    success: function (d) {
                        //清空下拉框
       ");
                WriteLiteral(@"                 $(""#SendName"").empty();
                        $(""#SendName"").append(""<option value=''>==请选择==</option>"");
                        //拼接一个下拉项
                        $(d).each(function () {
                            var opt = ""<option value="" + this.id + "">"" + this.sendName + ""</option>"";
                            //将数据放入表格
                            $(""#SendName"").append(opt);
                        });
                    }
                })
        }

        //反填数据
        function Fill() {
            $.ajax({
                url: ""http://localhost:50222/api/Goods/Get1?Id=""+");
#nullable restore
#line 195 "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\sy\UptGoods.cshtml"
                                                            Write(ViewContext.RouteData.Values["Id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@",
                type: ""get"",
                dataType:""json"",
                success: function (d) {
                    //反填
                    $(""#GoodsNames"").val(d.goodsName);
                    $(""#GoodsTitle"").val(d.goodsTitle);
                    $(""#GoodsPrice"").val(d.goodsPrice);
                    $(""#GoodsJifen"").val(d.goodsJifen);
                    $(""#GoodsIntroductory"").val(d.goodsIntroductory);
                    $(""#GoodsStock"").val(d.goodsStock);

                    $(""#SendName"").val(d.goodsSend);
                    $(""#TypeName"").val(d.goodssType);
                    $(""#KindName"").val(d.goodsKind);

                    //单选
                    if (d.yes) {
                        yes.checked = true;
                    }
                    else {
                        no.checked = true;
                    }
                    if (d.GoodsSale) {
                        GoodsSale.checked = true;
                    }
                    else {
   ");
                WriteLiteral(@"                     GoodsSale.checked = false;
                    }
                    if (d.GoodsBuyStock) {
                        GoodsBuyStock.checked = true;
                    }
                    else {
                        GoodsBuyStock.checked = false;
                    }
                    if (d.Radio1) {
                        Radio1.checked = true;
                    }
                    else {
                        Radio2.checked = true;
                    }
                }
            })
        }
        //修改函数
        function UptGoods() {
            //获取表单的值
            var obj = {};
            //单选的获取
            obj.goodsSize = $(""#yes"").prop(""checked"");
            obj.goodsSale = $(""#GoodsSale"").prop(""checked"");
            obj.goodsBuyStock = $(""#GoodsBuyStock"").prop(""checked"");
            obj.godsOnTimes = $(""#Radio1"").prop(""checked"") ? 1 : 0;

            //文本框
            obj.goodsName = $(""#GoodsNames"").val();
            obj.goodsT");
                WriteLiteral(@"itle = $(""#GoodsTitle"").val();
            obj.goodsPrice = parseFloat($(""#GoodsPrice"").val());
            obj.goodsJifen = parseInt($(""#GoodsJifen"").val());
            obj.goodsIntroductory = $(""#GoodsIntroductory"").val();
            obj.goodsStock = parseInt($(""#GoodsStock"").val());
            //下拉
            obj.goodsSend = parseInt($(""#SendName"").val());
            obj.goodssType = parseInt($(""#TypeName"").val());
            obj.goodsKind = parseInt($(""#KindName"").val());

            //修改
            $.ajax({
                url: ""http://localhost:50222/api/Goods/Post"",
                type: ""Post"",
                data: JSON.stringify(obj),
                contentType: ""application/json"",
                success: function (d) {
                    if (d != """") {
                        alert(""修改成功"");
                        location.href = '/sy/ShowGoods';
                    }
                    else {
                        alert(""修改失败"");
                        location");
                WriteLiteral(".href = \'/sy/ShowGoods\';\r\n                    }\r\n                }\r\n            })\r\n        }\r\n    </script>\r\n");
            }
            );
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