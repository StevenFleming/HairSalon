#pragma checksum "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52776d5045c0438a8ed972e6e7ccabf31ec2fbf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Create), @"mvc.1.0.view", @"/Views/Stylists/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Create.cshtml", typeof(AspNetCore.Views_Stylists_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52776d5045c0438a8ed972e6e7ccabf31ec2fbf9", @"/Views/Stylists/Create.cshtml")]
    public class Views_Stylists_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(61, 28, true);
            WriteLiteral("\n<h2>Add a new Stylist</h2>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(122, 34, false);
#line 11 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(162, 36, false);
#line 12 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(198, 5, true);
            WriteLiteral("<br>\n");
            EndContext();
            BeginContext(204, 67, true);
            WriteLiteral("    <input class=\"button\" type=\"submit\" value=\"Add new Stylist\" />\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
}

#line default
#line hidden
            BeginContext(273, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(277, 48, false);
#line 16 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.ActionLink("Show all Collections", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(325, 4, true);
            WriteLiteral("</p>");
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
