#pragma checksum "D:\Code\OdeToFood-DotNetCore\WebApplication1\Pages\Shops\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a85adf90308f78694be47fb8d6a79f4910dfe7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Shops.Pages_Shops_Detail), @"mvc.1.0.razor-page", @"/Pages/Shops/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Shops/Detail.cshtml", typeof(WebApplication1.Pages.Shops.Pages_Shops_Detail), @"{shopId:int}")]
namespace WebApplication1.Pages.Shops
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Code\OdeToFood-DotNetCore\WebApplication1\Pages\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{shopId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a85adf90308f78694be47fb8d6a79f4910dfe7c", @"/Pages/Shops/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66e6c0b2d0593b97c0d67f6f506054866fe040", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shops_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "D:\Code\OdeToFood-DotNetCore\WebApplication1\Pages\Shops\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(116, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(123, 15, false);
#line 9 "D:\Code\OdeToFood-DotNetCore\WebApplication1\Pages\Shops\Detail.cshtml"
Write(Model.shop.Name);

#line default
#line hidden
            EndContext();
            BeginContext(138, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 11 "D:\Code\OdeToFood-DotNetCore\WebApplication1\Pages\Shops\Detail.cshtml"
 if  (Model.Message != null)
{

#line default
#line hidden
            BeginContext(180, 34, true);
            WriteLiteral("    <div class=\"alert alert-info\">");
            EndContext();
            BeginContext(215, 13, false);
#line 13 "D:\Code\OdeToFood-DotNetCore\WebApplication1\Pages\Shops\Detail.cshtml"
                             Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(228, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 14 "D:\Code\OdeToFood-DotNetCore\WebApplication1\Pages\Shops\Detail.cshtml"
}

#line default
#line hidden
            BeginContext(239, 11, true);
            WriteLiteral("\r\n<div>ID: ");
            EndContext();
            BeginContext(251, 13, false);
#line 16 "D:\Code\OdeToFood-DotNetCore\WebApplication1\Pages\Shops\Detail.cshtml"
    Write(Model.shop.Id);

#line default
#line hidden
            EndContext();
            BeginContext(264, 25, true);
            WriteLiteral("</div>\r\n\r\n<div>Location: ");
            EndContext();
            BeginContext(290, 19, false);
#line 18 "D:\Code\OdeToFood-DotNetCore\WebApplication1\Pages\Shops\Detail.cshtml"
          Write(Model.shop.Location);

#line default
#line hidden
            EndContext();
            BeginContext(309, 26, true);
            WriteLiteral("</div>\r\n\r\n<div>Specialty: ");
            EndContext();
            BeginContext(336, 20, false);
#line 20 "D:\Code\OdeToFood-DotNetCore\WebApplication1\Pages\Shops\Detail.cshtml"
           Write(Model.shop.Specialty);

#line default
#line hidden
            EndContext();
            BeginContext(356, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(366, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "877df1fd7898448b898476ba73b5edd4", async() => {
                BeginContext(411, 9, true);
                WriteLiteral("All Shops");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(424, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Pages.Shops.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.Shops.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.Shops.DetailModel>)PageContext?.ViewData;
        public WebApplication1.Pages.Shops.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
