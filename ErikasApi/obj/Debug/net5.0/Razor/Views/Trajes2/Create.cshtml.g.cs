#pragma checksum "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c0c4649ac3700e099f2e08968d126f9407c4066"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trajes2_Create), @"mvc.1.0.view", @"/Views/Trajes2/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c0c4649ac3700e099f2e08968d126f9407c4066", @"/Views/Trajes2/Create.cshtml")]
    public class Views_Trajes2_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErikasApi.Models.Trajes2>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Trajes2</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""CodigoT"" class=""control-label""></label>
                <input asp-for=""CodigoT"" class=""form-control"" />
                <span asp-validation-for=""CodigoT"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Nombre"" class=""control-label""></label>
                <input asp-for=""Nombre"" class=""form-control"" />
                <span asp-validation-for=""Nombre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Tela"" class=""control-label""></label>
                <input asp-for=""Tela"" class=""form-control"" />
                <span asp-validation-for=""Tela"" class=""text-danger""></span>
            </d");
            WriteLiteral(@"iv>
            <div class=""form-group"">
                <label asp-for=""Ajuste"" class=""control-label""></label>
                <input asp-for=""Ajuste"" class=""form-control"" />
                <span asp-validation-for=""Ajuste"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Talla"" class=""control-label""></label>
                <input asp-for=""Talla"" class=""form-control"" />
                <span asp-validation-for=""Talla"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Precio"" class=""control-label""></label>
                <input asp-for=""Precio"" class=""form-control"" />
                <span asp-validation-for=""Precio"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-actio");
            WriteLiteral("n=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 57 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErikasApi.Models.Trajes2> Html { get; private set; }
    }
}
#pragma warning restore 1591
