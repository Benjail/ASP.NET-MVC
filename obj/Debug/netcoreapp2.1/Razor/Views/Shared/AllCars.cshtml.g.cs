#pragma checksum "C:\Users\Михаил\source\repos\ASP.NET-MVC IT Proger\Views\Shared\AllCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dc4de54754f95a29b966c157035c1a31548e428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllCars), @"mvc.1.0.view", @"/Views/Shared/AllCars.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/AllCars.cshtml", typeof(AspNetCore.Views_Shared_AllCars))]
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
#line 1 "C:\Users\Михаил\source\repos\ASP.NET-MVC IT Proger\Views\_ViewImports.cshtml"
using ASP.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Михаил\source\repos\ASP.NET-MVC IT Proger\Views\_ViewImports.cshtml"
using ASP.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dc4de54754f95a29b966c157035c1a31548e428", @"/Views/Shared/AllCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a016e9c60d5c62ad1edb19c143eb367e7644d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AllCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP.Data.Models.Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 54, true);
            WriteLiteral("<div class=\"col-lg-3\">\r\n    <img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 82, "\"", 98, 1);
#line 3 "C:\Users\Михаил\source\repos\ASP.NET-MVC IT Proger\Views\Shared\AllCars.cshtml"
WriteAttributeValue("", 88, Model.Img, 88, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(99, 38, true);
            WriteLiteral(" alt=\"альтернативный текст\">\r\n    <h2>");
            EndContext();
            BeginContext(138, 10, false);
#line 4 "C:\Users\Михаил\source\repos\ASP.NET-MVC IT Proger\Views\Shared\AllCars.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(148, 15, true);
            WriteLiteral("</h2>\r\n    <h5>");
            EndContext();
            BeginContext(164, 27, false);
#line 5 "C:\Users\Михаил\source\repos\ASP.NET-MVC IT Proger\Views\Shared\AllCars.cshtml"
   Write(Model.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(191, 15, true);
            WriteLiteral("</h5>\r\n    <p> ");
            EndContext();
            BeginContext(207, 25, false);
#line 6 "C:\Users\Михаил\source\repos\ASP.NET-MVC IT Proger\Views\Shared\AllCars.cshtml"
   Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(232, 71, true);
            WriteLiteral("</p>\r\n    <a class=\"btn btn-warning\" href=\"#\">Подробнее</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP.Data.Models.Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
