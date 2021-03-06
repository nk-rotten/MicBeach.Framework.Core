#pragma checksum "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\Sys\AuthorityBindOperationList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c6baa881931c404cc62470f5063803f4b185edb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sys_AuthorityBindOperationList), @"mvc.1.0.view", @"/Views/Sys/AuthorityBindOperationList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sys/AuthorityBindOperationList.cshtml", typeof(AspNetCore.Views_Sys_AuthorityBindOperationList))]
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
#line 1 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\_ViewImports.cshtml"
using Site.Cms;

#line default
#line hidden
#line 2 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\_ViewImports.cshtml"
using MicBeach.Web.Mvc;

#line default
#line hidden
#line 5 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\Sys\AuthorityBindOperationList.cshtml"
using MicBeach.Application.Identity.Auth;

#line default
#line hidden
#line 6 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\Sys\AuthorityBindOperationList.cshtml"
using MicBeach.Util.Extension;

#line default
#line hidden
#line 7 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\Sys\AuthorityBindOperationList.cshtml"
using MicBeach.Util.Serialize;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c6baa881931c404cc62470f5063803f4b185edb", @"/Views/Sys/AuthorityBindOperationList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e5000250b2a0bb9c30615591362c9282acaa0ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Sys_AuthorityBindOperationList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\Sys\AuthorityBindOperationList.cshtml"
  
    ViewBag.Title = "权限操作";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(193, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 8 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\Sys\AuthorityBindOperationList.cshtml"
      
        var statusValues = AuthorityOperationStatus.启用.GetType().GetEnumValueAndNames();
    

#line default
#line hidden
            BeginContext(298, 1485, true);
            WriteLiteral(@"    <div id=""pc-head"">
        <div class=""panel panel-default bd-lw-0 bd-rad-0 mg-0 bd-w-0"">
            <div class=""panel-body pd-10"">
                <div class=""lis_search fl"">
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control w-200"" id=""search_authname"" placeholder=""操作名称/编码"">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default fc_3"" type=""button"" id=""searchbusiness_btn"" onclick=""SearchOperation()""><i class=""glyphicon glyphicon-search""></i></button>
                        </span>
                    </div>
                </div>
                <div class=""fr"">
                    <button class=""btn btn-blue"" id=""btn_addoperation""><i class=""glyphicon glyphicon-plus""></i> 添加</button>
                    <button class=""btn btn-danger"" id=""deleteselect_btn""><i class=""glyphicon glyphicon-trash""></i> 删除</button>
                </div>
            </div>
        </div>
    <");
            WriteLiteral(@"/div>
    <div id=""pc-body"">
        <div id=""pc-body-inner"">
            <table class=""table table-striped table-bordered nowrap wp-100 bd-lw-0"" id=""operation_table"" cellpadding=""0"" cellspacing=""0""></table>
        </div>
    </div>
    <div id=""pc-foot"">
        <div class=""txt-right form-submitbtn-con pdr-10""><button type=""button"" onclick=""CloseWindow()"" class=""btn btn-blue""><i class=""glyphicon glyphicon-off""></i> 关闭</button></div>
    </div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1806, 327, true);
                WriteLiteral(@"
        <script type=""text/javascript"">
            BodyScroll = false;
            IsDialogPage = true;
            var nowOperationDatas = new Object();
            var operationStatusDic = new Object();
            $(function () {
                SearchOperation();
                operationStatusDic = JSON.parse('");
                EndContext();
                BeginContext(2134, 50, false);
#line 47 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\Sys\AuthorityBindOperationList.cshtml"
                                            Write(Html.Raw(JsonSerialize.ObjectToJson(statusValues)));

#line default
#line hidden
                EndContext();
                BeginContext(2184, 3043, true);
                WriteLiteral(@"');
                //操作表格
                InitDataTable({
                    TableEle: '#operation_table',
                    ""columnDefs"": [
                            {
                                ""title"": '<input type=""checkbox"" class=""cbx_all""/>', ""targets"": 0, ""data"": function (row, type, val, meta) {
                                    return '<input type=""checkbox"" class=""cbx_val"" value=""' + row.SysNo + '""/>';
                                }, width: '20px', className: 'txt-center'
                            },
                            { ""title"": ""名称"", ""targets"": 1, ""data"": 'Name', width: '150px' },
                            {
                                ""title"": ""方法编码"", ""targets"": 2, ""data"": 'ActionCode', width: '200px', render: function (data, type, row, meta) {
                                    return row.ControllerCode + '/' + row.ActionCode;
                                }
                            },
                            { ""title"": ""分组"", ""targets"": ");
                WriteLiteral(@"3, ""data"": 'Group.Name' },
                            {
                                ""title"": ""状态"", ""targets"": 4, ""data"": 'Status', width: '50px', className: 'txt-center', render: function (data, type, row, meta) {
                                    return operationStatusDic[data];
                                }
                            },
                            {
                                ""title"": ""操作"", ""targets"": 5, ""data"": function (row, type, val, meta) {
                                    return '<button type=""button"" class=""btn btn-xs btn-danger btn_delete_operation"" sysno=""' + row.SysNo + '""><i class=""glyphicon glyphicon-trash""></i> 删除</button>';
                                }, width: '62px', className: 'txt-center'
                            },
                    ]
                });

                //搜索事件
                $(""#search_btn"").click(function () {
                    SearchOperation();
                });

                //添加操作
            ");
                WriteLiteral(@"    $(""#btn_addoperation"").click(function () {
                    SelectOperation();
                });

                //删除操作
                $(""body"").on(""click"", "".btn_delete_operation"", function () {
                    var sysNo = $(this).attr(""sysno"");
                    DeleteOperation(sysNo);
                });

                //删除选中
                $(""#deleteselect_btn"").click(function () {
                    var checkedValues = GetDataTableCheckedValues(""#operation_table"");
                    if (!checkedValues || checkedValues.length <= 0) {
                        ErrorMsg(""还没有选择要删除的信息"");
                        return;
                    }
                    var checkedValueString = checkedValues.join("","");
                    DeleteOperation(checkedValueString);
                });
            })

            //搜索操作
            function SearchOperation() {
                var data = {
                    AuthorityFilter: { Codes: ['");
                EndContext();
                BeginContext(5228, 21, false);
#line 108 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\Sys\AuthorityBindOperationList.cshtml"
                                           Write(ViewBag.AuthorityCode);

#line default
#line hidden
                EndContext();
                BeginContext(5249, 126, true);
                WriteLiteral("\'] },\r\n                    OperationMateKey: $.trim($(\"#search_authname\").val())\r\n                };\r\n                $.post(\'");
                EndContext();
                BeginContext(5376, 49, false);
#line 111 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\Sys\AuthorityBindOperationList.cshtml"
                   Write(Url.Action("AuthorityBindOperationSearch", "Sys"));

#line default
#line hidden
                EndContext();
                BeginContext(5425, 866, true);
                WriteLiteral(@"', data, function (res) {
                    var jsonData = JSON.parse(res.Datas);
                    ReplaceDataTableData(""#operation_table"", jsonData);
                    $(window).resize();
                    for (var d in jsonData) {
                        var nowData = jsonData[d];
                        nowOperationDatas[nowData.SysNo] = { Data: nowData, Status: 0 };
                    }
                    InitDataTableChecked(""#operation_table"");
                });
            }

            //删除操作
            function DeleteOperation(sysnos) {
                if (!sysnos || sysnos == """") {
                    return;
                }
                UnBindOperation(sysnos.split(','));
            };

            //选择操作
            function SelectOperation() {
                DialogPage({
                    url: '");
                EndContext();
                BeginContext(6292, 50, false);
#line 134 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\Sys\AuthorityBindOperationList.cshtml"
                     Write(Url.Action("AuthorityOperationMultiSelect", "Sys"));

#line default
#line hidden
                EndContext();
                BeginContext(6342, 1282, true);
                WriteLiteral(@"',
                    width: ""600px"",
                    height: ""400px"",
                    title: '选择授权操作',
                    ok: false,
                    cancel: null
                });
            }

            //操作选中回调
            function AuthorityOperationMultiSelectCallback(operationDatas) {
                if (!operationDatas) {
                    return;
                }
                var newOperationIds = new Array();
                for (var a in operationDatas) {
                    var opera = operationDatas[a];
                    if (!opera) {
                        continue;
                    }
                    var nowOperation = nowOperationDatas[opera.SysNo];
                    if (nowOperation) {
                        continue;
                    }
                    newOperationIds.push(opera.SysNo);
                }
                if (newOperationIds.length > 0) {
                    BindOperation(newOperationIds);
                }
");
                WriteLiteral(@"            }

            //绑定操作
            function BindOperation(operations) {
                if (!operations || operations.length <= 0) {
                    return;
                }
                var data = {
                    authCode: '");
                EndContext();
                BeginContext(7625, 21, false);
#line 171 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\Sys\AuthorityBindOperationList.cshtml"
                          Write(ViewBag.AuthorityCode);

#line default
#line hidden
                EndContext();
                BeginContext(7646, 94, true);
                WriteLiteral("\',\r\n                    operationIds: operations\r\n                };\r\n                $.post(\'");
                EndContext();
                BeginContext(7741, 43, false);
#line 174 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\Sys\AuthorityBindOperationList.cshtml"
                   Write(Url.Action("AuthorityBindOperation", "Sys"));

#line default
#line hidden
                EndContext();
                BeginContext(7784, 452, true);
                WriteLiteral(@"', data, function (res) {
                    ResultMsg(res);
                    if (res.Success) {
                        SearchOperation();
                    }
                });
            }

            //解绑操作
            function UnBindOperation(operations) {
                if (!operations || operations.length <= 0) {
                    return;
                }
                var data = {
                    authCode: '");
                EndContext();
                BeginContext(8237, 21, false);
#line 188 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\Sys\AuthorityBindOperationList.cshtml"
                          Write(ViewBag.AuthorityCode);

#line default
#line hidden
                EndContext();
                BeginContext(8258, 220, true);
                WriteLiteral("\',\r\n                    operationIds: operations\r\n                };\r\n                for (var o in operations) {\r\n                    nowOperationDatas[operations[o]] = null;\r\n                }\r\n                $.post(\'");
                EndContext();
                BeginContext(8479, 45, false);
#line 194 "F:\Project\Framework\MicBeach.Core\App-Test\Web\Application\Site\Site.Cms\Views\Sys\AuthorityBindOperationList.cshtml"
                   Write(Url.Action("AuthorityUnBindOperation", "Sys"));

#line default
#line hidden
                EndContext();
                BeginContext(8524, 344, true);
                WriteLiteral(@"', data, function (res) {
                    ResultMsg(res);
                    if (res.Success) {
                        SearchOperation();
                    }
                });
            }

            //关闭
            function CloseWindow() {
                art.dialog.close(true);
            }
        </script>
    ");
                EndContext();
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
