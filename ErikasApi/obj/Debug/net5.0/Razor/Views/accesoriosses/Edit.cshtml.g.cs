#pragma checksum "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\accesoriosses\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4cead45f0b1fffb2a27a22ae52a7760cadad093"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_accesoriosses_Edit), @"mvc.1.0.view", @"/Views/accesoriosses/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4cead45f0b1fffb2a27a22ae52a7760cadad093", @"/Views/accesoriosses/Edit.cshtml")]
    public class Views_accesoriosses_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErikasApi.Models.accesorioss>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\accesoriosses\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>accesorioss</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""idAccesorio"" />
            <div class=""form-group"">
                <label asp-for=""tipoAccesorio"" class=""control-label""></label>
                <input asp-for=""tipoAccesorio"" class=""form-control"" />
                <span asp-validation-for=""tipoAccesorio"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""color"" class=""control-label""></label>
                <input asp-for=""color"" class=""form-control"" />
                <span asp-validation-for=""color"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Precio"" class=""control-label""></label>
                <input asp-for=""Precio"" class=""form-control"" />
              ");
            WriteLiteral(@"  <span asp-validation-for=""Precio"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 43 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\accesoriosses\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErikasApi.Models.accesorioss> Html { get; private set; }
    }
}
#pragma warning restore 1591
