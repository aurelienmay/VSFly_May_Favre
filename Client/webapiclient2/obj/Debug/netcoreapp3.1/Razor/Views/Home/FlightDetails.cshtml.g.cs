#pragma checksum "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c80b6585ea773e09ee751df7139f93551b6c7d4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FlightDetails), @"mvc.1.0.view", @"/Views/Home/FlightDetails.cshtml")]
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
#line 1 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\_ViewImports.cshtml"
using webapiclient2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\_ViewImports.cshtml"
using webapiclient2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c80b6585ea773e09ee751df7139f93551b6c7d4a", @"/Views/Home/FlightDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f2e10eb63069e021a7f85e254c0cdcc6aa7566", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FlightDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<webapiclient2.Models.Flight>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
  
    ViewData["Title"] = "FlightDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>Flight details n°");
#nullable restore
#line 7 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
                    Write(Html.DisplayFor(model => model.FlightNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.DisplayFor(model => model.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.DisplayFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.AvailableSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.DisplayFor(model => model.AvailableSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Seats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.DisplayFor(model => model.Seats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.BasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <b>");
#nullable restore
#line 52 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
          Write(Html.DisplayFor(model => model.BasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(".- CHF</b>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <div>\r\n");
#nullable restore
#line 58 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
         using (Html.BeginForm("BookThisFlight", "Home", new { flightNo = Model.FlightNo, basePrice = Model.BasePrice, flightClass = "first" }, FormMethod.Post))
        {
            // Flight type
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.DropDownList("ObjList", (IEnumerable<SelectListItem>)ViewBag.Locations, new { style = "width: 305px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n");
#nullable restore
#line 63 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"

            // Extras
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.CheckBox("luggage"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Luggage - CHF 40.-");
            WriteLiteral("\r\n            <br />\r\n");
#nullable restore
#line 68 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.CheckBox("meal"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Meal - CHF 20.-");
            WriteLiteral("\r\n            <br />\r\n");
#nullable restore
#line 71 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.CheckBox("tv"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TV - CHF 10.-");
            WriteLiteral("\r\n            <br />\r\n            <br />\r\n");
#nullable restore
#line 75 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
            // Error message for username
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
             if (@ViewBag.ErrorMessage == "invalidUsername")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <b style=\"color:red\">");
#nullable restore
#line 78 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
                                Write(Html.Label("*Enter a valid username*"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 79 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <b>");
#nullable restore
#line 82 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
              Write(Html.Label("Enter your username"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 83 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n");
#nullable restore
#line 85 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
       Write(Html.TextBox("username", "", new { style = "width: 305px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p></p>\r\n            <input type=\"button\" class=\"btn btn-info btn-sm active\" style=\"width:150px\" value=\"CANCEL\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2949, "\"", 3024, 2);
#nullable restore
#line 87 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
WriteAttributeValue("", 2959, "window.location.href='" + @Url.Action("Index", "Home") + "'", 2959, 64, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3023, ";", 3023, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input type=\"submit\" class=\"btn btn-info btn-sm active\" style=\"background-color:green;width:150px;\" value=\"BOOK\" id=\"btnSubmit\" name=\"Submit\" />\r\n");
#nullable restore
#line 89 "D:\1_HES\Comp&Pattern\VSFly_May_Favre\Client\webapiclient2\Views\Home\FlightDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<webapiclient2.Models.Flight> Html { get; private set; }
    }
}
#pragma warning restore 1591
