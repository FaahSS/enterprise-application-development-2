#pragma checksum "D:\Documentos\FIAP\Analise e Desenvolvimento de Sistemas\2F\ENTERPRISE APPLICATION DEVELOPMENT\SOLUTIONS\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Usuario\cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d54b3a803f53c53e3a37fb9a94f958f65f5e38b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_cadastrar), @"mvc.1.0.view", @"/Views/Usuario/cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/cadastrar.cshtml", typeof(AspNetCore.Views_Usuario_cadastrar))]
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
#line 1 "D:\Documentos\FIAP\Analise e Desenvolvimento de Sistemas\2F\ENTERPRISE APPLICATION DEVELOPMENT\SOLUTIONS\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _04_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "D:\Documentos\FIAP\Analise e Desenvolvimento de Sistemas\2F\ENTERPRISE APPLICATION DEVELOPMENT\SOLUTIONS\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _04_Fiap.Web.AspNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d54b3a803f53c53e3a37fb9a94f958f65f5e38b0", @"/Views/Usuario/cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cab6835be4e66a23eaaf4573b7b637b298eb82", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fiap.Web.AspNet.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Usuario/cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "D:\Documentos\FIAP\Analise e Desenvolvimento de Sistemas\2F\ENTERPRISE APPLICATION DEVELOPMENT\SOLUTIONS\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Usuario\cadastrar.cshtml"
  
    ViewData["Title"] = "cadastrar";

#line default
#line hidden
            BeginContext(85, 24, true);
            WriteLiteral("\r\n<h1>Cadastrar</h1>\r\n\r\n");
            EndContext();
#line 8 "D:\Documentos\FIAP\Analise e Desenvolvimento de Sistemas\2F\ENTERPRISE APPLICATION DEVELOPMENT\SOLUTIONS\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Usuario\cadastrar.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(133, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(137, 10, false);
#line 10 "D:\Documentos\FIAP\Analise e Desenvolvimento de Sistemas\2F\ENTERPRISE APPLICATION DEVELOPMENT\SOLUTIONS\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Usuario\cadastrar.cshtml"
Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(147, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(150, 11, false);
#line 10 "D:\Documentos\FIAP\Analise e Desenvolvimento de Sistemas\2F\ENTERPRISE APPLICATION DEVELOPMENT\SOLUTIONS\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Usuario\cadastrar.cshtml"
           Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(161, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(164, 20, false);
#line 10 "D:\Documentos\FIAP\Analise e Desenvolvimento de Sistemas\2F\ENTERPRISE APPLICATION DEVELOPMENT\SOLUTIONS\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Usuario\cadastrar.cshtml"
                         Write(Model.DataNascimento);

#line default
#line hidden
            EndContext();
            BeginContext(184, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 11 "D:\Documentos\FIAP\Analise e Desenvolvimento de Sistemas\2F\ENTERPRISE APPLICATION DEVELOPMENT\SOLUTIONS\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Usuario\cadastrar.cshtml"
}

#line default
#line hidden
            BeginContext(193, 24, true);
            WriteLiteral("\r\n\r\n<p>Nome do Usuário: ");
            EndContext();
            BeginContext(218, 16, false);
#line 14 "D:\Documentos\FIAP\Analise e Desenvolvimento de Sistemas\2F\ENTERPRISE APPLICATION DEVELOPMENT\SOLUTIONS\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Usuario\cadastrar.cshtml"
               Write(ViewData["nome"]);

#line default
#line hidden
            EndContext();
            BeginContext(234, 29, true);
            WriteLiteral("</p>\r\n<p>Data de Nascimento: ");
            EndContext();
            BeginContext(264, 13, false);
#line 15 "D:\Documentos\FIAP\Analise e Desenvolvimento de Sistemas\2F\ENTERPRISE APPLICATION DEVELOPMENT\SOLUTIONS\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Usuario\cadastrar.cshtml"
                  Write(ViewBag.dataN);

#line default
#line hidden
            EndContext();
            BeginContext(277, 17, true);
            WriteLiteral("</p>\r\n<p>E-mail: ");
            EndContext();
            BeginContext(295, 13, false);
#line 16 "D:\Documentos\FIAP\Analise e Desenvolvimento de Sistemas\2F\ENTERPRISE APPLICATION DEVELOPMENT\SOLUTIONS\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Usuario\cadastrar.cshtml"
      Write(ViewBag.Email);

#line default
#line hidden
            EndContext();
            BeginContext(308, 11, true);
            WriteLiteral("</p>\r\n\r\n<p>");
            EndContext();
            BeginContext(320, 15, false);
#line 18 "D:\Documentos\FIAP\Analise e Desenvolvimento de Sistemas\2F\ENTERPRISE APPLICATION DEVELOPMENT\SOLUTIONS\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Usuario\cadastrar.cshtml"
Write(TempData["msg"]);

#line default
#line hidden
            EndContext();
            BeginContext(335, 67, true);
            WriteLiteral("</p>\r\n<hr />\r\n\r\n<a href=\"/Usuario/listar\">Lista de Usuários</a>\r\n\r\n");
            EndContext();
            BeginContext(402, 894, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87ba4ff3d7d546f39f7bb18bbd2eb378", async() => {
                BeginContext(450, 839, true);
                WriteLiteral(@"
    <div class=""card"">
        <div class=""card-body"">
            <div class=""form-group"">
                <label for=""id-nome"">Nome</label>
                <input type=""text"" name=""nome"" id=""id-nome"" class=""form-control"" />
            </div>
            <div class=""form-group"">
                <label for=""id-data"">Data de Nascimento</label>
                <input type=""text"" name=""dataNascimento"" id=""id-data"" class=""form-control"" />
            </div>
            <div class=""form-group"">
                <label for=""id-email"">E-mail</label>
                <input type=""text"" name=""email"" id=""id-email"" class=""form-control"" />
            </div>
            <div class=""form-group"">
                <input type=""submit"" class=""btn btn-primary"" value=""Cadastrar"" />
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1296, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fiap.Web.AspNet.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
