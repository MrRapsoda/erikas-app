#pragma checksum "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6406162a0ebe2fda740cfebc23b030b8c6297570"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trajes2_Details), @"mvc.1.0.view", @"/Views/Trajes2/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6406162a0ebe2fda740cfebc23b030b8c6297570", @"/Views/Trajes2/Details.cshtml")]
    public class Views_Trajes2_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErikasApi.Models.Trajes2>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Trajes2</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CodigoT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml"
       Write(Html.DisplayFor(model => model.CodigoT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tela));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tela));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ajuste));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ajuste));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Talla));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml"
       Write(Html.DisplayFor(model => model.Talla));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml"
       Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1451, "\"", 1480, 1);
#nullable restore
#line 52 "D:\Universidad\2021\III Cuatri\Progra\Proyecto\ErikasApi\Views\Trajes2\Details.cshtml"
WriteAttributeValue("", 1466, Model.idTraje, 1466, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
