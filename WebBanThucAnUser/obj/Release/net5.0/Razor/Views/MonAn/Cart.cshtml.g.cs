#pragma checksum "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bac3b8b1a35792ee9fb6ab921e5d14438435eb92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MonAn_Cart), @"mvc.1.0.view", @"/Views/MonAn/Cart.cshtml")]
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
#line 1 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\_ViewImports.cshtml"
using WebBanThucAnUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\_ViewImports.cshtml"
using WebBanThucAnUser.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac3b8b1a35792ee9fb6ab921e5d14438435eb92", @"/Views/MonAn/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac90b0710492376b467531d5edd3c3ccede5dfc", @"/Views/_ViewImports.cshtml")]
    public class Views_MonAn_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("min", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "removecart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MonAn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success position-absolute top-100 start-100 translate-middle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
   
    ViewData["Title"] = "Giỏ hàng";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"background-color: black;opacity:0.8\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bac3b8b1a35792ee9fb6ab921e5d14438435eb927219", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<br>\r\n<h2 class=\"text-center\" >GIỎ HÀNG</h2>\r\n\r\n");
#nullable restore
#line 11 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
 if (Model.Count > 0)
{
    decimal total = 0;
    int stt = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <tr>\r\n            <th>STT</th>\r\n            <th>Sản phẩm</th>\r\n            <th>Giá</th>\r\n            <th>Số lượng</th>\r\n\r\n            <th>Thành tiền</th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 26 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
         foreach (var cartitem in Model)
        {
            var thanhtien = cartitem.quantity * cartitem.product.Gia;
            total += thanhtien;
            var scrImg = "nophoto.png";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>");
#nullable restore
#line 33 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
                Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
               Write(cartitem.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
                Write(cartitem.product.Gia.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đồng</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bac3b8b1a35792ee9fb6ab921e5d14438435eb9210213", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 36 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => cartitem.quantity);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
AddHtmlAttributeValue("", 937, $"quantity-{cartitem.product.Id}", 937, 36, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "max", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
AddHtmlAttributeValue("", 988, cartitem.product.Quantity, 988, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
                                                                                                                                      WriteLiteral(cartitem.quantity);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" Còn x ");
#nullable restore
#line 36 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
                                                                                                                                                                                        Write(cartitem.product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 38 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
                Write(thanhtien.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đồng</td>\r\n                <td>\r\n                    <button class=\"btn btn-success updatecartitem\" type=\"submit\"\r\n                            data-productid=\"");
#nullable restore
#line 41 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
                                       Write(cartitem.product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        Cập nhật\r\n                    </button>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac3b8b1a35792ee9fb6ab921e5d14438435eb9214955", async() => {
                WriteLiteral("Xóa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
                                                       WriteLiteral(cartitem.product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac3b8b1a35792ee9fb6ab921e5d14438435eb9217272", async() => {
                WriteLiteral("Đi tới món ăn");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
                                                                     WriteLiteral(cartitem.product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                   \r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 51 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td colspan=\"4\" class=\"text-right text-danger\">Tổng tiền</td>\r\n            <td class=\"text-danger\">");
#nullable restore
#line 54 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
                                Write(total.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đồng</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac3b8b1a35792ee9fb6ab921e5d14438435eb9220507", async() => {
                WriteLiteral("Gửi đơn hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n\r\n    </table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
        <script>
          $(document).ready(function () {
              $("".updatecartitem"").click(function (event) {
                  event.preventDefault();
                  var productid = $(this).attr(""data-productid"");
                  var quantity = $(""#quantity-"" + productid).val();
                  $.ajax({
                      type: ""POST"",
                      url:""");
#nullable restore
#line 73 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
                      Write(Url.RouteUrl("updatecart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                      data: {
                          productid: productid,
                          quantity:quantity
                      },
                      success: function (result) {
                          window.location.href = """);
#nullable restore
#line 79 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
                                             Write(Url.RouteUrl("cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                      }\r\n                  });\r\n              });\r\n          });\r\n        </script>\r\n    ");
            }
            );
#nullable restore
#line 85 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
     

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-danger text-center\">Giỏ hàng trống</p>\r\n");
#nullable restore
#line 91 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Cart.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
