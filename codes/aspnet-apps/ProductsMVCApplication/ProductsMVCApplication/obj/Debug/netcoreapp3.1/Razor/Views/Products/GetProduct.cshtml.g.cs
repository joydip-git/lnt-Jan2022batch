#pragma checksum "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2af2fd32be79dd20705e99fb0d6fdbcead7c29dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_GetProduct), @"mvc.1.0.view", @"/Views/Products/GetProduct.cshtml")]
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
#line 6 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
using ProductsMVCApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2af2fd32be79dd20705e99fb0d6fdbcead7c29dd", @"/Views/Products/GetProduct.cshtml")]
    public class Views_Products_GetProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
  
    this.Layout = "~/Views/Shared/_Layout.cshtml";
    this.ViewBag.Title = "Product Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
  
    if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <fieldset style=\"width:300px;background-color:beige;font-family:\'Segoe UI\';font-size:medium\">\r\n            <legend style=\"font-size:large\">Details of ");
#nullable restore
#line 13 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
                                                  Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</legend>\r\n");
            WriteLiteral("            ");
#nullable restore
#line 15 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
       Write(Html.LabelFor(m => m.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            :&nbsp;\r\n");
            WriteLiteral("            <span>");
#nullable restore
#line 18 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
             Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <br />\r\n            ");
#nullable restore
#line 20 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
       Write(Html.LabelFor(m => m.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            :&nbsp;\r\n");
            WriteLiteral("            <span>");
#nullable restore
#line 23 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
             Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <br />\r\n            ");
#nullable restore
#line 25 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
       Write(Html.LabelFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            :&nbsp;\r\n");
            WriteLiteral("            <span>");
#nullable restore
#line 28 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
             Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <br />\r\n            ");
#nullable restore
#line 30 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
       Write(Html.LabelFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            :&nbsp;\r\n");
            WriteLiteral("            <span>");
#nullable restore
#line 33 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
             Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </fieldset>\r\n");
#nullable restore
#line 35 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
    }
    if (this.ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>");
#nullable restore
#line 38 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
         Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 39 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication\ProductsMVCApplication\Views\Products\GetProduct.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
