#pragma checksum "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\Tabycx\So.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b2af8528910f3b65c0ed266bd5740715c3e20fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tabycx_So), @"mvc.1.0.view", @"/Views/Tabycx/So.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b2af8528910f3b65c0ed266bd5740715c3e20fe", @"/Views/Tabycx/So.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eda6175a700d803f9eca1cfda22b4c408c40741", @"/Views/_ViewImports.cshtml")]
    public class Views_Tabycx_So : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\Tabycx\So.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>\r\n        <input type=\"hidden\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 107, "\"", 128, 1);
#nullable restore
#line 6 "D:\大实训二\电商代码MVC\E-commerce-platform-MVC\UI\Views\Tabycx\So.cshtml"
WriteAttributeValue("", 115, ViewBag.free, 115, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""free""/>
       

    </div>
    <script src=""https://code.highcharts.com.cn/highcharts/highcharts.js""></script>
    <script src=""https://code.highcharts.com.cn/highcharts/modules/exporting.js""></script>
    <script src=""https://code.highcharts.com.cn/highcharts/modules/series-label.js""></script>
    <script src=""https://code.highcharts.com.cn/highcharts/modules/oldie.js""></script>
    <script src=""https://code.highcharts.com.cn/highcharts-plugins/highcharts-zh_CN.js""></script>

<!-- Page Content -->
<div class=""container-fluid p-y-md"">
    <!-- Card Tabs -->
   
    <div class=""row"">
        <div class=""col-md-12"">
            <!-- Card Tabs Default Style -->
            <div class=""card"">
                <ul class=""nav nav-tabs"" data-toggle=""tabs"">
                    <li class=""active"">
                        <a href=""#btabs-static-home"">商品统计</a>
                    </li>
                    <li>
                        <a href=""#btabs-static-profile"">人数统计</a>
                 ");
            WriteLiteral(@"   </li>
                    <li>
                        <a href=""#btabs-static-3"">浏览次数</a>
                    </li>
                    
                    <li class=""pull-right"">
                        <a href=""#btabs-static-settings"" data-toggle=""tooltip"" title=""Settings""><i class=""ion-ios-gear-outline""></i></a>
                    </li>
                </ul>
                <div class=""card-block tab-content"">
                    <div class=""tab-pane active"" id=""btabs-static-home"">
                       
                            <div id=""container"" style=""max-width:1600px;height:600px""></div>
                            <script>
                                


                                var chart = Highcharts.chart('container', {
                                    title: {
                                        text: '2 ~ 9 男装总量'
                                    },
                                    subtitle: {
                                        text: '数据来源");
            WriteLiteral(@"：商品管理（数据）'
                                    },
                                    yAxis: {
                                        title: {
                                            text: '男装总量'
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
                                                connectorAllowed: false
                                            },
                                            pointStart: 2
                                        }
                                    },                                    
         ");
            WriteLiteral(@"                           series: [{
                                        name: '男装',
                                        data: [5000, 2000, 4500, 4000, 8000, 3020, 2000, 2800]
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
 ");
            WriteLiteral(@"                               });

                            </script>
                        
                            
                    </div>
                    <div class=""tab-pane"" id=""btabs-static-profile"">
                        <div id=""one"" style=""max-width:1600px;height:600px""></div>
                        <script>



                            var chart = Highcharts.chart('one', {
                                title: {
                                    text: '2 ~ 9 浏览量'
                                },
                                subtitle: {
                                    text: '数据来源：商品管理（数据）'
                                },
                                yAxis: {
                                    title: {
                                        text: '浏览次数'
                                    }
                                },
                                legend: {
                                    layout: 'vertical',
            ");
            WriteLiteral(@"                        align: 'right',
                                    verticalAlign: 'middle'
                                },
                                plotOptions: {
                                    series: {
                                        label: {
                                            connectorAllowed: false
                                        },
                                        pointStart: 2
                                    }
                                },
                                series: [{
                                    name: '浏览次数',
                                    data: [9, 8, 7, 11, 20, 50, 100, 200]
                                }],
                                responsive: {
                                    rules: [{
                                        condition: {
                                            maxWidth: 500
                                        },
                                        ");
            WriteLiteral(@"chartOptions: {
                                            legend: {
                                                layout: 'horizontal',
                                                align: 'center',
                                                verticalAlign: 'bottom'
                                            }
                                        }
                                    }]
                                }
                            });

                        </script>

                    </div>
                    <div class=""tab-pane"" id=""btabs-static-3"">
                        <div id=""ones"" style=""max-width:1600px;height:600px""></div>
                        <script>



                            var chart = Highcharts.chart('ones', {
                                title: {
                                    text: '2 ~ 9 月的衣服总量'
                                },
                                subtitle: {
                                    tex");
            WriteLiteral(@"t: '数据来源：商品管理（数据）'
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
                                            connectorAllowed: false
                                        },
                                        pointStart: 2
                                    }
                                },
                                series: [{
                                    name: '男装',
                    ");
            WriteLiteral(@"                data: [11, 8, 3, 4, 7,8, 31, 10]
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

                        </script>

                    </div>
                    
                    <div class=""tab-pane"" id=""btabs-static-settings"">
      ");
            WriteLiteral(@"                  <p>
                            最右边的
                        </p>
                    </div>
                </div>
            </div>
            <!-- End Card Tabs Default Style -->
            <!-- Card Tabs Alternative Style -->
            <!-- End Card Tabs Alternative Style -->
        </div>
        <!-- .col-md-12 -->
    </div>

</div>
<!-- .container -->
<!-- End Page Content -->
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
