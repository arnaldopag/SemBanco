#pragma checksum "C:\Users\103025\Documents\pastaArnaldo\projetosenac\semBanco\Views\Home\Acesso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "254ad64d3b3fd8252c6484f684e65caaad98e1f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Acesso), @"mvc.1.0.view", @"/Views/Home/Acesso.cshtml")]
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
#line 1 "C:\Users\103025\Documents\pastaArnaldo\projetosenac\semBanco\Views\_ViewImports.cshtml"
using sembanco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\103025\Documents\pastaArnaldo\projetosenac\semBanco\Views\_ViewImports.cshtml"
using sembanco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"254ad64d3b3fd8252c6484f684e65caaad98e1f7", @"/Views/Home/Acesso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d5309f2dd5d59217d4278e5ad6399c46f9a683", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Acesso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cliente>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\103025\Documents\pastaArnaldo\projetosenac\semBanco\Views\Home\Acesso.cshtml"
  
    ViewData["Title"] = "Acesso";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "254ad64d3b3fd8252c6484f684e65caaad98e1f73267", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\103025\Documents\pastaArnaldo\projetosenac\semBanco\Views\Home\Acesso.cshtml"
     foreach(Cliente cliente in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <h1>Olá,");
#nullable restore
#line 8 "C:\Users\103025\Documents\pastaArnaldo\projetosenac\semBanco\Views\Home\Acesso.cshtml"
       Write(cliente.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h1>\r\n    <h3>Dados da conta</h3>\r\n    <p>Conta:");
#nullable restore
#line 10 "C:\Users\103025\Documents\pastaArnaldo\projetosenac\semBanco\Views\Home\Acesso.cshtml"
        Write(cliente.NumeroConta);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n    <p>Agência: ");
#nullable restore
#line 11 "C:\Users\103025\Documents\pastaArnaldo\projetosenac\semBanco\Views\Home\Acesso.cshtml"
           Write(cliente.Agencia);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>Saldo:R$");
#nullable restore
#line 12 "C:\Users\103025\Documents\pastaArnaldo\projetosenac\semBanco\Views\Home\Acesso.cshtml"
          Write(cliente.Saldo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 13 "C:\Users\103025\Documents\pastaArnaldo\projetosenac\semBanco\Views\Home\Acesso.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div>\r\n         <button class=\"btn btn-outline-primary\"><a href=\"./Depositar\">Deposito</a></button>\r\n        <button class=\"btn btn-outline-primary\"><a href=\"./Sacar\"> Saque</a></button>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591