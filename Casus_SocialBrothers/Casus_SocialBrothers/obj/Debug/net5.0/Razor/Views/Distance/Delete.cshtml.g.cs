#pragma checksum "C:\Users\Gebruiker\source\repos\Casus_SocialBrothers\Casus_SocialBrothers\Views\Distance\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad0e1fce842d4bd7ae739d77bcaf5822a7720155"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Distance_Delete), @"mvc.1.0.view", @"/Views/Distance/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad0e1fce842d4bd7ae739d77bcaf5822a7720155", @"/Views/Distance/Delete.cshtml")]
    public class Views_Distance_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Casus_SocialBrothers.Address>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Gebruiker\source\repos\Casus_SocialBrothers\Casus_SocialBrothers\Views\Distance\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Address</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Gebruiker\source\repos\Casus_SocialBrothers\Casus_SocialBrothers\Views\Distance\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Gebruiker\source\repos\Casus_SocialBrothers\Casus_SocialBrothers\Views\Distance\Delete.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Gebruiker\source\repos\Casus_SocialBrothers\Casus_SocialBrothers\Views\Distance\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Gebruiker\source\repos\Casus_SocialBrothers\Casus_SocialBrothers\Views\Distance\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Gebruiker\source\repos\Casus_SocialBrothers\Casus_SocialBrothers\Views\Distance\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StreetName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Gebruiker\source\repos\Casus_SocialBrothers\Casus_SocialBrothers\Views\Distance\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StreetName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Gebruiker\source\repos\Casus_SocialBrothers\Casus_SocialBrothers\Views\Distance\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HouseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Gebruiker\source\repos\Casus_SocialBrothers\Casus_SocialBrothers\Views\Distance\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HouseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Gebruiker\source\repos\Casus_SocialBrothers\Casus_SocialBrothers\Views\Distance\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Gebruiker\source\repos\Casus_SocialBrothers\Casus_SocialBrothers\Views\Distance\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"hidden\" asp-for=\"ID\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Casus_SocialBrothers.Address> Html { get; private set; }
    }
}
#pragma warning restore 1591
