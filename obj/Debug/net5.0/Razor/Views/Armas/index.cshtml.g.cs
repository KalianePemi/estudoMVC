#pragma checksum "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbf64a9abf333af55dac6b87c85777ba776d0f52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Armas_index), @"mvc.1.0.view", @"/Views/Armas/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbf64a9abf333af55dac6b87c85777ba776d0f52", @"/Views/Armas/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Armas_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RpgMvc.Models.ArmaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\n        ");
#nullable restore
#line 7 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 8 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 10 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\n        ");
#nullable restore
#line 13 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 14 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 16 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
  ViewBag.Title = "Armas"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Título da página para o navegador-->\n<h2>Relação das Armas</h2><!--Título da página-->\n<p>\n    <!--Links apontando para views na mesma pasta-->\n    ");
#nullable restore
#line 20 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
Write(Html.ActionLink("Criar Nova Arma", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <tr><!--Títulos das colunas da tabela-->        \n        <th>");
#nullable restore
#line 24 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \n        <th>");
#nullable restore
#line 25 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \n        <th>");
#nullable restore
#line 26 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
       Write(Html.DisplayNameFor(model => model.Dano));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>        \n        <th></th>\n    </tr>\n    <!--Looping para escrever os dados na tabela-->\n");
#nullable restore
#line 30 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 33 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 34 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \n            <td>");
#nullable restore
#line 35 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dano));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \n                   \n            <td><!--Coluna para Links/botões-->\n                ");
#nullable restore
#line 38 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id = item.Id } ));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 39 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
           Write(Html.ActionLink("Detalhes", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 40 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
           Write(Html.ActionLink("Deletar", "Delete", new { id = item.Id }
                    , new { onclick = "return confirm('Deseja realmente deletar esta arma ?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n            </td>\n        </tr>\n        <tr>\n            <div class=\"form-group\">\n            ");
#nullable restore
#line 46 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
       Write(Html.DisplayName("Personagem"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 48 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
           Write(Html.DropDownListFor(model => model.Id, new SelectList(@ViewBag.listaPersonagens, "Id",
            "Nome"),
            "---Selecione---", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        </div>\n        </tr>\n");
#nullable restore
#line 53 "/Users/kalianepemi/Documents/Kaliane/ETEC/DS/projetosDoProfessor/RpgMvc/Views/Armas/index.cshtml"
    }  

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RpgMvc.Models.ArmaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591