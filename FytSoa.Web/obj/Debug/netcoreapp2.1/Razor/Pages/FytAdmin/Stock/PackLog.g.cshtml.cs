#pragma checksum "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89acc22041a11ef0180754e066abbed9edf25f31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_PackLog), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Stock/PackLog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Stock/PackLog.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_PackLog), null)]
namespace FytSoa.Web.Pages.FytAdmin.Stock
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89acc22041a11ef0180754e066abbed9edf25f31", @"/Pages/FytAdmin/Stock/PackLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Stock_PackLog : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form form-cus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
  
    ViewData["Title"] = "入库单管理";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 2606, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c2ce7bcf7ee42cf9e9174e1a836c045", async() => {
                BeginContext(194, 10, true);
                WriteLiteral("\r\n    <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 204, "\"", 271, 2);
                WriteAttributeValue("", 212, "layui-form-item", 212, 15, true);
#line 8 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
WriteAttributeValue(" ", 227, Model.PackModel.Types==2?"":"layui-hide", 228, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(272, 165, true);
                WriteLiteral(">\r\n        <label class=\"layui-form-label\">加盟商</label>\r\n        <div class=\"layui-input-block\">\r\n            <select name=\"ShopGuid\" lay-search=\"\">\r\n                ");
                EndContext();
                BeginContext(437, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "164ce011bb85403f87f84d104f2b9686", async() => {
                    BeginContext(454, 11, true);
                    WriteLiteral("请选择加盟商，支持搜索");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(474, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 13 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
                  
                    if (Model.List != null && Model.List.Count > 0)
                    {
                        foreach (var item in Model.List)
                        {
                            if (item.Guid == Model.PackModel.ShopGuid)
                            {

#line default
#line hidden
                BeginContext(776, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(808, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702431a5dd4a4930835d67a26acfeb86", async() => {
                    BeginContext(856, 13, false);
#line 20 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
                                                                          Write(item.ShopName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 20 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
                                   WriteLiteral(item.Guid);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(878, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 21 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(976, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1008, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "654b87f5804b4bf2a5f4f4d686bc4225", async() => {
                    BeginContext(1036, 13, false);
#line 24 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
                                                      Write(item.ShopName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 24 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
                                   WriteLiteral(item.Guid);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1058, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 25 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
                            }
                        }
                    }
                

#line default
#line hidden
                BeginContext(1160, 224, true);
                WriteLiteral("            </select>\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">订单号</label>\r\n        <div class=\"layui-input-block\">\r\n            <input type=\"text\" name=\"Number\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1384, "\"", 1415, 1);
#line 35 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
WriteAttributeValue("", 1392, Model.PackModel.Number, 1392, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1416, 306, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入订单号"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">名称</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""PackName""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1722, "\"", 1755, 1);
#line 41 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
WriteAttributeValue("", 1730, Model.PackModel.PackName, 1730, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1756, 307, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入名称"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">数量</label>
        <div class=""layui-input-block"">
            <input type=""number"" name=""GoodsSum""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2063, "\"", 2096, 1);
#line 47 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
WriteAttributeValue("", 2071, Model.PackModel.GoodsSum, 2071, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2097, 467, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入数量"" class=""layui-input"">

        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">立即提交</button>
            <button type=""reset"" class=""layui-btn layui-btn-primary btn-open-close"">取消</button>
        </div>
    </div>
    <input type=""hidden"" name=""guid"" id=""guid""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2564, "\"", 2593, 1);
#line 57 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
WriteAttributeValue("", 2572, Model.PackModel.Guid, 2572, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2594, 42, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Types\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2636, "\"", 2666, 1);
#line 58 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
WriteAttributeValue("", 2644, Model.PackModel.Types, 2644, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2667, 44, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"AddDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2711, "\"", 2743, 1);
#line 59 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\PackLog.cshtml"
WriteAttributeValue("", 2719, Model.PackModel.AddDate, 2719, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2744, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2756, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2775, 853, true);
                WriteLiteral(@"
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['layer', 'jquery', 'common', 'form'], function () {
            var form = layui.form, $ = layui.$, os = layui.common;
            var index = parent.layer.getFrameIndex(window.name);
            //监听提交
            form.on('submit(submit)', function (data) {
                var urls = ""api/stock/addpacklog"";
                if ($(""#guid"").val()) {
                    urls = ""api/stock/editpacklog"";
                }
                os.ajax(urls, data.field, function(res) {
                    parent.layer.close(index);
                });
                return false;
            });
            $("".btn-open-close"").on('click', function () {
                parent.layer.close(index);
            });

        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(3631, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Stock.PackLogModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.PackLogModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.PackLogModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Stock.PackLogModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
