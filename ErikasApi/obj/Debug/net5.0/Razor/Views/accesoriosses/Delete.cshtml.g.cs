#pragma checksum "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\accesoriosses\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a34a0f789d84cd5a8ffadaa2c3f0eedf992674e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_accesoriosses_Delete), @"mvc.1.0.view", @"/Views/accesoriosses/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a34a0f789d84cd5a8ffadaa2c3f0eedf992674e", @"/Views/accesoriosses/Delete.cshtml")]
    public class Views_accesoriosses_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErikasApi.Models.accesorioss>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\accesoriosses\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>accesorioss</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\accesoriosses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.tipoAccesorio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\accesoriosses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.tipoAccesorio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\accesoriosses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\accesoriosses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\accesoriosses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\accesoriosses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""idAccesorio"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErikasApi.Models.accesorioss> Html { get; private set; }
    }
}
#pragma warning restore 1591
