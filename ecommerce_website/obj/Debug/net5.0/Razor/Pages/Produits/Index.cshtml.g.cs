#pragma checksum "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\Produits\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fdb4efa1750ef9e314719b18b20a52a12b56908"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ecommerce_website.Pages.Produits.Pages_Produits_Index), @"mvc.1.0.razor-page", @"/Pages/Produits/Index.cshtml")]
namespace ecommerce_website.Pages.Produits
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
#line 1 "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\_ViewImports.cshtml"
using ecommerce_website;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fdb4efa1750ef9e314719b18b20a52a12b56908", @"/Pages/Produits/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dc05547be8f45de562808da87d0ec6337047748", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Produits_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\Produits\Index.cshtml"
  
    ViewData["Title"] = "Produits";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"product1\" class=\"section-p1\">\r\n    <h2>Products</h2>\r\n    <p>New Collection</p>\r\n    <div class=\"pro-container\">\r\n");
#nullable restore
#line 12 "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\Produits\Index.cshtml"
         foreach (var item in Model.produit)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"pro\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 342, "\"", 362, 1);
#nullable restore
#line 15 "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\Produits\Index.cshtml"
WriteAttributeValue("", 348, item.imageUrl, 348, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 363, "\"", 385, 1);
#nullable restore
#line 15 "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\Produits\Index.cshtml"
WriteAttributeValue("", 369, item.nomProduit, 369, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <div class=\"des\">\r\n                    <span>");
#nullable restore
#line 17 "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\Produits\Index.cshtml"
                     Write(item.nomProduit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <h5>");
#nullable restore
#line 18 "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\Produits\Index.cshtml"
                   Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    <div class=""star"">
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                    </div>
                    <h4>");
#nullable restore
#line 26 "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\Produits\Index.cshtml"
                   Write(item.prixProduit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fdb4efa1750ef9e314719b18b20a52a12b569087334", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"ProductId\"");
                BeginWriteAttribute("value", " value=\"", 1054, "\"", 1070, 1);
#nullable restore
#line 29 "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\Produits\Index.cshtml"
WriteAttributeValue("", 1062, item.id, 1062, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"idCategorie\"");
                BeginWriteAttribute("value", " value=\"", 1135, "\"", 1160, 1);
#nullable restore
#line 30 "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\Produits\Index.cshtml"
WriteAttributeValue("", 1143, item.categorieId, 1143, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    <div class=\"input-group\">\r\n                        <label for=\"quantity\">Quantité :</label>\r\n                        <input type=\"number\" name=\"quantitySelected\" id=\"quantitySelected\" value=\"1\" min=\"1\"");
                BeginWriteAttribute("max", " max=\"", 1386, "\"", 1406, 1);
#nullable restore
#line 33 "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\Produits\Index.cshtml"
WriteAttributeValue("", 1392, item.qteStock, 1392, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"input-quantity\" />\r\n                    </div>\r\n                    <button type=\"submit\" class=\"cart\"><i class=\"fas fa-shopping-cart\"></i> </button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"button-group\">\r\n                    <button type=\"button\" class=\"btn btn-details\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fdb4efa1750ef9e314719b18b20a52a12b5690810888", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-info-circle\"></i> Détails\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\Produits\Index.cshtml"
                                                         WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </button>\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 47 "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\Produits\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 51 "D:\ILISI\ILISI 2024-2025 3A\ASP.NET - B -\Ecommerce_Website\ecommerce_website\Pages\Produits\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ecommerce_website.Pages.Produits.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ecommerce_website.Pages.Produits.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ecommerce_website.Pages.Produits.IndexModel>)PageContext?.ViewData;
        public ecommerce_website.Pages.Produits.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
