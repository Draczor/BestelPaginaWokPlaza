#pragma checksum "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_SelectedOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b20133cdaae6c38ff708d6ec3d33e1d89b4b4e36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Partials__SelectedOrder), @"mvc.1.0.view", @"/Views/Admin/Partials/_SelectedOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b20133cdaae6c38ff708d6ec3d33e1d89b4b4e36", @"/Views/Admin/Partials/_SelectedOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7a436f27b976c113ebbffde70fb84275da015c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Partials__SelectedOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestelPaginaWokPlaza.Models.OverviewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""selected-order"">
    <div class=""pop-up-container"" id=""pop-up-container"">
        <div class=""pop-up container"">
            <h1 class=""pop-up-title"">Bestelling nr:</h1>
            <div class=""dishes-field""></div>
            <button type=""button"" id=""CancelPopup"" class=""btn btn-secondary"">Sluiten</button>
        </div>
    </div>
</div>

<script>
    var items = document.querySelectorAll(""#selectedRow"");
    items.forEach(item => {
        item.addEventListener(""click"", function (e) {
            var rowContent = e.target.parentElement;
            var id = rowContent.querySelector("".order-id"").innerHTML;

            $.get(""/Admin/ReturnDishAndOrderDetailsByOrderID"", { id: id }, function (result) {

                result.forEach(function (element) {

                    const quantityDish = element[""quantity""]
                    const totalPrice = quantityDish * element[""price""];
                    const dishesField = document.querySelector("".dishes-field"");
      ");
            WriteLiteral(@"              const popupTitle = document.querySelector("".pop-up-title"");
                    popupTitle.innerHTML = ""Bestelling nr: "" + element[""order_id""];

                    const newDiv = document.createElement(""div"");
                    newDiv.className = 'dish-order';
                    dishesField.append(newDiv);

                    const quantity = document.createElement(""p"");
                    quantity.className = 'dish-order-quantity';
                    quantity.innerHTML = element[""quantity""] + ""x"";
                    newDiv.append(quantity);

                    const name = document.createElement(""p"");
                    name.className = 'dish-order-name';
                    name.innerHTML = element[""name""];
                    newDiv.append(name);

                    const price = document.createElement(""p"");
                    price.className = 'dish-order-price';
                    price.innerHTML = ""&#8364; "" + totalPrice.toFixed(2);
                    newD");
            WriteLiteral(@"iv.append(price);
                })
            });

            document.querySelector("".selected-order"").style.display = ""block"";
        })
    });

    document.querySelector(""#CancelPopup"").addEventListener(""click"", function (e) {
        document.querySelector("".selected-order"").style.display = ""none"";

        var allDishFields = document.querySelectorAll("".dish-order"");

        allDishFields.forEach(function (element) {
            element.remove();
        });
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestelPaginaWokPlaza.Models.OverviewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
