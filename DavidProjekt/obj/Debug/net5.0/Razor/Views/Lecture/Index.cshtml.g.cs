#pragma checksum "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26ee90c76dea92bef0a5b140820f193bfabf835e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lecture_Index), @"mvc.1.0.view", @"/Views/Lecture/Index.cshtml")]
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
#line 1 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\_ViewImports.cshtml"
using DavidProjekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\_ViewImports.cshtml"
using DavidProjekt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26ee90c76dea92bef0a5b140820f193bfabf835e", @"/Views/Lecture/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02cee31b33a6a273f0cea42aed1e0eb9099aa519", @"/Views/_ViewImports.cshtml")]
    public class Views_Lecture_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LectureViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-hide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/lecture/order"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/vendor/jquery-1.12.4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
  
    Layout = "../Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""/"">Home</a></li>
                        <li class=""breadcrumb-item active""> Panel</li>
                        <li class=""breadcrumb-item active""> Categories</li>

                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->
    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">

                        <div class=""card-body"">
");
#nullable restore
#line 32 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
                             if (Model.Count > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1180, "\"", 1232, 2);
            WriteAttributeValue("", 1187, "/lecture/add/", 1187, 13, true);
#nullable restore
#line 34 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
WriteAttributeValue("", 1200, Model.FirstOrDefault().CourseId, 1200, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add lecture</a>\r\n");
#nullable restore
#line 35 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1404, "\"", 1469, 2);
            WriteAttributeValue("", 1411, "/lecture/add/", 1411, 13, true);
#nullable restore
#line 39 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
WriteAttributeValue("", 1424, Context.Request.Path.Value.Split('/').Last(), 1424, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add lecture</a>\r\n");
#nullable restore
#line 40 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div id=""example2_wrapper"" class=""dataTables_wrapper dt-bootstrap4"">
                                <div class=""row""><div class=""col-sm-12 col-md-6""></div><div class=""col-sm-12 col-md-6""></div></div><div class=""row"">
                                    <div class=""col-sm-12"">
");
#nullable restore
#line 45 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
                                         if (Model.Count > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26ee90c76dea92bef0a5b140820f193bfabf835e8941", async() => {
                WriteLiteral(@"
                                                <table id=""dataTable"" class=""table table-bordered dataTable table-hover dataTable dtr-inline sort"" role=""grid"" cellpadding=""0"" cellspacing=""0"">
                                                    <thead>
                                                        <tr>
                                                            <th class=""index"">Order number</th>
                                                            <th>Name</th>
                                                            <th>Image</th>
                                                            <th>Video duration</th>
                                                            <th></th>
                                                            <th></th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
");
#nullable restore
#line 60 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
                                                         for (int i = 0; i < Model.Count; i++)
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <tr class=\"odd\">\r\n                                                                <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "26ee90c76dea92bef0a5b140820f193bfabf835e10683", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 63 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].OrderNum);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "26ee90c76dea92bef0a5b140820f193bfabf835e12323", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 64 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "26ee90c76dea92bef0a5b140820f193bfabf835e13952", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 65 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].CourseId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                <td class=\"dtr-control sorting_1\" tabindex=\"0\">");
#nullable restore
#line 66 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
                                                                                                          Write(Model[i].Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 67 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
                                                                 if (!string.IsNullOrEmpty(Model[i].ImageUrl))
                                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                    <td><a");
                BeginWriteAttribute("href", " href=\"", 3987, "\"", 4019, 2);
                WriteAttributeValue("", 3994, "/files/", 3994, 7, true);
#nullable restore
#line 69 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
WriteAttributeValue("", 4001, Model[i].ImageUrl, 4001, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">Image</a></td>\r\n");
#nullable restore
#line 70 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"

                                                                }
                                                                else
                                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                    <td><a>No image</a></td>\r\n");
#nullable restore
#line 75 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"

                                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                <td>");
#nullable restore
#line 77 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
                                                               Write(Model[i].Length);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                                <td><a");
                BeginWriteAttribute("href", " href=\"", 4583, "\"", 4590, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"delete\" data-id=\"");
#nullable restore
#line 78 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
                                                                                                  Write(Model[i].Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Delete</a></td>\r\n                                                                <td><a");
                BeginWriteAttribute("href", " href=\"", 4717, "\"", 4750, 2);
                WriteAttributeValue("", 4724, "/lecture/edit/", 4724, 14, true);
#nullable restore
#line 79 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
WriteAttributeValue("", 4738, Model[i].Id, 4738, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Edit</a></td>\r\n                                                            </tr>\r\n");
#nullable restore
#line 81 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                                    </tbody>
                                                </table>
                                                <button class=""btn btn-info"" type=""submit"">Save order</button>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 88 "C:\Users\cornet1\source\repos\dava\DavidProjekt\Views\Lecture\Index.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->

                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </section>
    <!-- /.content -->
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26ee90c76dea92bef0a5b140820f193bfabf835e21692", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $("".delete"").click((e) => {
        var check = confirm(""Are you sure ?"");
        if (check) {
            var id = (e.currentTarget.attributes[2].value);
            console.log(id);
            $.ajax({
                url: ""/lecture/delete/"" + id,
                method: ""DELETE"",
                success: (result) => {
                    alert(""lecture deleted."");
                    location.reload();
                },
                error: (err) => {
                    alert(""Error."");
                }
            });
        }
    });
</script>
<script src=""https://ajax.googleapis.com/ajax/libs/jqueryui/1.10.3/jquery-ui.min.js""></script>

<script>
    var editor; // use a global for the submit and return data rendering in the examples

    var fixHelperModified = function (e, tr) {
        console.log(1);
        var $originals = tr.children();
        var $helper = tr.clone();
        $helper.children().each(function (index) {
            $(this).width");
            WriteLiteral(@"($originals.eq(index).width())
        });
        return $helper;
    },
        updateIndex = function (e, ui) {
            $('input.index', ui.item.parent()).each(function (i) {
                $(this).val(i + 1);
            });
        };

    $("".sort tbody"").sortable({
        helper: fixHelperModified,
        stop: updateIndex
    }).disableSelection();



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LectureViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
