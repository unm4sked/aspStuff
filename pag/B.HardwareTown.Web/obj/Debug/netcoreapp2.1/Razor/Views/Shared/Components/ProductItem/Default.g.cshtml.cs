#pragma checksum "C:\Users\lkalicki\Desktop\aspStuff\pag\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3880dcc63cddfcb63d873e15ca7263c29ae161b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductItem_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProductItem/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ProductItem/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ProductItem_Default))]
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
#line 1 "C:\Users\lkalicki\Desktop\aspStuff\pag\B.HardwareTown.Web\Views\_ViewImports.cshtml"
using B.HardwareTown.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3880dcc63cddfcb63d873e15ca7263c29ae161b", @"/Views/Shared/Components/ProductItem/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01dbdb5413b74e77efbca6841d3cbf401a2065e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProductItem_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<B.HardwareTown.ApplicationCore.DTO.ProductDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/cpu.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-bottom:0.5em;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lkalicki\Desktop\aspStuff\pag\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
 foreach (var product in Model)
{

#line default
#line hidden
            BeginContext(105, 164, true);
            WriteLiteral("\t<li class=\"list-group-item ml-0 pl-0\">\r\n\t\t<div class=\"row\" style=\"padding-bottom: 1em; padding-top: 1em;\">\r\n\t\t\t<div class=\"col-lg-3 col-md-4 col-sm-12 pl-0\">\r\n\t\t\t\t");
            EndContext();
            BeginContext(269, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "42f388d0919a49109c968f98ddfccaa9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(329, 70, true);
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-lg-6 col-md-4 col-sm-12 pl-0\">\r\n\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 399, "\"", 459, 1);
#line 11 "C:\Users\lkalicki\Desktop\aspStuff\pag\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
WriteAttributeValue("", 406, Url.Action("Index","Details",new {id = product.Id }), 406, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(460, 15, true);
            WriteLiteral("><p class=\"h5\">");
            EndContext();
            BeginContext(476, 12, false);
#line 11 "C:\Users\lkalicki\Desktop\aspStuff\pag\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
                                                                                         Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(488, 20, true);
            WriteLiteral("</p></a>\r\n\t\t\t\t<ul>\r\n");
            EndContext();
#line 13 "C:\Users\lkalicki\Desktop\aspStuff\pag\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
                     foreach (var detail in product.Details)
					{

#line default
#line hidden
            BeginContext(563, 53, true);
            WriteLiteral("\t\t\t\t\t\t<li style=\"font-weight:200; font-size:medium;\">");
            EndContext();
            BeginContext(617, 6, false);
#line 15 "C:\Users\lkalicki\Desktop\aspStuff\pag\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
                                                                  Write(detail);

#line default
#line hidden
            EndContext();
            BeginContext(623, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 16 "C:\Users\lkalicki\Desktop\aspStuff\pag\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
					}

#line default
#line hidden
            BeginContext(638, 68, true);
            WriteLiteral("\t\t\t\t</ul>\r\n\t\t\t\t<p style=\"font-weight:600; font-size:medium;\">Bought ");
            EndContext();
            BeginContext(707, 14, false);
#line 18 "C:\Users\lkalicki\Desktop\aspStuff\pag\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
                                                                Write(product.Bought);

#line default
#line hidden
            EndContext();
            BeginContext(721, 289, true);
            WriteLiteral(@" times</p>
			</div>
			<div class=""col-lg-3 col-md-4 col-sm-12"" style=""text-align:right; display:inline;"">
				<div>
					<h3 align=""right"" style=""font-weight:700; display:inline-block; color:greenyellow;"">$</h3>
					<h3 align=""right"" style=""font-weight:700; display:inline-block;"">");
            EndContext();
            BeginContext(1011, 13, false);
#line 23 "C:\Users\lkalicki\Desktop\aspStuff\pag\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
                                                                                Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1024, 90, true);
            WriteLiteral("</h3>\r\n\t\t\t\t\t<h3 align=\"right\" style=\"font-weight:700; color:grey; display:inline-block;\">.");
            EndContext();
            BeginContext(1115, 50, false);
#line 24 "C:\Users\lkalicki\Desktop\aspStuff\pag\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
                                                                                             Write(String.Format("{0:00}", (product.Price % 1 * 100)));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 190, true);
            WriteLiteral("</h3>\r\n\t\t\t\t\t<button class=\"btn btn-danger btn-lg\">Add to Cart</button>\r\n\t\t\t\t\t<p style=\"color:red; margin-top:1em;  font-size:medium;\">Available</p>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</li>\r\n");
            EndContext();
#line 31 "C:\Users\lkalicki\Desktop\aspStuff\pag\B.HardwareTown.Web\Views\Shared\Components\ProductItem\Default.cshtml"
}

#line default
#line hidden
            BeginContext(1358, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<B.HardwareTown.ApplicationCore.DTO.ProductDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
