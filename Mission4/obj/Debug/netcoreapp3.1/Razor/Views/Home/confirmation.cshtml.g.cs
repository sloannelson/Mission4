#pragma checksum "/Users/sloan_nelson/Projects/Mission4/Mission4/Views/Home/confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cc0eefccd066ef8b8d6d148d99a0d1c75ae8979"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_confirmation), @"mvc.1.0.view", @"/Views/Home/confirmation.cshtml")]
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
#line 1 "/Users/sloan_nelson/Projects/Mission4/Mission4/Views/_ViewImports.cshtml"
using Mission4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sloan_nelson/Projects/Mission4/Mission4/Views/_ViewImports.cshtml"
using Mission4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc0eefccd066ef8b8d6d148d99a0d1c75ae8979", @"/Views/Home/confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0bfe1b60a95614b8b8a073928c02b3f3450b976", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mission4.Models.MovieForm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/sloan_nelson/Projects/Mission4/Mission4/Views/Home/confirmation.cshtml"
  
    ViewData["Title"] = "Confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Thank you for adding ");
#nullable restore
#line 8 "/Users/sloan_nelson/Projects/Mission4/Mission4/Views/Home/confirmation.cshtml"
                    Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to the collection</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mission4.Models.MovieForm> Html { get; private set; }
    }
}
#pragma warning restore 1591
