#pragma checksum "D:\Grand Circus\API\Views\StarWars\Planet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53b7ce4c86d4b4f0cc1f60c62bcdb303939f61d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StarWars_Planet), @"mvc.1.0.view", @"/Views/StarWars/Planet.cshtml")]
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
#line 1 "D:\Grand Circus\API\Views\_ViewImports.cshtml"
using API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Grand Circus\API\Views\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b7ce4c86d4b4f0cc1f60c62bcdb303939f61d5", @"/Views/StarWars/Planet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596ee91360b297ff619c22751a25970a765dc05e", @"/Views/_ViewImports.cshtml")]
    public class Views_StarWars_Planet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Models.ViewModels.PlanetViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 4 "D:\Grand Circus\API\Views\StarWars\Planet.cshtml"
     foreach (var planet in Model.Planets)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <h4>");
#nullable restore
#line 7 "D:\Grand Circus\API\Views\StarWars\Planet.cshtml"
           Write(planet.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 170, "\"", 187, 1);
#nullable restore
#line 8 "D:\Grand Circus\API\Views\StarWars\Planet.cshtml"
WriteAttributeValue("", 176, planet.url, 176, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </li>\r\n");
#nullable restore
#line 10 "D:\Grand Circus\API\Views\StarWars\Planet.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Models.ViewModels.PlanetViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
