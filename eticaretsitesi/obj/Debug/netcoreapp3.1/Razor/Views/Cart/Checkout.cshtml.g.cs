#pragma checksum "C:\Users\bugra\Documents\Uygulamalarım\CoreMvc3.1_E-ticaret-sitesi\eticaretsitesi\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c40257a9afd2dbd4f554b0575cf83aaa185c7fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Checkout), @"mvc.1.0.view", @"/Views/Cart/Checkout.cshtml")]
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
#line 1 "C:\Users\bugra\Documents\Uygulamalarım\CoreMvc3.1_E-ticaret-sitesi\eticaretsitesi\Views\_ViewImports.cshtml"
using eticaretsitesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bugra\Documents\Uygulamalarım\CoreMvc3.1_E-ticaret-sitesi\eticaretsitesi\Views\_ViewImports.cshtml"
using eticaretsitesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c40257a9afd2dbd4f554b0575cf83aaa185c7fb", @"/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"067ff00833234c59e116e7c2d7c54c2a50881a31", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/cart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formpost"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout_done", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alısverisislem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\bugra\Documents\Uygulamalarım\CoreMvc3.1_E-ticaret-sitesi\eticaretsitesi\Views\Cart\Checkout.cshtml"
  
    ViewData["Title"] = "Alışverişi Tamamla";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c40257a9afd2dbd4f554b0575cf83aaa185c7fb7109", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9c40257a9afd2dbd4f554b0575cf83aaa185c7fb7371", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<h1>Alışverişi Tamamla</h1>\r\n\r\n<div class=\"cartbody\">\r\n\r\n    <div class=\"satınalım\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c40257a9afd2dbd4f554b0575cf83aaa185c7fb9370", async() => {
                WriteLiteral(@"
            <label for=""fname"">Teslim Alacak Kişi Ad-Soyad:</label><br>
            <input type=""text"" class=""inputsatınalım"" name=""adsoyad"" required maxlength=""32"" minlength=""3""><br>

            <label for=""fname"">Telefon Numarası:</label><br>
            <input type=""text"" class=""inputsatınalım"" required maxlength=""10"" minlength=""10"" oninput=""this.value = this.value.replace(/[^0-9.]/g, '').replace(/(\..*?)\..*/g, '$1');"" name=""tel""><br>

            <label for=""fname"">Fatura Mail Adresi</label><br>
            <input type=""email"" class=""inputsatınalım"" name=""eposta""><br>

            <label for=""fname"">Adres:</label><br>
            <textarea class=""adressbox"" rows=""4"" cols=""50"" name=""adres""></textarea>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""yontem"">
        <b>Ödeme Yöntemi</b>
    </div>

    <div class=""form-check"">
        <input class=""form-check-input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios1"" value=""option1"" checked onclick=""myFunction1()"">
        <label class=""form-check-label"" for=""exampleRadios1"">Kapıda Ödeme</label>
    </div>
    <div class=""form-check"">
        <input class=""form-check-input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios2"" value=""option2"" onclick=""myFunction2()"">
        <label class=""form-check-label"" for=""exampleRadios2"">Kart İle Ödeme</label>
    </div>

    <div id=""myDIV"">

        <aside class=""col-sm-6"">

            <article class=""card"">
                <div class=""card-body p-5"">

                    <ul class=""nav bg-light nav-pills rounded nav-fill mb-3"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" data-toggle=""pill"" href=""#nav-tab-card"">
                         ");
            WriteLiteral(@"       <i class=""fa fa-credit-card""></i> Kredi Kartı
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" data-toggle=""pill"" href=""#nav-tab-paypal"">
                                <i class=""fab fa-paypal""></i>  Paypal
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" data-toggle=""pill"" href=""#nav-tab-bank"">
                                <i class=""fa fa-university""></i>  Banka Transferi
                            </a>
                        </li>
                    </ul>

                    <div class=""tab-content"">
                        <div class=""tab-pane fade show active"" id=""nav-tab-card"">
                            <p class=""alert alert-success"">Bilgileri boş veya hatalı doldurmamaya dikkat ediniz!</p>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c40257a9afd2dbd4f554b0575cf83aaa185c7fb14191", async() => {
                WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    <label for=\"username\">Kart Üstündeki İsim</label>\r\n                                    <input type=\"text\" class=\"form-control\" name=\"username\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3311, "\"", 3325, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 3326, "\"", 3337, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div> <!-- form-group.// -->

                                <div class=""form-group"">
                                    <label for=""cardNumber"">Kart Numarası</label>
                                    <div class=""input-group"">
                                        <input type=""text"" class=""form-control"" name=""cardNumber""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3707, "\"", 3721, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        <div class=""input-group-append"">
                                            <span class=""input-group-text text-muted"">
                                                <i class=""fab fa-cc-visa""></i>   <i class=""fab fa-cc-amex""></i>
                                                <i class=""fab fa-cc-mastercard""></i>
                                            </span>
                                        </div>
                                    </div>
                                </div> <!-- form-group.// -->

                                <div class=""row"">
                                    <div class=""col-sm-8"">
                                        <div class=""form-group"">
                                            <label><span class=""hidden-xs"">Son Kullanma Tarihi</span> </label>
                                            <div class=""input-group"">
                                                <input type=""number"" class=""form-control"" ");
                WriteLiteral("placeholder=\"MM\"");
                BeginWriteAttribute("name", " name=\"", 4762, "\"", 4769, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                <input type=\"number\" class=\"form-control\" placeholder=\"YY\"");
                BeginWriteAttribute("name", " name=\"", 4879, "\"", 4886, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-sm-4"">
                                        <div class=""form-group"">
                                            <label data-toggle=""tooltip"" title=""Kartın arka yüzündeki 3 haneli kod"">CVV <i class=""fa fa-question-circle""></i></label>
                                            <input type=""number"" class=""form-control""");
                BeginWriteAttribute("required", " required=\"", 5412, "\"", 5423, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        </div> <!-- form-group.// -->\r\n                                    </div>\r\n                                </div> <!-- row.// -->\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div> <!-- tab-pane.// -->
                        <div class=""tab-pane fade"" id=""nav-tab-paypal"">
                            <p>Paypal çevrimiçi ödeme yapmanın en kolay yolu</p>
                            <p>
                                <button type=""button"" class=""btn btn-primary""> <i class=""fab fa-paypal""></i> Paypal'ımda oturum aç </button>
                            </p>
                            <p>
                                <strong>Not:</strong> Paypal işlemleri bazı ülkeler için kapalı olabilir. İşlem gerçekleştiremiyorsanız
                                bulunduğunuz bölge üzerinde paypal hizmetinin etkin olup olmadığını kontrol etmeniz gerekmektedir.
                            </p>
                        </div>
                        <div class=""tab-pane fade"" id=""nav-tab-bank"">
                            <p>Banka hesap bilgileri</p>
                            <dl class=""param"">
                                <dt>Banka: </dt>
          ");
            WriteLiteral(@"                      <dd> Ziraat Bankası</dd>
                            </dl>
                            <dl class=""param"">
                                <dt>Hesap Numarası: </dt>
                                <dd> 12345678912345</dd>
                            </dl>
                            <dl class=""param"">
                                <dt>IBAN: </dt>
                                <dd> 1234415213</dd>
                            </dl>
                            <p>
                                <strong>Not:</strong> Ödeme işlemini gerçekleştirdikten sonra dekondu bize mail üzerinden ulaştırmanız gerekmektedir.
                                Dekondu mail üzerinden bize 3 iş günü içinde ulaştırmayan kullanıcıların alışverişleri geçersiz sayılmaktadır.
                            </p>
                        </div>
                    </div>

                </div>
            </article>
        </aside>
    </div>

    <div class=""sonislem"">
        <div>
        ");
            WriteLiteral("    <button type=\"submit\" form=\"formpost\" class=\"btn btn-danger\">Alışverişi Tamamla</button>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c40257a9afd2dbd4f554b0575cf83aaa185c7fb21286", async() => {
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-info\">İşlem İptal</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
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



<script>
    var x = document.getElementById(""myDIV"");
    $(function () {
        $('[data-toggle=""tooltip""]').tooltip()
    })
    function myFunction1() {
        x.style.display = ""none"";
    }
    function myFunction2() {
        x.style.display = ""block"";
    }
</script>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591