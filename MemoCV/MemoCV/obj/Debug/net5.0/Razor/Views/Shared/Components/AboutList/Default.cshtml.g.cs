#pragma checksum "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\AboutList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "db40bc6ffdb47aeaab749e8156c04ff0dfc45f68378de17c20f8a601c3269588"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutList/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\_ViewImports.cshtml"
using MemoCV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\_ViewImports.cshtml"
using MemoCV.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\AboutList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"db40bc6ffdb47aeaab749e8156c04ff0dfc45f68378de17c20f8a601c3269588", @"/Views/Shared/Components/AboutList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"53845d265e939d4425388a37539c3bdf049b196661889a7051128b1f216a7644", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AboutList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section id=\"about\" class=\"section mt-3\">\r\n    <div class=\"container mt-5\">\r\n");
#nullable restore
#line 5 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\AboutList\Default.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row text-center text-md-left\">\r\n            <div class=\"col-md-3\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 282, "\"", 302, 1);
#nullable restore
#line 9 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\AboutList\Default.cshtml"
WriteAttributeValue("", 288, item.ImageURL, 288, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 303, "\"", 309, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail mb-4\">\r\n            </div>\r\n            <div class=\"pl-md-4 col-md-9\">\r\n                <h6 class=\"title\">");
#nullable restore
#line 12 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\AboutList\Default.cshtml"
                             Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p>");
#nullable restore
#line 13 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\AboutList\Default.cshtml"
              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>                \r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 16 "C:\Users\Mhmtn\source\repos\MemoCV\MemoCV\Views\Shared\Components\AboutList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591