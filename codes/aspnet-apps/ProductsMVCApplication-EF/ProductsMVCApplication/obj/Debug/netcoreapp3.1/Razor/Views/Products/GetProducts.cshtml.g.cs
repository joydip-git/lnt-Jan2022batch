#pragma checksum "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication-EF\ProductsMVCApplication\Views\Products\GetProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54523fdcd3e2076a31593e0e0e72620bd209aef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_GetProducts), @"mvc.1.0.view", @"/Views/Products/GetProducts.cshtml")]
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
#line 13 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication-EF\ProductsMVCApplication\Views\Products\GetProducts.cshtml"
using ProductsMVCApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54523fdcd3e2076a31593e0e0e72620bd209aef6", @"/Views/Products/GetProducts.cshtml")]
    public class Views_Products_GetProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--class GetProducts: RazorPageBase -->
<!-- this following line will create a container for this view. only List<Product> type data can be stored in the container. and the controller action, using this container, can only pass List<Product> of type data to this view-->
");
#nullable restore
#line 3 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication-EF\ProductsMVCApplication\Views\Products\GetProducts.cshtml"
  
    this.Layout = "~/Views/Shared/_Layout.cshtml";
    this.ViewBag.Title = "All Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h4>All Products</h4>\r\n<hr />\r\n\r\n");
#nullable restore
#line 20 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication-EF\ProductsMVCApplication\Views\Products\GetProducts.cshtml"
  
    if (Model != null)
    {
        var produts = this.Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n");
#nullable restore
#line 25 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication-EF\ProductsMVCApplication\Views\Products\GetProducts.cshtml"
             foreach (Product p in produts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 27 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication-EF\ProductsMVCApplication\Views\Products\GetProducts.cshtml"
               Write(p.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 28 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication-EF\ProductsMVCApplication\Views\Products\GetProducts.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 30 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication-EF\ProductsMVCApplication\Views\Products\GetProducts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 33 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication-EF\ProductsMVCApplication\Views\Products\GetProducts.cshtml"
  
    if (ViewBag.Error != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>");
#nullable restore
#line 36 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication-EF\ProductsMVCApplication\Views\Products\GetProducts.cshtml"
         Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 37 "E:\LnT-Training\lnt-Jan2022batch\codes\aspnet-apps\ProductsMVCApplication-EF\ProductsMVCApplication\Views\Products\GetProducts.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591