#pragma checksum "C:\Users\lzhen\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_AddDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecbba59971bd58753e6b05156d1b8844e6375507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Partials__AddDish), @"mvc.1.0.view", @"/Views/Admin/Partials/_AddDish.cshtml")]
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
#line 1 "C:\Users\lzhen\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\_ViewImports.cshtml"
using BestelPaginaWokPlaza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lzhen\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\_ViewImports.cshtml"
using BestelPaginaWokPlaza.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecbba59971bd58753e6b05156d1b8844e6375507", @"/Views/Admin/Partials/_AddDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7a436f27b976c113ebbffde70fb84275da015c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Partials__AddDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestelPaginaWokPlaza.Models.AdminViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addDishForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dish-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("AddDish"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\lzhen\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_AddDish.cshtml"
  
        ViewData["Title"] = "_AddDish";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"add-dish\">\r\n    <div class=\"pop-up-container\" id=\"pop-up-container\">\r\n        <div class=\"pop-up container\">\r\n            <h1>Nieuwe gerecht</h1>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecbba59971bd58753e6b05156d1b8844e63755075499", async() => {
                WriteLiteral("\r\n                <label class=\"form-control-static\">Naam:*</label>\r\n                ");
#nullable restore
#line 12 "C:\Users\lzhen\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_AddDish.cshtml"
           Write(Html.EditorFor(m => m.dishModel.name, new { htmlAttributes = new { @class = "form-control" }, }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 13 "C:\Users\lzhen\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_AddDish.cshtml"
           Write(Html.ValidationMessageFor(m => m.dishModel.name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                <label class=\"form-control-static\">Prijs:*</label>\r\n                ");
#nullable restore
#line 15 "C:\Users\lzhen\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_AddDish.cshtml"
           Write(Html.EditorFor(m => m.dishModel.price, new { htmlAttributes = new { @class = "form-control" }, }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 16 "C:\Users\lzhen\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_AddDish.cshtml"
           Write(Html.ValidationMessageFor(m => m.dishModel.price, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n\r\n                <label class=\"form-control-static\">Categorie:*</label>\r\n                ");
#nullable restore
#line 19 "C:\Users\lzhen\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_AddDish.cshtml"
           Write(Html.DropDownListFor(m => m.dishModel.category_id, new SelectList(Model.categoryList, "Value", "Text")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\lzhen\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_AddDish.cshtml"
           Write(Html.ValidationMessageFor(m => m.dishModel.category_id, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n\r\n                <label class=\"form-control-static\">Omschrijving:*</label>\r\n                ");
#nullable restore
#line 23 "C:\Users\lzhen\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_AddDish.cshtml"
           Write(Html.EditorFor(m => m.dishModel.description, new { htmlAttributes = new { @class = "form-control" }, }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 24 "C:\Users\lzhen\source\repos\BestelPaginaWokPlaza\BestelPaginaWokPlaza\Views\Admin\Partials\_AddDish.cshtml"
           Write(Html.ValidationMessageFor(m => m.dishModel.description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" <br />
                <div class=""pop-up-button-field"">
                    <input class=""btn btn-primary"" onclick=""replaceDotWithCommaAddDish()"" type=""submit"" value=""Opslaan"" />
                    <button type=""button"" id=""CancelDish"" class=""btn btn-secondary"">Annuleren</button>
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
    document.querySelector(""#AddDish"").addEventListener(""click"", function (e) {
        document.querySelector("".add-dish"").style.display = ""block"";
    })

    document.querySelector(""#CancelDish"").addEventListener(""click"", function (e) {
        document.querySelector("".add-dish"").style.display = ""none"";
    })

    function replaceDotWithCommaAddDish() {
        var x = document.getElementById(""addDishForm"");
        var xValue = x.querySelector(""#dishModel_price"").value;
        x.querySelector(""#dishModel_price"").value = xValue.replaceAll(""."", "","");
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestelPaginaWokPlaza.Models.AdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
