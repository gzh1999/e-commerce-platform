#pragma checksum "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\sy\ShowGoods.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f117e4295de46302da1d029e93f27666ad72450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_sy_ShowGoods), @"mvc.1.0.view", @"/Views/sy/ShowGoods.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f117e4295de46302da1d029e93f27666ad72450", @"/Views/sy/ShowGoods.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eda6175a700d803f9eca1cfda22b4c408c40741", @"/Views/_ViewImports.cshtml")]
    public class Views_sy_ShowGoods : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 1 "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\sy\ShowGoods.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

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

<table class=""table table-bordered"">
    <thead style=""text-align:center"">
        <tr style=""background:#a9c6c9"">
            <td>编号</td>
            <td>商品名称</td>
            <td>商品分类</td>
            <td>商品单价</td>
            <td>销售量</td>
            <td>状态</td>
            <td>审核状态</td>
            <td>操作</td>
        </tr>
    </thead>
    <tbody id=""tb""></tbody>
</table>

<div class=""row"">
    <div");
            BeginWriteAttribute("class", " class=\"", 1658, "\"", 1666, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""float:right;margin-right:50px;"">
        <td>总记录数<span id=""TotalCount""></span>条</td>
        <td>总共<span id=""TotalPage""></span>页</td>
        <td>当前第<span id=""CurrentPage""></span>页</td>
        <td><input id=""Button1"" class=""info-close"" type=""button"" style=""color:#000000"" value=""☀"" onclick=""ShowGoods(1)"" /></td>
        <td><input id=""Button1"" class=""info-close"" type=""button"" style=""color:#000000"" value=""<<"" onclick=""ShowGoods(currentPage-1)"" /></td>
        <td><input id=""Button1"" class=""info-close"" type=""button"" style=""color:#000000"" value="">>"" onclick=""ShowGoods(currentPage+1)"" /></td>
        <td><input id=""Button1"" class=""info-close"" type=""button"" style=""color:#000000"" value=""☾"" onclick=""ShowGoods(totalPage)"" /></td>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f117e4295de46302da1d029e93f27666ad724506291", async() => {
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

    $(function () {
        ShowGoods(1);
    });

    //商品列表显示
    var pageSize = 3;
    var currentPage = 1;
    var totalPage = 1;

    function ShowGoods(page) {
        $(""#div1"").empty();
        var obj = {};
        obj.goodsName = $(""#GoodsName"").val();

        obj.currentPage = page;
        obj.pageSize = pageSize;
        $.ajax({
            url: ""http://localhost:50222/api/Goods/Get"",
            type: ""get"",
            dataType: 'json',
            data: obj,
            async: true,
            crossDomain: true,
            success: function (d) {
                $(""#TotalCount"").text(d.totalCount);
                $(""#TotalPage"").text(d.totalPage);
                $(""#CurrentPage"").text(d.currentPage);
                //最大页
                totalPage = d.totalPage;
                //当前页
                currentPage = d.currentPage;
                //清空表格
                $(""#tb"").empty();
                //循环遍历
                $(d.goods).each(");
            WriteLiteral(@"function () {
                    //拼接tr一行
                    var line = '<tr>'
                        + '<td style=""font-weight:bolder;font-size:20px;text-align:center"">' + this.id + '</td>'
                        + '<td style=""font-weight:bolder;font-size:20px;text-align:center"">' + this.goodsName + '</td>'
                        + '<td style=""font-weight:bolder;font-size:20px;text-align:center"">' + this.typeName + '</td>'
                        + '<td style=""color:red;font-size:28px;font-weight:bolder;text-align:center"">' + this.goodsPrice + '</td>'
                        + '<td style=""font-weight:bolder;font-size:20px;text-align:center"">' + this.goodsSalesvolume + '</td>'
                        + '<td style=""font-weight:bolder;font-size:20px;text-align:center"">' + (this.goodsOnStatus ? ""上架"" : ""下架"") + '</td>'
                        + '<td style=""font-weight:bolder;font-size:20px;text-align:center"">' + this.goodsAuditStatuss + '</td>'
                        + '<td style=""font-weight:bolde");
            WriteLiteral(@"r;font-size:20px;text-align:center"">'
                        + ""<a href = '/sy/UptGoods/"" + this.id + ""'>编辑&nbsp;&nbsp;</a>""
                        + ""<a href='javascripts:;' onclick=Del("" + this.id + "")>删除&nbsp;&nbsp;</a>""
                        + ""<a href='javascripts:;' onclick=UptStatus("" + this.id + "")>"" + (this.goodsOnStatus ? ""下架"" : ""上架"") + ""</a>""
                        + '</td>'
                        + '</tr>'
                    //将数据放入表格
                    $(""#tb"").append(line);
                });
            }
        });
    } 


    //删除商品信息
    function Del(id) {
        if (confirm(""确认删除码？"")) {
            $.ajax({
                url: ""http://localhost:50222/api/Goods/Delete?id="" + id,
                type: ""delete"",
                success: function (d) {
                    if (d > 0) {
                        alert(""删除成功"");
                        location.href = ""/sy/ShowGoods"";
                    }
                    else {
                        alert");
            WriteLiteral(@"(""删除失败"");
                    }
                }
            })
        }
    }

    //修改上架下架状态
    function UptStatus(id) {
        if (confirm(""确认要进行此操作吗？"")) {
            $.ajax({
                url: 'http://localhost:50222/api/UptGoodsStatus/Put?id=' + id,
                type: 'put',
                data: { id: id },
                dataType: 'json',
                success: function (d) {
                    if (d > 0) {
                        alert('操作成功');
                        ShowGoods();
                    }
                    else {
                        alert('操作失败');
                    }
                }
            })
        }
    }
</script>


<style>
    /*删除按钮css样式*/

    .info-close {
        /*position: fixed;*/
        right: calc(50% - 10px);
        width: 30px;
        height: 30px;
        background: #ff0000;
        opacity: .6;
        border-radius: 25px;
        cursor: pointer;
        z-index: 2002;
    }

        .info-c");
            WriteLiteral(@"lose:before {
            position: absolute;
            content: '';
            width: 20px;
            height: 2px;
            background: white;
            transform: rotate(45deg);
            top: 14px;
            left: 5px;
        }

        .info-close:after {
            content: '';
            position: absolute;
            width: 20px;
            height: 2px;
            background: white;
            transform: rotate(-45deg);
            top: 14px;
            left: 5px;
        }
</style>");
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
