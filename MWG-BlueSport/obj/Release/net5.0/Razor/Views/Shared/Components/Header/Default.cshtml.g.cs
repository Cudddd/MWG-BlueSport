#pragma checksum "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Header/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f354c9d4acfbe48a07e30fe58d9247841fe9cdb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f354c9d4acfbe48a07e30fe58d9247841fe9cdb8", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f4307f4b3c7fc7049bdc1218ff4f5444da52e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("header-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("header-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<header class=\"header\">\n    <div class=\"header__address\">\n      <a href=\"#\">Bluesport mở bán 4 siêu thị ở TP. Hồ Chí Minh</a>\n    </div>\n    <div class=\"header__main\">\n      <section>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f354c9d4acfbe48a07e30fe58d9247841fe9cdb85250", async() => {
                WriteLiteral("\n          <i class=\"icon-logo\"></i>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <ul class=\"list-menu\">\n");
#nullable restore
#line 13 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Header/Default.cshtml"
            
            foreach (var root in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <li>\n                <a href=\"javascript:void(0)\">");
#nullable restore
#line 17 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Header/Default.cshtml"
                                        Write(root.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                <div class=\"wrap-menu\">\n                  <div class=\"wrap-menu-main\">\n                    <ul class=\"submenu\">\n");
#nullable restore
#line 21 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Header/Default.cshtml"
                        
                        foreach (var sub in root.subCate)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <li>\n                            <a href=\"#\">");
#nullable restore
#line 25 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Header/Default.cshtml"
                                   Write(sub.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                            <ul class=\"sub-submenu\">\n");
#nullable restore
#line 27 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Header/Default.cshtml"
                                
                                foreach (var last in sub.subCate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                  <li><a href=\"#\">");
#nullable restore
#line 30 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Header/Default.cshtml"
                                             Write(last.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 31 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Header/Default.cshtml"
                                }
                              

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\n                          </li>\n");
#nullable restore
#line 35 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Header/Default.cshtml"
                        }
                      

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n                    <a href=\"#\" class=\"readmore-menu\">Xem tất cả danh mục ");
#nullable restore
#line 38 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Header/Default.cshtml"
                                                                     Write(root.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                  </div>\n                </div>\n              </li>\n");
#nullable restore
#line 42 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Shared/Components/Header/Default.cshtml"
            }
          

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f354c9d4acfbe48a07e30fe58d9247841fe9cdb810160", async() => {
                WriteLiteral("\n          <input type=\"text\" placeholder=\"Tìm kiếm tên thương hiệu, môn thể thao...\">\n          <button><i class=\"icon-search\"></i></button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <a href=""#"" class=""header-cart"">
          <i class=""icon-cart""></i>
          <span class=""number"">1</span>
        </a>
        <div class=""search-show"">
          <div class=""history-txt"">
            <p class=""txt"">Có phải bạn muốn tìm</p>
            <p>Giày đá bóng nam</p>
            <p>Giày nike</p>
            <p>Giày thể thao nam </p>
          </div>
          <div class=""search-product"">
            <p class=""search-product-txt"">Sản phẩm gợi ý</p>
            <ul>
              <li>
                <a href=""#"">
                  <div class=""img"">
                    <img src=""./images/img_search.png"" alt=""ADIDAS Adizero Takumi Sen 7 Tokyo"">
                  </div>
                  <div class=""ct"">
                    <h3>ADIDAS Adizero Takumi Sen 7 Tokyo</h3>
                    <div class=""price"">
                      <strong class=""price-current"">6.964.000đ</strong>
                      <span class=""price-old"">8.205.000đ</span>
                      <span class=""price-percent"">-20%<");
            WriteLiteral(@"/span>
                    </div>
                  </div>
                </a>
              </li>
              <li>
                <a href=""#"">
                  <div class=""img"">
                    <img src=""./images/img_search.png"" alt=""ADIDAS Adizero Takumi Sen 7 Tokyo"">
                  </div>
                  <div class=""ct"">
                    <h3>ADIDAS Adizero Takumi Sen 7 Tokyo</h3>
                    <div class=""price"">
                      <strong class=""price-current"">6.964.000đ</strong>
                      <span class=""price-old"">8.205.000đ</span>
                      <span class=""price-percent"">-20%</span>
                    </div>
                  </div>
                </a>
              </li>
              <li>
                <a href=""#"">
                  <div class=""img"">
                    <img src=""./images/img_search.png"" alt=""ADIDAS Adizero Takumi Sen 7 Tokyo"">
                  </div>
                  <div class=""ct"">
                    <h3>ADIDAS Adizero Takumi Sen ");
            WriteLiteral(@"7 Tokyo</h3>
                    <div class=""price"">
                      <strong class=""price-current"">6.964.000đ</strong>
                      <span class=""price-old"">8.205.000đ</span>
                      <span class=""price-percent"">-20%</span>
                    </div>
                  </div>
                </a>
              </li>
              <li>
                <a href=""#"">
                  <div class=""img"">
                    <img src=""./images/img_search.png"" alt=""ADIDAS Adizero Takumi Sen 7 Tokyo"">
                  </div>
                  <div class=""ct"">
                    <h3>ADIDAS Adizero Takumi Sen 7 Tokyo</h3>
                    <div class=""price"">
                      <strong class=""price-current"">6.964.000đ</strong>
                      <span class=""price-old"">8.205.000đ</span>
                      <span class=""price-percent"">-20%</span>
                    </div>
                  </div>
                </a>
              </li>
            </ul>
          </div>
        </d");
            WriteLiteral("iv>\n      </section>\n    </div>\n  </header>\n  <!-- / Header -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
