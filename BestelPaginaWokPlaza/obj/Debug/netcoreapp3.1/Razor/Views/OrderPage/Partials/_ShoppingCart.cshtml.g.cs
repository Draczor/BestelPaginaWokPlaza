#pragma checksum "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\OrderPage\Partials\_ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90e6cad371be0f6768370d9f65ed221ca9022cfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderPage_Partials__ShoppingCart), @"mvc.1.0.view", @"/Views/OrderPage/Partials/_ShoppingCart.cshtml")]
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
#line 1 "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\_ViewImports.cshtml"
using BestelPaginaWokPlaza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\_ViewImports.cshtml"
using BestelPaginaWokPlaza.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e6cad371be0f6768370d9f65ed221ca9022cfd", @"/Views/OrderPage/Partials/_ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7a436f27b976c113ebbffde70fb84275da015c8", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderPage_Partials__ShoppingCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""col-lg-3 shoppingCart-column"">
    <h5>Winkelmandje</h5>

    <div class=""shoppingCart"">

    </div>

    <div class=""shopping-cart-details"">
        <p class=""shopping-cart-delivery-cost"">Bezorgkosten:<span>&#8364; 2.00</span></p>
        <p class=""shopping-cart-total-price"">Totaalbedrag:<span class=""total-price"" id=""total-price""></span> </p>

        <button type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 408, "\"", 470, 3);
            WriteAttributeValue("", 418, "location.href=\'", 418, 15, true);
#nullable restore
#line 15 "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\OrderPage\Partials\_ShoppingCart.cshtml"
WriteAttributeValue("", 433, Url.Action("CheckOut", "OrderPage"), 433, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 469, "\'", 469, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success pay-button\">Afrekenen</button>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e6cad371be0f6768370d9f65ed221ca9022cfd4727", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $.get(""/ShoppingCart/GetAllShoppingCartItems"", function (result) {
        console.log(result);
        appendShoppingCart(result);
    });

    console.log(""totale prijs"");
    $.get(""/ShoppingCart/CalcTotalPrice"", function (result) {
        document.getElementById(""total-price"").innerHTML = ""&#8364; "" + parseFloat(result).toFixed(2);
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
