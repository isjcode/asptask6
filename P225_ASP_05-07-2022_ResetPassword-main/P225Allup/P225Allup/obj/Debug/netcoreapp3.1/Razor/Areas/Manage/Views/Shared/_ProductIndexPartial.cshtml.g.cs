#pragma checksum "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\Shared\_ProductIndexPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "104bd0d798f8dfb341d6f9768c3dd0916812163c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Shared__ProductIndexPartial), @"mvc.1.0.view", @"/Areas/Manage/Views/Shared/_ProductIndexPartial.cshtml")]
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
#line 2 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P225Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P225Allup.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P225Allup.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P225Allup.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P225Allup.Areas.Manage.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"104bd0d798f8dfb341d6f9768c3dd0916812163c", @"/Areas/Manage/Views/Shared/_ProductIndexPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3869ceb6519146cabed9876c3a78f70ea91cae60", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manage_Views_Shared__ProductIndexPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\Shared\_ProductIndexPartial.cshtml"
  
    int no = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\Shared\_ProductIndexPartial.cshtml"
 foreach (Product product in Model)
{
    no++;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 10 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\Shared\_ProductIndexPartial.cshtml"
       Write(no);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 11 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\Shared\_ProductIndexPartial.cshtml"
       Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td");
            BeginWriteAttribute("class", " class=\"", 164, "\"", 228, 2);
            WriteAttributeValue("", 172, "text", 172, 4, true);
#nullable restore
#line 12 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\Shared\_ProductIndexPartial.cshtml"
WriteAttributeValue(" ", 176, product.IsDeleted ? "text-danger":"text-success", 177, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\Shared\_ProductIndexPartial.cshtml"
                                                                         Write(product.IsDeleted ? "DeActive":"Active");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "104bd0d798f8dfb341d6f9768c3dd0916812163c7938", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\Shared\_ProductIndexPartial.cshtml"
                                                                                                         WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "104bd0d798f8dfb341d6f9768c3dd0916812163c10752", async() => {
#nullable restore
#line 15 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\Shared\_ProductIndexPartial.cshtml"
                                                                                                                                                                                                                                                             Write(product.IsDeleted ? "ReStore":"Delete");

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 454, "btn", 454, 3, true);
#nullable restore
#line 15 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\Shared\_ProductIndexPartial.cshtml"
AddHtmlAttributeValue(" ", 457, product.IsDeleted ? "btn-primary":"btn-danger", 458, 49, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 507, "deleteandrestorebtn", 508, 20, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\Shared\_ProductIndexPartial.cshtml"
                                                                                                                                             WriteLiteral(product.IsDeleted ? "restore":"delete");

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\Shared\_ProductIndexPartial.cshtml"
                                                                                                                                                                                                     WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\Shared\_ProductIndexPartial.cshtml"
                                                                                                                                                                                                                                    WriteLiteral(ViewBag.Status);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-status", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </td>\n    </tr>\n");
#nullable restore
#line 18 "C:\Users\lasau\Downloads\P225_ASP_05-07-2022_ResetPassword-main\P225_ASP_05-07-2022_ResetPassword-main\P225Allup\P225Allup\Areas\Manage\Views\Shared\_ProductIndexPartial.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
