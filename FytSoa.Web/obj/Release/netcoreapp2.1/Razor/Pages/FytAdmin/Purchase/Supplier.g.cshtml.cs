#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Supplier.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caeacf5b485190292dbc120fde97fc0baa6722d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Purchase.Pages_FytAdmin_Purchase_Supplier), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Purchase/Supplier.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Purchase/Supplier.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Purchase.Pages_FytAdmin_Purchase_Supplier), null)]
namespace FytSoa.Web.Pages.FytAdmin.Purchase
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caeacf5b485190292dbc120fde97fc0baa6722d3", @"/Pages/FytAdmin/Purchase/Supplier.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Purchase_Supplier : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Supplier.cshtml"
  
    ViewData["Title"] = "供应商管理";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(150, 6672, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
            </div>            
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
        <div class=""layui-form list-search"" style=""margin-top:10px;"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolAdd""><i class=""layui-icon""></i> 新增</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolDel""><i class=""layui-icon""></i> 删除</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common'],
            function () {
         ");
            WriteLiteral(@"       var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common;
                table.render({
                    elem: '#tablist',
                    url: '/api/purchase/supplierlist',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'name',width:300, title: '供应商名称', sort: true, fixed: 'left' },
                            { field: 'contacts', title: '联系人' },
                            { field: 'mobile', title: '联系方式' },
                            { field: 'email', title: '邮箱'},
                            { field: 'summary', title: '描述' },
                            { field: 'addDate', title: '添加时间', sort: true },
                            { width: 100, title: '操作', templet: '#tool' }
                        ]
                    ],
                    page: true,
                    id: 'ta");
            WriteLiteral(@"bles'
                });

                var guid = '', active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    key: $(""#key"").val()
                                }
                            });
                    },
                    toolSearch: function () {
                        active.reload();
                    },
                    toolAdd: function () {
                        var winH = $(window).height();
                        layer.open({
                            title: '添加供应商'
                            , type: 2
                            , area: ['850px', winH - 60 + 'px']
                            , shade: [0.1, '#333']
                            , resize: false
                   ");
            WriteLiteral(@"         , anim: -1
                            , offset: 'rb'
                            , shadeClose: true
                            , skin: 'layer-anim-07'
                            , content: ""/fytadmin/purchase/suppliermodify""
                            , end: function () {
                                active.reload();
                            }
                        });
                        /*os.Open('添加供应商', '/fytadmin/purchase/suppliermodify', '850px', '550px', function () {
                            active.reload();
                        });*/
                    },
                    toolDel: function () {
                        var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.error(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(");
            WriteLiteral(@"data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/goods/delbarcode/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reload();
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });

                    }
                };
                $('.list-search .layui-btn').on('click', function () {
  ");
            WriteLiteral(@"                  var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        /*os.Open('编辑供应商', '/fytadmin/purchase/suppliermodify/?guid=' + data.guid, '850px', '550px', function () {
                            active.reload();
                        })*/
                        var winH = $(window).height();
                        layer.open({
                            title: '编辑供应商'
                            , type: 2
                            , area: ['850px', winH - 60 + 'px']
                            , shade: [0.1, '#333']
                            , resize: false
                            , anim: -1
                            , offset: 'rb'
                            , shadeClose: true
                            , ski");
            WriteLiteral(@"n: 'layer-anim-07'
                            , content: ""/fytadmin/purchase/suppliermodify/?guid="" + data.guid
                            , end: function () {
                                active.reload();
                            }
                        });
                    }
                });
            });
    </script>
    <script type=""text/html"" id=""tool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon""></i> 修改</a>
    </script>
</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Purchase.SupplierModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Purchase.SupplierModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Purchase.SupplierModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Purchase.SupplierModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591