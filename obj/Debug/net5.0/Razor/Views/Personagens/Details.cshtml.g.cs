#pragma checksum "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6aacf8f829bfe3eef6297fb7ac1331c7e8fc213"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personagens_Details), @"mvc.1.0.view", @"/Views/Personagens/Details.cshtml")]
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
#line 1 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6aacf8f829bfe3eef6297fb7ac1331c7e8fc213", @"/Views/Personagens/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Personagens_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.PersonagemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
  
    ViewBag.Title = "Detalhes do Personagem";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Detalhes do Personagem</h2>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>");
#nullable restore
#line 9 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 10 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>");
#nullable restore
#line 12 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 13 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>    \r\n\r\n        <dt>");
#nullable restore
#line 15 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Classe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 16 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayFor(model => model.Classe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>    \r\n\r\n        <dt>");
#nullable restore
#line 18 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PontosVida));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 19 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayFor(model => model.PontosVida));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>    \r\n\r\n        <dt>");
#nullable restore
#line 21 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Disputas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 22 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayFor(model => model.Disputas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>    \r\n\r\n        <dt>");
#nullable restore
#line 24 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vitorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 25 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayFor(model => model.Vitorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>    \r\n\r\n        <dt>");
#nullable restore
#line 27 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Derrotas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 28 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayFor(model => model.Derrotas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>       \r\n\r\n        <dt>");
#nullable restore
#line 30 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Forca));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 31 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayFor(model => model.Forca));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>              \r\n\r\n        <dt>");
#nullable restore
#line 33 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Inteligencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 34 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayFor(model => model.Inteligencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>       \r\n\r\n        <dt>");
#nullable restore
#line 36 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Defesa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 37 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
       Write(Html.DisplayFor(model => model.Defesa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>          \r\n\r\n\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    <!--");
#nullable restore
#line 44 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
   Write(Html.ActionLink("Editar", "Edit", new { id = Model.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |-->\r\n    ");
#nullable restore
#line 45 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Personagens/Details.cshtml"
Write(Html.ActionLink("Retornar", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.PersonagemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
