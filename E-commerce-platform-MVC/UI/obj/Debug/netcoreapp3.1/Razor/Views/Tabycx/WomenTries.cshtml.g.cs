#pragma checksum "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\Tabycx\WomenTries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fc462bbd693693b5f1016d3822ba09f0939de8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tabycx_WomenTries), @"mvc.1.0.view", @"/Views/Tabycx/WomenTries.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc462bbd693693b5f1016d3822ba09f0939de8a", @"/Views/Tabycx/WomenTries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eda6175a700d803f9eca1cfda22b4c408c40741", @"/Views/_ViewImports.cshtml")]
    public class Views_Tabycx_WomenTries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\Tabycx\WomenTries.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <script src=""https://code.highcharts.com.cn/highcharts/highcharts.js""></script>
    <script src=""https://code.highcharts.com.cn/highcharts/modules/exporting.js""></script>
    <script src=""https://code.highcharts.com.cn/highcharts-plugins/highcharts-zh_CN.js""></script>
    <script src=""https://code.highcharts.com.cn/highcharts/modules/series-label.js""></script>
    <script src=""https://code.highcharts.com.cn/highcharts/modules/oldie.js""></script>

<div id=""container"" style=""max-width:1600px;height:800px""></div>
<script>


    var chart = Highcharts.chart('container', {
        title: {
            text: '2 ~ 9 月的衣服总量'
        },
        subtitle: {
            text: '数据来源：商品管理（数据）'
        },
        yAxis: {
            title: {
                text: '衣服总量'
            }
        },
        legend: {
            layout: 'vertical',
            align: 'right',
            verticalAlign: 'middle'
        },
        plotOptions: {
            series: {
                label: {
");
            WriteLiteral(@"                    connectorAllowed: false
                },
                pointStart: 2
            }
        },
        series: [{
            name: '男装',
            data: [55, 66, 33, 44, 77, 88, 11, 100]
        }, {
            name: '女装',
            data: [249, 24, 29, 29, 32, 30, 381, 404]
        }, {
            name: '童装',
            data: [11, 17, 160, 197, 20, 24, 321, 393]
        }, {
            name: '项目开发',
            data: [66, 55, 79, 12, 15, 22, 34, 34]
        }, {
            name: '其他',
            data: [108, 58, 55, 48, 89, 16, 74, 181]
        }],
        responsive: {
            rules: [{
                condition: {
                    maxWidth: 500
                },
                chartOptions: {
                    legend: {
                        layout: 'horizontal',
                        align: 'center',
                        verticalAlign: 'bottom'
                    }
                }
            }]
        }
    });

</");
            WriteLiteral("script>");
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
