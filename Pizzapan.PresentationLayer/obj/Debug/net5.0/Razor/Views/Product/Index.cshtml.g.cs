#pragma checksum "C:\Users\ozkan\source\repos\Casgem-.NetCore-Pizzapan-main\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad4d100459769c094fb850a9eee5291c3c203c85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\ozkan\source\repos\Casgem-.NetCore-Pizzapan-main\CasgemCoreProject\Pizzapan.PresentationLayer\Views\_ViewImports.cshtml"
using Pizzapan.PresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ozkan\source\repos\Casgem-.NetCore-Pizzapan-main\CasgemCoreProject\Pizzapan.PresentationLayer\Views\_ViewImports.cshtml"
using Pizzapan.PresentationLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ozkan\source\repos\Casgem-.NetCore-Pizzapan-main\CasgemCoreProject\Pizzapan.PresentationLayer\Views\_ViewImports.cshtml"
using Pizzapan.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad4d100459769c094fb850a9eee5291c3c203c85", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0397ff0275acef430a67e6784b17978a14cc0e67", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pizzapan.EntityLayer.Concrete.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ozkan\source\repos\Casgem-.NetCore-Pizzapan-main\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Ürün Listesi</h1>\n\n<table class=\"table table-bordered\">\n    <tr>\n        <th>#</th>\n        <th>Ürün Adı</th>\n        <th>Fiyat</th>\n        <th>KategoriID</th>\n        <th>Sil</th>\n        <th>Güncelle</th>\n    </tr>\n");
#nullable restore
#line 18 "C:\Users\ozkan\source\repos\Casgem-.NetCore-Pizzapan-main\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Product\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 21 "C:\Users\ozkan\source\repos\Casgem-.NetCore-Pizzapan-main\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Product\Index.cshtml"
           Write(item.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 22 "C:\Users\ozkan\source\repos\Casgem-.NetCore-Pizzapan-main\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Product\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 23 "C:\Users\ozkan\source\repos\Casgem-.NetCore-Pizzapan-main\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Product\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 24 "C:\Users\ozkan\source\repos\Casgem-.NetCore-Pizzapan-main\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Product\Index.cshtml"
           Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 573, "\"", 618, 2);
            WriteAttributeValue("", 580, "/Product/DeleteProduct/", 580, 23, true);
#nullable restore
#line 25 "C:\Users\ozkan\source\repos\Casgem-.NetCore-Pizzapan-main\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Product\Index.cshtml"
WriteAttributeValue("", 603, item.ProductID, 603, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 682, "\"", 727, 2);
            WriteAttributeValue("", 689, "/Product/UpdateProduct/", 689, 23, true);
#nullable restore
#line 26 "C:\Users\ozkan\source\repos\Casgem-.NetCore-Pizzapan-main\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Product\Index.cshtml"
WriteAttributeValue("", 712, item.ProductID, 712, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\n        </tr>\n");
#nullable restore
#line 28 "C:\Users\ozkan\source\repos\Casgem-.NetCore-Pizzapan-main\CasgemCoreProject\Pizzapan.PresentationLayer\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n<td><a href=\"/Product/AddProduct\" class=\"btn btn-outline-primary\">Yeni Ürün Girişi</a></td>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pizzapan.EntityLayer.Concrete.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591