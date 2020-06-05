#pragma checksum "E:\SanZuShiZhanEr\电商代码MVC\E-commerce-platform-MVC\UI\Views\Statisticss\Homepage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1ed23791a9bc2c868c21cf4fba645060f1190c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statisticss_Homepage), @"mvc.1.0.view", @"/Views/Statisticss/Homepage.cshtml")]
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
#line 1 "E:\SanZuShiZhanEr\电商代码MVC\E-commerce-platform-MVC\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SanZuShiZhanEr\电商代码MVC\E-commerce-platform-MVC\UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1ed23791a9bc2c868c21cf4fba645060f1190c8", @"/Views/Statisticss/Homepage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Statisticss_Homepage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\SanZuShiZhanEr\电商代码MVC\E-commerce-platform-MVC\UI\Views\Statisticss\Homepage.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- Page Content -->
<div class=""container-fluid p-y-md"">
    <!-- Stats -->
    <div class=""row"">
        <div class=""col-sm-6 col-lg-3"">
            <a class=""card"" href=""javascript:void(0)"">
                <div class=""card-block clearfix"">
                    <div class=""pull-right"">
                        <p class=""h6 text-muted m-t-0 m-b-xs"">收益</p>
                        <p class=""h3 text-blue m-t-sm m-b-0"">$120.9k</p>
                    </div>
                    <div class=""pull-left m-r"">
                        <span class=""img-avatar img-avatar-48 bg-blue bg-inverse""><i class=""ion-ios-bell fa-1-5x""></i></span>
                    </div>
                </div>
            </a>
        </div>
        <!-- .col-sm-6 -->

        <div class=""col-sm-6 col-lg-3"">
            <a class=""card bg-green bg-inverse"" href=""javascript:void(0)"">
                <div class=""card-block clearfix"">
                    <div class=""pull-right"">
                        <p class=""h6 text-");
            WriteLiteral(@"muted m-t-0 m-b-xs"">访客总数</p>
                        <p class=""h3 m-t-sm m-b-0"">920 000</p>
                    </div>
                    <div class=""pull-left m-r"">
                        <span class=""img-avatar img-avatar-48 bg-gray-light-o""><i class=""ion-ios-people fa-1-5x""></i></span>
                    </div>
                </div>
            </a>
        </div>
        <!-- .col-sm-6 -->

        <div class=""col-sm-6 col-lg-3"">
            <a class=""card bg-blue bg-inverse"" href=""javascript:void(0)"">
                <div class=""card-block clearfix"">
                    <div class=""pull-right"">
                        <p class=""h6 text-muted m-t-0 m-b-xs"">收益</p>
                        <p class=""h3 m-t-sm m-b-0"">$340.5k</p>
                    </div>
                    <div class=""pull-left m-r"">
                        <span class=""img-avatar img-avatar-48 bg-gray-light-o""><i class=""ion-ios-speedometer fa-1-5x""></i></span>
                    </div>
                </div>
    ");
            WriteLiteral(@"        </a>
        </div>
        <!-- .col-sm-6 -->

        <div class=""col-sm-6 col-lg-3"">
            <a class=""card bg-purple bg-inverse"" href=""javascript:void(0)"">
                <div class=""card-block clearfix"">
                    <div class=""pull-right"">
                        <p class=""h6 text-muted m-t-0 m-b-xs"">信息</p>
                        <p class=""h3 m-t-sm m-b-0"">3 条新信息</p>
                    </div>
                    <div class=""pull-left m-r"">
                        <span class=""img-avatar img-avatar-48 bg-gray-light-o""><i class=""ion-ios-email fa-1-5x""></i></span>
                    </div>
                </div>
            </a>
        </div>
        <!-- .col-sm-6 -->
    </div>
    <!-- .row -->
    <!-- End stats -->

    <div class=""row"">
        <!-- Company overview Chart -->
        <div class=""col-lg-8"">
            <div class=""card"">
                <div class=""card-header bg-blue bg-inverse"">
                    <h4>店铺 概况</h4>
                 ");
            WriteLiteral(@"   <ul class=""card-actions"">
                        <li>
                            <span class=""label bg-green"">统计<span class=""hidden-xs""></span> <i class=""ion-connection-bars""></i></span>
                        </li>
                    </ul>
                </div>
                <div class=""card-block p-b-0 bg-blue bg-inverse"">
                    <!-- Chart.js Charts (initialized in js/pages/base_pages_dashboard.js), for more examples please check http://www.chartjs.org/docs/ -->
                    <div style=""height: 200px;""><canvas class=""js-chartjs-lines1""></canvas></div>
                </div>
                <div class=""card-block"">
                    <div class=""row"">
                        <div class=""col-xs-6 col-lg-3 b-r"">
                            <p class=""h6 small text-muted"">年度变化</p>
                            <p class=""h3 m-t-0 m-b-md"">+214.22</p>
                            <div class=""progress progress-mini m-b-sm"">
                                <div class=""prog");
            WriteLiteral(@"ress-bar progress-bar-green"" role=""progressbar"" aria-valuenow=""76"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 76%""></div>
                            </div>
                        </div>
                        <div class=""col-xs-6 col-lg-3 b-r visible-lg"">
                            <p class=""h6 small text-muted"">贸易份额</p>
                            <p class=""h3 m-t-0 m-b-md"">$28.74M</p>
                            <div class=""progress progress-mini m-b-sm"">
                                <div class=""progress-bar progress-bar-green"" role=""progressbar"" aria-valuenow=""84"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 84%""></div>
                            </div>
                        </div>
                        <div class=""col-xs-6 col-lg-3 b-r visible-lg"">
                            <p class=""h6 small text-muted"">年度变化</p>
                            <p class=""h3 m-t-0 m-b-md"">+74%</p>
                            <div class=""progress progress-mini m-b-sm"">
               ");
            WriteLiteral(@"                 <div class=""progress-bar progress-bar-green"" role=""progressbar"" aria-valuenow=""74"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 74%""></div>
                            </div>
                        </div>
                        <div class=""col-xs-6 col-lg-3"">
                            <p class=""h6 small text-muted"">总收益</p>
                            <p class=""h3 m-t-0 m-b-md"">$74.23M</p>
                            <div class=""progress progress-mini m-b-sm"">
                                <div class=""progress-bar progress-bar-green"" role=""progressbar"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 90%""></div>
                            </div>
                        </div>
                    </div>
                    <!-- .row -->
                </div>
                <!-- .card-block -->
            </div>
            <!-- .card -->
        </div>
        <!-- .col-lg-8 -->
        <!-- End Company overview Chart -->
        <!-- We");
            WriteLiteral(@"ekly transactions Widget -->
        <div class=""col-lg-4"">
            <div class=""card"">
                <div class=""card-header"">
                    <h4>每周 交易</h4>
                    <ul class=""card-actions"">
                        <li class=""dropdown"">
                            <button type=""button"" data-toggle=""dropdown""><i class=""ion-more""></i></button>
                            <ul class=""dropdown-menu dropdown-menu-right"">
                                <li class=""dropdown-header"">Profile</li>
                                <li>
                                    <a tabindex=""-1"" href=""javascript:void(0)""><span class=""badge pull-right"">3</span> 消息</a>
                                </li>
                                <li>
                                    <a tabindex=""-1"" href=""javascript:void(0)""><span class=""badge pull-right"">1</span> 信息</a>
                                </li>
                                <li class=""divider""></li>
                                ");
            WriteLiteral(@"<li class=""dropdown-header"">更多</li>
                                <li>
                                    <a tabindex=""-1"" href=""javascript:void(0)"">编辑资料..</a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                    <!-- .card-actions -->
                </div>
                <!-- .card-header -->
                <div class=""card-block p-b-0"">
                    <div style=""height: 268px;""><canvas class=""js-chartjs-lines2""></canvas></div>
                </div>
                <div class=""card-block text-center"">
                    <span class=""label bg-green m-r-xs"">统计 <i class=""ion-connection-bars""></i></span> <small>for the <a href=""javascript:void(0)"">last year</a></small>
                </div>
            </div>
        </div>
        <!-- .col-lg-4 -->
        <!-- End Weekly transactions Widget -->
    </div>
    <!-- .row -->

    <div class=""row"">

        <div class=""col-lg-4"">");
            WriteLiteral(@"
            <!-- Weekly users Widget -->
            <div class=""card"">
                <div class=""card-header"">
                    <h4>每周一次的用户</h4>
                    <ul class=""card-actions"">
                        <li class=""dropdown"">
                            <button type=""button"" data-toggle=""dropdown""><i class=""ion-more""></i></button>
                            <ul class=""dropdown-menu dropdown-menu-right"">
                                <li class=""dropdown-header"">简况</li>
                                <li>
                                    <a tabindex=""-1"" href=""javascript:void(0)""><span class=""badge pull-right"">3</span> 消息</a>
                                </li>
                                <li>
                                    <a tabindex=""-1"" href=""javascript:void(0)""><span class=""badge pull-right"">1</span> 信息</a>
                                </li>
                                <li class=""divider""></li>
                                <li class=""dropdown-h");
            WriteLiteral(@"eader"">更多</li>
                                <li>
                                    <a tabindex=""-1"" href=""javascript:void(0)"">编辑资料..</a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </div>
                <div class=""card-block"">
                    <div style=""height: 238px;""><canvas class=""js-chartjs-bars""></canvas></div>
                </div>
                <div class=""card-block text-center"">
                    <span class=""label bg-green m-r-xs"">统计 <i class=""ion-connection-bars""></i></span> <small>for the <a href=""javascript:void(0)"">last year</a></small>
                </div>
            </div>
            <!-- .card -->
            <!-- End Weekly users Widget -->
        </div>
        <!-- .col-lg-4 -->

        <div class=""col-lg-8"">
            <!-- Transactions history Widget -->
            <div class=""card"">
                <div class=""card-header"">
                ");
            WriteLiteral(@"    <h4>交易历史</h4>
                    <ul class=""card-actions"">
                        <li class=""dropdown"">
                            <button type=""button"" data-toggle=""dropdown""><i class=""ion-more""></i></button>
                            <ul class=""dropdown-menu dropdown-menu-right"">
                                <li class=""dropdown-header"">概况</li>
                                <li>
                                    <a tabindex=""-1"" href=""javascript:void(0)""><span class=""badge pull-right"">3</span> 消息</a>
                                </li>
                                <li>
                                    <a tabindex=""-1"" href=""javascript:void(0)""><span class=""badge pull-right"">1</span> 信息</a>
                                </li>
                                <li class=""divider""></li>
                                <li class=""dropdown-header"">更多</li>
                                <li>
                                    <a tabindex=""-1"" href=""javascript:void(0)"">编辑资料.");
            WriteLiteral(@".</a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </div>
                <div class=""card-block"">
                    <div style=""height: 238px;""><canvas class=""js-chartjs-lines3""></canvas></div>
                </div>
                <div class=""card-block text-center"">
                    <span class=""label bg-green m-r-xs"">统计 <i class=""ion-connection-bars""></i></span> <small>for the <a href=""javascript:void(0)"">last year</a></small>
                </div>
            </div>
            <!-- .card -->
            <!-- End Transactions history Widget -->
        </div>
        <!-- .col-lg-8 -->
    </div>
    <!-- .row -->

    <div class=""row"">
        <div class=""col-lg-8"">
            <!-- Yearly summary widget -->
            <div class=""card"">
                <div class=""card-header"">
                    <h4>年度总结</h4>
                    <ul class=""card-actions"">
              ");
            WriteLiteral(@"          <li class=""dropdown"">
                            <button type=""button"" data-toggle=""dropdown""><i class=""ion-more""></i></button>
                            <ul class=""dropdown-menu dropdown-menu-right"">
                                <li class=""dropdown-header"">概况</li>
                                <li>
                                    <a tabindex=""-1"" href=""javascript:void(0)""><span class=""badge pull-right"">3</span> 消息</a>
                                </li>
                                <li>
                                    <a tabindex=""-1"" href=""javascript:void(0)""><span class=""badge pull-right"">1</span> 信息</a>
                                </li>
                                <li class=""divider""></li>
                                <li class=""dropdown-header"">更多</li>
                                <li>
                                    <a tabindex=""-1"" href=""javascript:void(0)"">编辑资料..</a>
                                </li>
                            </ul>");
            WriteLiteral(@"
                        </li>
                    </ul>
                    <!-- .card-actions -->
                </div>
                <!-- .card-header -->
                <div class=""card-block"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <p class=""h6 small text-muted"">年度变化</p>
                            <p class=""h3 m-t-0"">+214.22</p>
                            <!-- Chart.js Charts (initialized in js/pages/base_pages_dashboard.js), for more examples please check http://www.chartjs.org/docs/ -->
                            <div style=""height: 120px;""><canvas class=""js-chartjs-lines4""></canvas></div>
                        </div>
                        <div class=""col-sm-4"">
                            <p class=""h6 small text-muted"">贸易份额</p>
                            <p class=""h3 m-t-0"">$28.74M</p>
                            <!-- Chart.js Charts (initialized in js/pages/base_pages_dashboard.js), for more examples");
            WriteLiteral(@" please check http://www.chartjs.org/docs/ -->
                            <div style=""height: 120px;""><canvas class=""js-chartjs-lines5""></canvas></div>
                        </div>
                        <div class=""col-sm-4"">
                            <p class=""h6 small text-muted"">年度变化</p>
                            <p class=""h3 m-t-0"">+74%</p>
                            <!-- Chart.js Charts (initialized in js/pages/base_pages_dashboard.js), for more examples please check http://www.chartjs.org/docs/ -->
                            <div style=""height: 120px;""><canvas class=""js-chartjs-lines6""></canvas></div>
                        </div>
                    </div>
                </div>
                <!-- .card-block -->
            </div>
            <!-- .card -->
            <!-- End Yearly summary widget -->
        </div>
        <!-- .col-lg-8 -->
        <!-- Server load Widget -->
        <div class=""col-lg-4"">
            <div class=""card"">
                <div class=");
            WriteLiteral(@"""card-header bg-purple bg-inverse"">
                    <h4>系统负载</h4>
                    <ul class=""card-actions"">
                        <li>
                            <span class=""js-flot-live-info""></span>
                        </li>
                    </ul>
                </div>
                <div class=""card-block bg-purple p-x-0 p-b-0"">
                    <!-- Live Chart Container -->
                    <div class=""js-flot-live"" style=""height: 207px;""></div>
                </div>
            </div>
            <!-- .card -->
        </div>
        <!-- End Server load Widget // .col-lg-4 -->
    </div>
    <!-- .row -->
</div>
<!-- .container-fluid -->
<!-- End Page Content -->");
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
