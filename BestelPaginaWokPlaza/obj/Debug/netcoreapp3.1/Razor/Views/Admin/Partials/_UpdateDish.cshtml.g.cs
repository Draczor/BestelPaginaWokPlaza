#pragma checksum "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_UpdateDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23b570be3c63334524c939f2a5101a7143bd3420"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Partials__UpdateDish), @"mvc.1.0.view", @"/Views/Admin/Partials/_UpdateDish.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23b570be3c63334524c939f2a5101a7143bd3420", @"/Views/Admin/Partials/_UpdateDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7a436f27b976c113ebbffde70fb84275da015c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Partials__UpdateDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestelPaginaWokPlaza.Models.AdminViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("updateDishForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dish-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("UpdateDish"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_UpdateDish.cshtml"
  
    ViewData["Title"] = "_UpdateDish";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"update-dish\">\r\n    <div class=\"pop-up-container\" id=\"pop-up-container update-pop-up\">\r\n        <div class=\"pop-up container\">\r\n            <h1>Gerecht wijzigen</h1>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23b570be3c63334524c939f2a5101a7143bd34205531", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 11 "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_UpdateDish.cshtml"
           Write(Html.HiddenFor(m => m.dishModel.id, new { htmlAttributes = new { @class = "form-control" }, }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <label class=\"form-control-static\">Naam:*</label>\r\n                ");
#nullable restore
#line 13 "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_UpdateDish.cshtml"
           Write(Html.EditorFor(m => m.dishModel.name, new { htmlAttributes = new { @class = "form-control" }, }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 14 "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_UpdateDish.cshtml"
           Write(Html.ValidationMessageFor(m => m.dishModel.name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                <label class=\"form-control-static\">Prijs:*</label>\r\n                ");
#nullable restore
#line 16 "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_UpdateDish.cshtml"
           Write(Html.EditorFor(m => m.dishModel.price, new { htmlAttributes = new { @class = "form-control" }, }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 17 "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_UpdateDish.cshtml"
           Write(Html.ValidationMessageFor(m => m.dishModel.price, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n\r\n                <label class=\"form-control-static\">Categorie:*</label>\r\n                ");
#nullable restore
#line 20 "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_UpdateDish.cshtml"
           Write(Html.DropDownListFor(m => m.dishModel.category_id, new SelectList(Model.categoryList, "Value", "Text")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_UpdateDish.cshtml"
           Write(Html.ValidationMessageFor(m => m.dishModel.category_id, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n\r\n                <label class=\"form-control-static\">Omschrijving:</label>\r\n                ");
#nullable restore
#line 24 "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_UpdateDish.cshtml"
           Write(Html.EditorFor(m => m.dishModel.description, new { htmlAttributes = new { @class = "form-control" }, }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 25 "C:\Users\Lei\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_UpdateDish.cshtml"
           Write(Html.ValidationMessageFor(m => m.dishModel.description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" <br />
                <div class=""pop-up-button-field"">
                    <input class=""btn btn-primary"" onclick=""replaceDotWithCommaUpdateDish()"" type=""submit"" value=""Opslaan"" />
                    <button type=""button"" id=""CancelUpdateDish"" class=""btn btn-secondary"">Annuleren</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        </div>
    </div>
</div>

<script>
    var items = document.querySelectorAll(""#UpdateDish"");
    items.forEach(item => {
        item.addEventListener(""click"", function (e) {
            var dishContent = e.target.parentElement.parentElement;

            var id = dishContent.querySelector("".dish-id"").value;
            $.post(""/Admin/GetDishById"", { id: id }, function (result) {
                document.querySelector("".update-dish #dishModel_id"").value = result[""id""];
                document.querySelector("".update-dish #dishModel_name"").value = result[""name""];
                var price = parseFloat(result[""price""]).toFixed(2);
                var priceAfterReplace = price.toString().replace(""."", "","");
                document.querySelector("".update-dish #dishModel_price"").value = priceAfterReplace;
                document.querySelector("".update-dish #dishModel_category_id"").value = result[""category_id""];
                document.querySelector("".update-dish #dishModel_description");
            WriteLiteral(@""").value = result[""description""];
            });

            document.querySelector("".update-dish"").style.display = ""block"";
        })
    });

    document.querySelector(""#CancelUpdateDish"").addEventListener(""click"", function (e) {
        document.querySelector("".update-dish"").style.display = ""none"";
    })

    function replaceDotWithCommaUpdateDish() {
        var x = document.getElementById(""updateDishForm"");
        var xValue = x.querySelector(""#dishModel_price"").value;
        x.querySelector(""#dishModel_price"").value = xValue.replaceAll(""."", "","");
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestelPaginaWokPlaza.Models.AdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
