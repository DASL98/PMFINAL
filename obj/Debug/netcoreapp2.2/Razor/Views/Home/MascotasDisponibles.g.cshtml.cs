#pragma checksum "C:\Users\USUARIO\Downloads\AA\Views\Home\MascotasDisponibles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b86045932a41c7940d505c8c40c79af06e99204f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MascotasDisponibles), @"mvc.1.0.view", @"/Views/Home/MascotasDisponibles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MascotasDisponibles.cshtml", typeof(AspNetCore.Views_Home_MascotasDisponibles))]
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
#line 1 "C:\Users\USUARIO\Downloads\AA\Views\_ViewImports.cshtml"
using AA;

#line default
#line hidden
#line 2 "C:\Users\USUARIO\Downloads\AA\Views\_ViewImports.cshtml"
using AA.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b86045932a41c7940d505c8c40c79af06e99204f", @"/Views/Home/MascotasDisponibles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3cdb609b5e62b7295f18e581075e6e647a62e7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MascotasDisponibles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mascota>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 44, true);
            WriteLiteral("\r\n</br>\r\n<h1>Mascotas para adopción</h1>\r\n\r\n");
            EndContext();
            BeginContext(66, 327, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b86045932a41c7940d505c8c40c79af06e99204f4399", async() => {
                BeginContext(104, 75, true);
                WriteLiteral("\r\n    Filtrar por tipo mascota: \r\n    <select name=\"tipomascota\">\r\n        ");
                EndContext();
                BeginContext(179, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b86045932a41c7940d505c8c40c79af06e99204f4860", async() => {
                    BeginContext(197, 5, true);
                    WriteLiteral("Todos");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(211, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 10 "C:\Users\USUARIO\Downloads\AA\Views\Home\MascotasDisponibles.cshtml"
         foreach(var t in (List<TipoMascota>)ViewBag.Tipos) {

#line default
#line hidden
                BeginContext(276, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(288, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b86045932a41c7940d505c8c40c79af06e99204f6618", async() => {
                    BeginContext(311, 8, false);
#line 11 "C:\Users\USUARIO\Downloads\AA\Views\Home\MascotasDisponibles.cshtml"
                             Write(t.Nombre);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 11 "C:\Users\USUARIO\Downloads\AA\Views\Home\MascotasDisponibles.cshtml"
               WriteLiteral(t.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(328, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 12 "C:\Users\USUARIO\Downloads\AA\Views\Home\MascotasDisponibles.cshtml"
        }

#line default
#line hidden
                BeginContext(341, 45, true);
                WriteLiteral("    </select>\r\n    <button>Filtrar</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(393, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 17 "C:\Users\USUARIO\Downloads\AA\Views\Home\MascotasDisponibles.cshtml"
 if (Model.Count == 0) {

#line default
#line hidden
            BeginContext(423, 46, true);
            WriteLiteral("    <p>Aún no hay mascotas para adoptar.</p>\r\n");
            EndContext();
#line 19 "C:\Users\USUARIO\Downloads\AA\Views\Home\MascotasDisponibles.cshtml"
}

#line default
#line hidden
            BeginContext(472, 29, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
            EndContext();
#line 22 "C:\Users\USUARIO\Downloads\AA\Views\Home\MascotasDisponibles.cshtml"
 foreach (var m in Model)
{

#line default
#line hidden
            BeginContext(531, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(540, 15, false);
#line 24 "C:\Users\USUARIO\Downloads\AA\Views\Home\MascotasDisponibles.cshtml"
   Write(m.NombreMascota);

#line default
#line hidden
            EndContext();
            BeginContext(555, 15, true);
            WriteLiteral("</h2>\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 570, "\"", 583, 1);
#line 25 "C:\Users\USUARIO\Downloads\AA\Views\Home\MascotasDisponibles.cshtml"
WriteAttributeValue("", 576, m.Foto, 576, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(584, 28, true);
            WriteLiteral(" width=\"300\">\r\n    <p>Tipo: ");
            EndContext();
            BeginContext(613, 13, false);
#line 26 "C:\Users\USUARIO\Downloads\AA\Views\Home\MascotasDisponibles.cshtml"
        Write(m.Tipo.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(626, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 27 "C:\Users\USUARIO\Downloads\AA\Views\Home\MascotasDisponibles.cshtml"
}

#line default
#line hidden
            BeginContext(635, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mascota>> Html { get; private set; }
    }
}
#pragma warning restore 1591
