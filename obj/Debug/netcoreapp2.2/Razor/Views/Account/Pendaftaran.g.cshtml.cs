#pragma checksum "d:\Program S1\Semester 4\RPL Praktikum\Web_KMK\Views\Account\Pendaftaran.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01afa358e004d9e3a9ef42cc9b9b79afc670d04c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Pendaftaran), @"mvc.1.0.view", @"/Views/Account/Pendaftaran.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Pendaftaran.cshtml", typeof(AspNetCore.Views_Account_Pendaftaran))]
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
#line 1 "d:\Program S1\Semester 4\RPL Praktikum\Web_KMK\Views\_ViewImports.cshtml"
using Web_KMK;

#line default
#line hidden
#line 2 "d:\Program S1\Semester 4\RPL Praktikum\Web_KMK\Views\_ViewImports.cshtml"
using Web_KMK.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01afa358e004d9e3a9ef42cc9b9b79afc670d04c", @"/Views/Account/Pendaftaran.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312746bc4f76c258307db03d8885a78bab8a90d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Pendaftaran : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("  ");
            EndContext();
#line 1 "d:\Program S1\Semester 4\RPL Praktikum\Web_KMK\Views\Account\Pendaftaran.cshtml"
    
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 31, true);
            WriteLiteral("  \r\n<div class=\"container\">\r\n  ");
            EndContext();
            BeginContext(65, 3288, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01afa358e004d9e3a9ef42cc9b9b79afc670d04c3640", async() => {
                BeginContext(71, 3275, true);
                WriteLiteral(@"
    <div class=""row"">
        <h4>Data Diri</h4>
          <div class=""input-group input-group-icon"">
            <input type=""text"" placeholder=""Nama Lengkap""/>
            <!--<div class=""input-icon""><i class=""fa fa-user""></i></div>-->
          </div>
      <div class=""input-group input-group-icon"">
            <input type=""text"" placeholder=""Nim""/>
            <!--<div class=""input-icon""><i class=""fa fa-envelope""></i></div>-->
      </div>
      <div class=""input-group input-group-icon"">
            <input type=""text"" placeholder=""Prodi""/>
            <!--<div class=""input-icon""><i class=""fa fa-key""></i></div>-->
      </div>
    </div>
    <div class=""row"">
      <div class=""col-half"">
          <h4>Date of Birth</h4>
          <div class=""input-group"">
              <div class=""col-third"">
                <input type=""text"" placeholder=""DD""/>
              </div>
              <div class=""col-third"">
                <input type=""text"" placeholder=""MM""/>
              </div>
  ");
                WriteLiteral(@"            <div class=""col-third"">
                <input type=""text"" placeholder=""YYYY""/>
              </div>
          </div>
        </div>
      <div class=""col-half"">
        <h4>Gender</h4>
        <div class=""input-group"">
          <input type=""radio"" name=""gender"" value=""male"" id=""gender-male""/>
          <label for=""gender-male"">Perempuan</label>
          <input type=""radio"" name=""gender"" value=""female"" id=""gender-female""/>
          <label for=""gender-female"">Laki-Laki</label>
        </div>
      </div>
    </div>
    <div class=""row"">
      <!--<h4></h4>-->
      <!----<div class=""input-group"">
        <input type=""radio"" name=""payment-method"" value=""card"" id=""payment-method-card"" checked=""true""/>
        <label for=""payment-method-card""><span><i class=""fa fa-cc-visa""></i>Credit Card</span></label>
        <input type=""radio"" name=""payment-method"" value=""paypal"" id=""payment-method-paypal""/>
        <label for=""payment-method-paypal""> <span><i class=""fa fa-cc-paypal""></i>Pa");
                WriteLiteral(@"ypal</span></label>
      </div>-->
      <button type=""submit"">Kirim Data</button>
   <button type=""reset"">Reset Form</button>
      
      <!--<div class=""input-group input-group-icon"">
        <input type=""text"" placeholder=""Card Number""/>
        <div class=""input-icon""><i class=""fa fa-credit-card""></i></div>
      </div>
      <div class=""col-half"">
        <div class=""input-group input-group-icon"">
          <input type=""text"" placeholder=""Card CVC""/>
          <div class=""input-icon""><i class=""fa fa-user""></i></div>
        </div>
      </div>
      <div class=""col-half"">
        <div class=""input-group"">
          <select>
            <option>01 Jan</option>
            <option>02 Jan</option>
          </select>
          <select>
            <option>2015</option>
            <option>2016</option>
          </select>
        </div>
      </div>
    </div>
    <div class=""row"">
      <h4>Terms and Conditions</h4>
      <div class=""input-group"">
        <input type=""check");
                WriteLiteral("box\" id=\"terms\"/>\r\n        <label for=\"terms\">I accept the terms and conditions for signing up to this service, and hereby confirm I have read the privacy policy.</label>\r\n      </div>-->\r\n    </div>\r\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3353, 167, true);
            WriteLiteral("\r\n</div>\r\n <!-- <script src=\'http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js\'></script>\r\n\r\n  \r\n\r\n    <script  src=\"js/index.js\"></script>-->\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
