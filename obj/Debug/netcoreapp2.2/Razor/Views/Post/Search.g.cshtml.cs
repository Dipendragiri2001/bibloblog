#pragma checksum "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b14db46bae7661c3ca524a922521b4fe42e0d2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Search), @"mvc.1.0.view", @"/Views/Post/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Search.cshtml", typeof(AspNetCore.Views_Post_Search))]
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
#line 1 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\_ViewImports.cshtml"
using PremiumAccount;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\_ViewImports.cshtml"
using PremiumAccount.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b14db46bae7661c3ca524a922521b4fe42e0d2f", @"/Views/Post/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6f2d6af402c9f54082137674e6b15fa55d90aed", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post-category cat-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 13, true);
            WriteLiteral("     <title> ");
            EndContext();
            BeginContext(33, 18, false);
#line 2 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
        Write(TempData["search"]);

#line default
#line hidden
            EndContext();
            BeginContext(51, 140, true);
            WriteLiteral(" </title>\r\n\r\n\r\n    <div class=\"section\">\r\n\t\t\t<!-- container -->\r\n\t\t\t<div class=\"container\">\r\n\t\t\t\r\n\t\t\t\t<!-- row -->\r\n\t\t\t\t<div class=\"row\">\t\r\n");
            EndContext();
#line 11 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                    if (Model.Count<=0)
                   {

#line default
#line hidden
            BeginContext(252, 87, true);
            WriteLiteral("<div class=\"col-md-12\">\r\n\t\t\t\t\t\t<div class=\"section-title\">\r\n\t\t\t\t\t\t\t<h2> No Result for \"");
            EndContext();
            BeginContext(340, 18, false);
#line 14 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                                           Write(TempData["search"]);

#line default
#line hidden
            EndContext();
            BeginContext(358, 36, true);
            WriteLiteral("\" </h2>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
            EndContext();
#line 17 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                   }
                   else
                   {

#line default
#line hidden
            BeginContext(463, 109, true);
            WriteLiteral("\t               <div class=\"col-md-12\">\r\n\t\t\t\t\t\t<div class=\"section-title\">\r\n\t\t\t\t\t\t\t<h2> Showing Results For \"");
            EndContext();
            BeginContext(573, 18, false);
#line 22 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                                                 Write(TempData["search"]);

#line default
#line hidden
            EndContext();
            BeginContext(591, 35, true);
            WriteLiteral("\"</h2>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
            EndContext();
#line 26 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                   foreach(var x in Model)
                  {

#line default
#line hidden
            BeginContext(703, 62, true);
            WriteLiteral("\t\t\t\t\t<div class=\"col-md-4\">\r\n\t\t\t\t\t\t<div class=\"post\">\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(765, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b14db46bae7661c3ca524a922521b4fe42e0d2f7216", async() => {
                BeginContext(876, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 880, "\"", 909, 2);
                WriteAttributeValue("", 886, "/postimages/", 886, 12, true);
#line 30 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
WriteAttributeValue("", 898, x.PhotoUrl, 898, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(910, 38, true);
                WriteLiteral(" alt=\"\" height=\"280px\" widget=\"140px\">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-title", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                                                                                                WriteLiteral(x.Title);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                                                                                                                        WriteLiteral(x.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(952, 76, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t<div class=\"post-body\">\r\n\t\t\t\t\t\t\t\t<div class=\"post-meta\">\r\n\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1028, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b14db46bae7661c3ca524a922521b4fe42e0d2f11224", async() => {
                BeginContext(1137, 10, false);
#line 33 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                                                                                                                                           Write(x.Category);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                                                                                                                       WriteLiteral(x.Category);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1151, 35, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<span class=\"post-date\">");
            EndContext();
            BeginContext(1187, 37, false);
#line 34 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                                                       Write(x.CreatedAt.ToString("MMMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 56, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<h3 class=\"post-title\">");
            EndContext();
            BeginContext(1280, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b14db46bae7661c3ca524a922521b4fe42e0d2f14665", async() => {
                BeginContext(1375, 7, false);
#line 36 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                                                                                                                                                Write(x.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-title", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                                                                                                          WriteLiteral(x.Title);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                                                                                                                                  WriteLiteral(x.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1386, 56, true);
            WriteLiteral("</h3>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\r\n\t\t\t\t\t</div>\r\n");
            EndContext();
#line 41 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                  }

#line default
#line hidden
#line 41 "C:\Users\Lenovo\Desktop\PremiumAccount\Views\Post\Search.cshtml"
                   
                   }

#line default
#line hidden
            BeginContext(1485, 89, true);
            WriteLiteral("\t\t\t\t\t\r\n                    </div>\r\n                    </div>\r\n                    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
