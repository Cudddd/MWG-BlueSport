#pragma checksum "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Product/WhiteBackground.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ef210b30aa71d4144a84441ee2b964556c1d45e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Product_WhiteBackground), @"mvc.1.0.view", @"/Views/Shared/Components/Product/WhiteBackground.cshtml")]
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
#line 1 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/_ViewImports.cshtml"
using MWG_BlueSport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/_ViewImports.cshtml"
using MWG_BlueSport.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ef210b30aa71d4144a84441ee2b964556c1d45e", @"/Views/Shared/Components/Product/WhiteBackground.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f4307f4b3c7fc7049bdc1218ff4f5444da52e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Product_WhiteBackground : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("ADIDAS Adizero Takumi Sen 7 Tokyo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"listproduct listproduct-block owl-carousel\">\n");
#nullable restore
#line 4 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Product/WhiteBackground.cshtml"
          
          foreach (var item in @Model)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"item\">\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ef210b30aa71d4144a84441ee2b964556c1d45e4677", async() => {
                WriteLiteral("\n                <div class=\"item-wrap\">\n                  <div class=\"item-label\">\n                    <span class=\"lb-percent\">");
#nullable restore
#line 11 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Product/WhiteBackground.cshtml"
                                        Write(item.saleOff);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                    <span class=\"lb-tragop\">Góp 0%</span>\n                  </div>\n                  <div class=\"item-img\">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1ef210b30aa71d4144a84441ee2b964556c1d45e5500", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 571, "~/", 571, 2, true);
#nullable restore
#line 15 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Product/WhiteBackground.cshtml"
AddHtmlAttributeValue("", 573, item.image, 573, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                  </div>\n                </div>\n                <h3><span>");
#nullable restore
#line 18 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Product/WhiteBackground.cshtml"
                     Write(item.brandName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>  ");
#nullable restore
#line 18 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Product/WhiteBackground.cshtml"
                                             Write(item.name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h3>\n                <div class=\"price\">\n                  <p class=\"price-current\">");
#nullable restore
#line 20 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Product/WhiteBackground.cshtml"
                                      Write(item.priceCurrent);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                  <p class=\"price-old\">");
#nullable restore
#line 21 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Product/WhiteBackground.cshtml"
                                  Write(item.priceOld);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                </div>\n              ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-slug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Product/WhiteBackground.cshtml"
                                                                  WriteLiteral(item.slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 25 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Product/WhiteBackground.cshtml"
          }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591