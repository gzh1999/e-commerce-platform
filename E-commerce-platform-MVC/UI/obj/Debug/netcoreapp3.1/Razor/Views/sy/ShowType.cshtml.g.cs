#pragma checksum "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\sy\ShowType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a1e48c83a2c0424b9ff1a7ac57ec31a8b14bf8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_sy_ShowType), @"mvc.1.0.view", @"/Views/sy/ShowType.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a1e48c83a2c0424b9ff1a7ac57ec31a8b14bf8c", @"/Views/sy/ShowType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eda6175a700d803f9eca1cfda22b4c408c40741", @"/Views/_ViewImports.cshtml")]
    public class Views_sy_ShowType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\sy\ShowType.cshtml"
  
    ViewData["Title"] = "ShowType";

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
            WriteLiteral("0px;background-color:cornflowerblue\" value=\"列表显示\" onclick=\"location.href=\'/sy/ShowGoods\'\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n<br />\r\n<br />\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a1e48c83a2c0424b9ff1a7ac57ec31a8b14bf8c4924", async() => {
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

<div style=""margin-left:300px;margin-top:30px; width:1200px"">
    <div style=""float:right"">
        <a data-toggle=""modal"" data-target=""#myModal4"">添加分类</a>
    </div>
</div>


<div class=""row"" id=""buju"">

</div>


<div class=""modal fade"" id=""myModal4"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                <h4 class=""modal-title"" id=""myModalLabel"">添加新分类</h4>
            </div>
            <div class=""divColumn1"">
                <div>
                    <p>你想添加什么分类？</p>
                </div>
                <div>
                    <input type=""text"" id=""typename"" class=""form-control"" />
                </div>
            </div>
            <br /><br />
            <div class=""form-group"">
                <button type=""butto");
            WriteLiteral(@"n"" class=""btn btn-primary"" id=""rcbtn"" onclick=""AddType()"">确定</button>
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">取消</button>
            </div>
        </div>
    </div>
</div>


<script>
//页面第一次加载
    ShowType();

    function ShowType() {
        $.ajax({
            url: ""http://localhost:50222/api/GoodsType/get"",
            type: ""get"",
            dataType: 'json',
            async: true,
            crossDomain: true,
            success: function (d) {
                //清空表格
                $(""#buju"").empty();
                //循环遍历
                $(d).each(function () {
                    //拼接tr一行
                    var line = 
                        +'<div class=""col-md-4"">'
                        +'    <div class=""col-md-4"">'
                        +'        <div class=""card-header"">'
                        + '            <h4>' + this.typeName + '</h4>'
                        +'        </div>'
                        +'");
            WriteLiteral(@"        <div class=""card-block"">'
                        + '           <button class=""btn btn-app btn-block"" data-toggle=""tooltip"" data-placement=""top"" title type=""button"" data-original-title=""Top Tooltip"" onclick=Del(' + this.id + ')>删除分类</button>'
                        +'       </div>'
                        +'   </div>'
                        +'</div>'


                    //将数据放到表格
                    $(""#buju"").append(line);
                })
            }
        })
    }

// <td><a href=""javascripts:;"" onclick=Del(' + this.id + ')>删除&nbsp;&nbsp;</a></td>'

//添加分类
function AddType() {
        var obj = {};
        obj.TypeName = $(""#typename"").val();
        //添加
        $.ajax({
            url: ""http://localhost:50222/api/GoodsType/Post"",
            type: ""Post"",
            data: JSON.stringify(obj),
            contentType: ""application/json"",
            success: function (d) {
                if (d != """") {
                    alert(""添加成功"");
                   ");
            WriteLiteral(@" location.href = '/sy/ShowType';
                }
                else {
                    alert(""添加失败"");
                    location.href = '/sy/ShowType';
                }
            }
        })
    }
//删除类型
function Del(id) {
        if (confirm(""确认删除码？"")) {
            $.ajax({
                url: ""http://localhost:50222/api/GoodsType/Delete?id="" + id,
                type: ""delete"",
                success: function (d) {
                    if (d > 0) {
                        alert(""删除成功"");
                        location.href = ""/sy/ShowType"";
                    }
                    else {
                        alert(""删除失败"");
                    }
                }
            })
        }
    }

</script>




");
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