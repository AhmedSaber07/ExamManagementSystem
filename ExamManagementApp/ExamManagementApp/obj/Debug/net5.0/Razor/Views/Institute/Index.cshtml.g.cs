#pragma checksum "F:\Projects\ExamManagementApp\ExamManagementApp\Views\Institute\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9923de5c821e76c8c255e7c158468567a36e0c80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Institute_Index), @"mvc.1.0.view", @"/Views/Institute/Index.cshtml")]
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
#line 1 "F:\Projects\ExamManagementApp\ExamManagementApp\Views\_ViewImports.cshtml"
using ExamManagementApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\ExamManagementApp\ExamManagementApp\Views\_ViewImports.cshtml"
using ExamManagementApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9923de5c821e76c8c255e7c158468567a36e0c80", @"/Views/Institute/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72e9b3ab3dfdf308934cb0362716ac58af930a28", @"/Views/_ViewImports.cshtml")]
    public class Views_Institute_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExamManagementApp.Models.Institute>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Projects\ExamManagementApp\ExamManagementApp\Views\Institute\Index.cshtml"
  
    Layout = "_DashboardLayout";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9923de5c821e76c8c255e7c158468567a36e0c805005", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9923de5c821e76c8c255e7c158468567a36e0c805267", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>#</th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "F:\Projects\ExamManagementApp\ExamManagementApp\Views\Institute\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "F:\Projects\ExamManagementApp\ExamManagementApp\Views\Institute\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "F:\Projects\ExamManagementApp\ExamManagementApp\Views\Institute\Index.cshtml"
         foreach (var item in Model.Select((value, i) => new { i, value }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"ContainSchool\">\r\n            <td class=\"fw-bold\">\r\n                ");
#nullable restore
#line 29 "F:\Projects\ExamManagementApp\ExamManagementApp\Views\Institute\Index.cshtml"
            Write((int)item.i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "F:\Projects\ExamManagementApp\ExamManagementApp\Views\Institute\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.value.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("                <input");
            BeginWriteAttribute("value", " value=\"", 1013, "\"", 1037, 1);
#nullable restore
#line 36 "F:\Projects\ExamManagementApp\ExamManagementApp\Views\Institute\Index.cshtml"
WriteAttributeValue("", 1021, item.value.Code, 1021, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"code bg-transparent w-100 border-0\" style=\"outline:none\" readonly />\r\n\r\n            </td>\r\n            <td>\r\n                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1178, "\"", 1204, 3);
            WriteAttributeValue("", 1188, "CopyFun(", 1188, 8, true);
#nullable restore
#line 40 "F:\Projects\ExamManagementApp\ExamManagementApp\Views\Institute\Index.cshtml"
WriteAttributeValue("", 1196, item.i, 1196, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1203, ")", 1203, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"copyBtn btn btn-dark border-0\"><i class=\"bi bi-clipboard\"></i></button>\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9923de5c821e76c8c255e7c158468567a36e0c8010133", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "F:\Projects\ExamManagementApp\ExamManagementApp\Views\Institute\Index.cshtml"
                                       WriteLiteral(item.value.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n");
            WriteLiteral("                <a href=\"javascript:;\" class=\"btn btn-outline-danger js-delete\" data-id=\"");
#nullable restore
#line 45 "F:\Projects\ExamManagementApp\ExamManagementApp\Views\Institute\Index.cshtml"
                                                                                    Write(item.value.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"bi bi-trash\"></i></a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 48 "F:\Projects\ExamManagementApp\ExamManagementApp\Views\Institute\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('.js-delete').on('click', function () {
                var btn = $(this);
                var ContainSchool = btn.closest('.ContainSchool');
                Swal.fire({
                    title: 'Are you sure?',
                    text: ""You won't be able to revert this!"",
                    icon: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Yes, delete it!'
                }).then((result) => {
                    if (result.isConfirmed) {
                        $.ajax({
                            url: '/Api/AdminApi/DeleteSchool/?schoolId=' + btn.data('id'),
                            method: 'DELETE',
                            success: function () {
                                Swal.fire({
                                    position: 'center',
                ");
                WriteLiteral(@"                    icon: 'success',
                                    title: 'Institution is deleted',
                                    showConfirmButton: false,
                                    timer: 1000
                                })
                                ContainSchool.fadeOut(1300, function () {
                                    ContainSchool.remove();
                                });
                            },
                            error: function () {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Oops...',
                                    text: 'Something went wrong!'
                                });
                            }
                        });
                    }
                });
            });

        });
    </script>
    <script>
        function CopyFun(classNumber) {
            var myCode = document.getElementsByClas");
                WriteLiteral(@"sName(""code"")[classNumber];
            myCode.select();
            document.execCommand(""copy"");
            myCode.setSelectionRange(0, 0);
            myCode.blur();
            var copyBtn = document.getElementsByClassName(""copyBtn"")[classNumber];
            setTimeout(function () {
                copyBtn.innerHTML = '<i class=""bi bi-check-lg""></i>'
            }, 10)
            setTimeout(function () {
                copyBtn.innerHTML = '<i class=""bi bi-clipboard""></i>'
            }, 2000)
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExamManagementApp.Models.Institute>> Html { get; private set; }
    }
}
#pragma warning restore 1591