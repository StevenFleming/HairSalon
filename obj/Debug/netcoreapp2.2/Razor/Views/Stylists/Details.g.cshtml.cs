#pragma checksum "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c9c51c6abc584380fda090a54a7376a8e201b78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Details), @"mvc.1.0.view", @"/Views/Stylists/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Details.cshtml", typeof(AspNetCore.Views_Stylists_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c9c51c6abc584380fda090a54a7376a8e201b78", @"/Views/Stylists/Details.cshtml")]
    public class Views_Stylists_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("  \n\n");
            EndContext();
#line 3 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(33, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(66, 98, true);
            WriteLiteral("\n<h2>Stylist Details</h2>\n<hr />\n<p>Click on the Stylist Name to See her Current Clientel</p>\n<h3>");
            EndContext();
            BeginContext(165, 54, false);
#line 12 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink($"{ Model.Name }", "Index", "Clients"));

#line default
#line hidden
            EndContext();
            BeginContext(219, 10, true);
            WriteLiteral("</h3>\n\n<p>");
            EndContext();
            BeginContext(230, 61, false);
#line 14 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Back to Stylists Lists", "Index", "Clients"));

#line default
#line hidden
            EndContext();
            BeginContext(291, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(296, 66, false);
#line 15 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Delete Stylist", "Delete", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(362, 5, true);
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
