#pragma checksum "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\LXW\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aee465b7ae4bdf7fb928202c80554351be9ef51d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LXW_Show), @"mvc.1.0.view", @"/Views/LXW/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aee465b7ae4bdf7fb928202c80554351be9ef51d", @"/Views/LXW/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eda6175a700d803f9eca1cfda22b4c408c40741", @"/Views/_ViewImports.cshtml")]
    public class Views_LXW_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\LXW\Show.cshtml"
  
    ViewData["Title"] = "Show";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Page Content -->
<div class=""container-fluid p-y-md"">
    <!-- Cards API, functionality initialized in App() -> uiCardsApi() -->
    <h2 class=""section-title"">权限设置</h2>

    <div class=""row"">

        <div class=""col-sm-12"">
            <div class=""card"" id=""sample-card"">
                <div class=""card-header"">
                    <button class=""btn btn-app btn-pill btn-sm"" type=""button"" onclick=""App.cards( '#sample-card', 'content_toggle' );"">添加管理</button>
                    <ul class=""card-actions"">
                        <li>
                            <button type=""button"" data-toggle=""card-action"" data-action=""fullscreen_toggle""></button>
                        </li>
                        <li>
                            <button type=""button"" data-toggle=""card-action"" data-action=""content_toggle""></button>
                        </li>
                    </ul>
                </div>
                <div class=""card-block"">
                    <table width=""80%"">
  ");
            WriteLiteral(@"                      <tr>
                            <td>姓名:</td>
                            <td>手机号:</td>
                            <td>所属分组:</td>
                            <td>状态:</td>
                            <td>备注:</td>
                        </tr>
                        <tr>
                            <td><input id=""Mname"" type=""text"" /></td>
                            <td><input id=""Modile"" type=""text"" /></td>
                            <td><select id=""Pdd""></select></td>
                            <td>
                                <input id=""cb"" type=""radio"" value=""true"" alt=""禁用"" name=""1"" />禁用&nbsp;
                                <input id=""cb"" type=""radio"" value=""false"" alt=""未禁用"" name=""1"" />未禁用
                            </td>
                            <td> <textarea id=""Cwen"" name=""cont"" cols=""20"" rows=""4""></textarea></td>
                        </tr>
                        <tr>
                            <td><input id=""Button3""  class=""btn btn-app"" type=""");
            WriteLiteral(@"button""  value=""保存"" onclick=""Add()""  /></td>
                            <td><input id=""Button4""  class=""btn btn-app"" type=""button"" value=""取消"" onclick=""Poos()"" /></td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
        <!-- .col-sm-12 -->

        <div class=""col-sm-12"">
            <div class=""card"">
                <div class=""card-block"">
                    <p>权限设置 </p>
                    <div class=""table-responsive"">
                        <table class=""table table-bordered table-striped"">
                            <thead>
                                <tr>
                                    <th>姓名</th>
                                    <th>手机号</th>
                                    <th>所属分组</th>
                                    <th>状态</th>
                                    <th>备注</th>
                                    <th>操作</th>
                                </tr>
                      ");
            WriteLiteral(@"      </thead>
                            <tbody id=""td"">
                            </tbody>
                        </table>
                    </div>
                    <!-- .table-responsive -->
                </div>
            </div>
        </div>
    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aee465b7ae4bdf7fb928202c80554351be9ef51d7172", async() => {
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
        PostShow();
        BandSelCarType();
    })
    function PostShow() {
        $.ajax({
            url: 'http://localhost:50222/LXW/Lxwshow',
            type: 'get',
            dataType: 'json',
            async: true,
            crossDomain: true,
            success: function (d) {
                $(""#td"").empty();
                $(d).each(function () {
                    var line = '<tr>'
                        + '<td>' + this.mname + '</td>'
                        + '<td>' + this.modile + '</td>'
                        + '<td>' + this.dname + '</td>'
                        + '<td>' + (this.mstate == true ? '启用' : '禁用') + '</td>'
                        + '<td>' + this.mnotes + '</td>'
                        + '<td><input id=""Button1"" type=""button"" value=""删除"" class=""btn btn-app"" onclick=Del(' + this.mid + ') />&nbsp;<input id=""Button2"" type=""button"" value=""编辑"" class=""btn btn-app""  onclick=""hom(' + this.mid + ')""/></td>'
              ");
            WriteLiteral(@"          + '</tr>'
                    $(""#td"").append(line);
                    BandSelCarType();
                })
            }
        })
    }
    function so() {
        location.href = '/Power/Show';
    }

    function Add() {
        var obj = {};
        obj.Mname = $(""#Mname"").val();
        obj.Modile = $(""#Modile"").val();
        obj.Did = parseInt($(""#Pdd"").val());
        obj.Mstate = $(""#cb"").prop(""checked"");
        obj.Mnotes = $(""#Cwen"").val();
        $.ajax({
            url: ""http://localhost:50222/LXW/Addlxw"",
            type: 'post',
            data: JSON.stringify(obj),
            contentType : ""application/json"",
            dataType: ""json"",
            success: function (d) {
                if (d > 0) {
                    alert('添加成功');
                    location.href = '/LXW/Show';
                }
                else {
                    alert('添加失败');
                }
            }
        })

    }

    function Del(id) {
    ");
            WriteLiteral(@"    if (confirm('确认要删除吗？')) {
            $.ajax({
                url: 'http://localhost:50222/LXW/LxwDel?id='+ id,
                type: 'Delete',
                success: function (d) {
                    if (d > 0) {
                        alert('删除成功');
                        location.href = '/LXW/Show';
                    }
                    else {
                        alert('删除失败');
                    }
                }
            })
        }
    }

    function BandSelCarType() {
        $.ajax({
            url: ""http://localhost:50222/xxx/try1"",
            type: 'Get',
            dataType: 'json',
            async: true,
            crossDomain: true,
            contents: ""application/json"",
            success: function (d) {
                $(""#Pdd"").empty();
                $(""#Pdd"").append(""<option value=''>--请选择--</option>"");
                $(d).each(function () {
                    var opt = ""<option value="" + this.did + "">"" + this.dname + ""</opt");
            WriteLiteral("ion>\";\r\n                    $(\"#Pdd\").append(opt);\r\n                })\r\n            }\r\n        })\r\n    }\r\n    function hom(id) {\r\n        location.href = \'/LXW/Upt?id=\' + id;\r\n    }\r\n</script>\r\n\r\n");
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
