#pragma checksum "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Home/_PartialProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a0312494adc9be9126bbe2be94bde90acba9456"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__PartialProduct), @"mvc.1.0.view", @"/Views/Home/_PartialProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a0312494adc9be9126bbe2be94bde90acba9456", @"/Views/Home/_PartialProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f4307f4b3c7fc7049bdc1218ff4f5444da52e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__PartialProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"listproduct listproduct-promo owl-carousel\">\n");
#nullable restore
#line 4 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Home/_PartialProduct.cshtml"
      
        foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"item\">\n                <a href=\"#\">\n                    <div class=\"item-wrap\">\n                        <div class=\"item-label\">\n                            <span class=\"lb-percent\">");
#nullable restore
#line 11 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Home/_PartialProduct.cshtml"
                                                Write(item.saleOff);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            <span class=\"lb-tragop\">Góp 0%</span>\n                        </div>\n                        <div class=\"item-img\">\n                            <img");
            BeginWriteAttribute("src", " src=\"", 540, "\"", 557, 1);
#nullable restore
#line 15 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Home/_PartialProduct.cshtml"
WriteAttributeValue("", 546, item.image, 546, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 558, "\"", 574, 1);
#nullable restore
#line 15 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Home/_PartialProduct.cshtml"
WriteAttributeValue("", 564, item.name, 564, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        </div>\n                    </div>\n                    <h3><span>");
#nullable restore
#line 18 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Home/_PartialProduct.cshtml"
                         Write(item.brandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 18 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Home/_PartialProduct.cshtml"
                                                Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\n                    <div class=\"price\">\n                        <p class=\"price-current\">");
#nullable restore
#line 20 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Home/_PartialProduct.cshtml"
                                            Write(item.priceCurrent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"price-old\">");
#nullable restore
#line 21 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Home/_PartialProduct.cshtml"
                                        Write(item.priceOld);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </a>
                <div class=""item-color"">
                    <a href=""javascript:void(0)"" class=""item-color-img active"">
                        <img src=""./images/img-color02.png"" alt=""test"">
                    </a>
                    <a href=""javascript:void(0)"" class=""item-color-img"">
                        <img src=""./images/img-color02.png"" alt=""test"">
                    </a>
                    <a href=""javascript:void(0)"" class=""item-color-img"">
                        <img src=""./images/img-color03.png"" alt=""test"">
                    </a>
                </div>
            </div>
");
#nullable restore
#line 36 "/Users/minhduc/Desktop/MWG-BlueSport/MWG-BlueSport/Views/Home/_PartialProduct.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("      \n</div>");
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