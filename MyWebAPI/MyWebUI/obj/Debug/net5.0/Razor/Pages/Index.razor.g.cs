#pragma checksum "D:\Projects\MyWebAPI\MyWebUI\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1f8aa373e634a838306dc8f87b972220058f6a1"
// <auto-generated/>
#pragma warning disable 1591
namespace MyWebUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using MyWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using MyWebUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using MyWebModels.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using MyWebModels.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using MyWebModels.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using MyWebUI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projects\MyWebAPI\MyWebUI\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"text-center alert alert-primary\" style=\"padding:40px 10px;\"><h3>\r\n         Welcome to you in Eastaria\r\n    </h3>\r\n\r\n    <p>\r\n        new concept in software development.\r\n    </p></div>\r\n\r\n");
            __builder.OpenComponent<MyWebUI.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "learn more about ");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
