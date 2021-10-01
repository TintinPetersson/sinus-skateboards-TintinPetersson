#pragma checksum "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79542772ee52fd56cfcd6c07b407c3ccc51e31af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SinusSkateboards.UI.Pages.Admin.Pages_Admin_OrderInfo), @"mvc.1.0.razor-page", @"/Pages/Admin/OrderInfo.cshtml")]
namespace SinusSkateboards.UI.Pages.Admin
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
#line 1 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\_ViewImports.cshtml"
using SinusSkateboards.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79542772ee52fd56cfcd6c07b407c3ccc51e31af", @"/Pages/Admin/OrderInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a51820666e4da115a42e7ad1bb8fd689a93447d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_OrderInfo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("orderNo text-light mt-2 mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/CheckOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
 if (Model.Order != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""small-container mt-5 "">
    <div class=""row justify-content-center align-content-center d-flex text-center text-light"">
        <h1 class=""text-light"" style=""background:black; font-size:52px;"">Order Info</h1>
    </div>
    <div class=""row mt-5 justify-content-center align-content-center d-flex text-center text-light"">
        <div class=""col-md-3 mb-4"">
            <div class=""cardSpecItem"">
                <div class=""d-flex justify-content-center"">
                    <div class=""d-flex flex-row align-items-center"">
                        <h4 class=""text-light""><span class=""card-link"">Order number: </span>");
#nullable restore
#line 16 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
                                                                                       Write(Model.Order.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </div>\r\n                </div>\r\n                <h5 class=\"text-light mt-1\"><span class=\"card-link\">Quantity: </span>");
#nullable restore
#line 19 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
                                                                                Write(Model.Order.Products.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" item(s)</h5>\r\n                <h5 class=\"text-light mt-1\"><span class=\"card-link\">Email: </span>");
#nullable restore
#line 20 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
                                                                             Write(Model.Order.Customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"text-light mt-1\"><span class=\"card-link\">Name: </span>");
#nullable restore
#line 21 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
                                                                            Write(Model.Order.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"text-light mt-1\"><span class=\"card-link\">Zip Code: </span>");
#nullable restore
#line 22 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
                                                                                Write(Model.Order.Customer.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"text-light mt-1\"><span class=\"card-link\">City: </span>");
#nullable restore
#line 23 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
                                                                            Write(Model.Order.Customer.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"text-light mt-1\"><span class=\"card-link\">Delivery address: </span>");
#nullable restore
#line 24 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
                                                                                        Write(Model.Order.Customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"text-light mt-1\"><span class=\"card-link\">Order date: </span>");
#nullable restore
#line 25 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
                                                                                  Write(Model.Order.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79542772ee52fd56cfcd6c07b407c3ccc51e31af8555", async() => {
                WriteLiteral("Return");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""row justify-content-center align-content-center text-light"">
        <h2>Ordered products...</h2>
    </div>
    <div class=""row justify-content-center align-content-center text-center d-flex"">
");
#nullable restore
#line 34 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
         foreach (var product in Model.Order.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-3 mb-4"">
                <div class=""card h-100 text-light p-3 mb-2"">
                    <div class=""d-flex justify-content-center"">
                        <div class=""d-flex flex-row align-items-center"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "79542772ee52fd56cfcd6c07b407c3ccc51e31af10625", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2383, "~/images/", 2383, 9, true);
#nullable restore
#line 40 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
AddHtmlAttributeValue("", 2392, product.Image, 2392, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <h5 class=\"card-link\">");
#nullable restore
#line 43 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
                                     Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <span class=\"mt-1 card-link3\">");
#nullable restore
#line 44 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
                                             Write(product.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"card-link2 mt-1\">");
#nullable restore
#line 45 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
                                             Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kr</span>\r\n                    <span class=\"card-link3 mt-1\">");
#nullable restore
#line 46 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
                                             Write(product.ProductCategory.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"text-light mt-1\">Description: </span>\r\n                    <span class=\"text-light mt-1\">");
#nullable restore
#line 48 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
                                             Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 51 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
#nullable restore
#line 54 "C:\Users\tpsso\Source\Repos\sinus-skateboards-TintinPetersson\SinusSkateboards.UI\Pages\Admin\OrderInfo.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SinusSkateboards.UI.Pages.Admin.OrderInfoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SinusSkateboards.UI.Pages.Admin.OrderInfoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SinusSkateboards.UI.Pages.Admin.OrderInfoModel>)PageContext?.ViewData;
        public SinusSkateboards.UI.Pages.Admin.OrderInfoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
