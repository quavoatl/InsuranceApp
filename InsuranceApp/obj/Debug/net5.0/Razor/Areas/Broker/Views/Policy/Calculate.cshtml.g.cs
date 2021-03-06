#pragma checksum "C:\Users\seantal\source\repos\InsuranceApp\InsuranceApp\InsuranceApp\Areas\Broker\Views\Policy\Calculate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "698a954ce32fd368538d9996dce7110c73c31f35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Broker_Views_Policy_Calculate), @"mvc.1.0.view", @"/Areas/Broker/Views/Policy/Calculate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698a954ce32fd368538d9996dce7110c73c31f35", @"/Areas/Broker/Views/Policy/Calculate.cshtml")]
    public class Areas_Broker_Views_Policy_Calculate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InsuranceApp.Areas.Broker.ViewModels.CalculatePolicyViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\seantal\source\repos\InsuranceApp\InsuranceApp\InsuranceApp\Areas\Broker\Views\Policy\Calculate.cshtml"
  
    Layout = null;
    var cover = @Model.Cover;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Selected Cover</h2>

<table>

    <tr>
        <td>
            BrokerId
        </td>
        <td>
            CoverId
        </td>
        <td>
            Type
        </td>
        <td>
            LimitMultiplier
        </td>
    </tr>

    <tr>
        <td>
            ");
#nullable restore
#line 29 "C:\Users\seantal\source\repos\InsuranceApp\InsuranceApp\InsuranceApp\Areas\Broker\Views\Policy\Calculate.cshtml"
       Write(Model.Cover.BrokerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 32 "C:\Users\seantal\source\repos\InsuranceApp\InsuranceApp\InsuranceApp\Areas\Broker\Views\Policy\Calculate.cshtml"
       Write(Model.Cover.CoverId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 35 "C:\Users\seantal\source\repos\InsuranceApp\InsuranceApp\InsuranceApp\Areas\Broker\Views\Policy\Calculate.cshtml"
       Write(Model.Cover.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 38 "C:\Users\seantal\source\repos\InsuranceApp\InsuranceApp\InsuranceApp\Areas\Broker\Views\Policy\Calculate.cshtml"
       Write(Model.Cover.LimitMultiplier);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </td>
    </tr>
</table>

<br>
<h2>Payable premium for each limit</h2>
<table>

    <tr>
        <td>
            BrokerId
        </td>
        <td>
            LimitId
        </td>
        <td>
            Value
        </td>
        <td>
            CoverType
        </td>
        <td>
            Payable
        </td>
    </tr>

");
#nullable restore
#line 65 "C:\Users\seantal\source\repos\InsuranceApp\InsuranceApp\InsuranceApp\Areas\Broker\Views\Policy\Calculate.cshtml"
      
        foreach (var limit in @Model.Limits)
        {
            var sum = limit.Value * @Model.Cover.LimitMultiplier;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\seantal\source\repos\InsuranceApp\InsuranceApp\InsuranceApp\Areas\Broker\Views\Policy\Calculate.cshtml"
               Write(limit.BrokerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\seantal\source\repos\InsuranceApp\InsuranceApp\InsuranceApp\Areas\Broker\Views\Policy\Calculate.cshtml"
               Write(limit.LimitId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\seantal\source\repos\InsuranceApp\InsuranceApp\InsuranceApp\Areas\Broker\Views\Policy\Calculate.cshtml"
               Write(limit.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "C:\Users\seantal\source\repos\InsuranceApp\InsuranceApp\InsuranceApp\Areas\Broker\Views\Policy\Calculate.cshtml"
               Write(limit.CoverType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                   ");
#nullable restore
#line 83 "C:\Users\seantal\source\repos\InsuranceApp\InsuranceApp\InsuranceApp\Areas\Broker\Views\Policy\Calculate.cshtml"
              Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 86 "C:\Users\seantal\source\repos\InsuranceApp\InsuranceApp\InsuranceApp\Areas\Broker\Views\Policy\Calculate.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InsuranceApp.Areas.Broker.ViewModels.CalculatePolicyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
