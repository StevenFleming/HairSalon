#pragma checksum "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0de5e4e2db68e529408b7e3bb7cbb402922d288"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Edit), @"mvc.1.0.view", @"/Views/Clients/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Edit.cshtml", typeof(AspNetCore.Views_Clients_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0de5e4e2db68e529408b7e3bb7cbb402922d288", @"/Views/Clients/Edit.cshtml")]
    public class Views_Clients_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 36, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this task: ");
            EndContext();
            BeginContext(96, 36, false);
#line 9 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(132, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(172, 39, false);
#line 13 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.HiddenFor(model => model.ClientId));

#line default
#line hidden
            EndContext();
            BeginContext(218, 34, false);
#line 15 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(258, 35, false);
#line 16 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(300, 38, false);
#line 18 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.LabelFor(model => model.Stylists));

#line default
#line hidden
            EndContext();
            BeginContext(344, 31, false);
#line 19 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.DropDownList("StylistsId"));

#line default
#line hidden
            EndContext();
            BeginContext(377, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 22 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(420, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(424, 40, false);
#line 23 "/Users/Guest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(464, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
