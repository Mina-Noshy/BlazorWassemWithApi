#pragma checksum "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b595551aee47646d52e2b70accf9b1d1dfb264c0"
// <auto-generated/>
#pragma warning disable 1591
namespace MyWebUI.Pages.Employee
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee/list")]
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"text-center\"><h4>Employees List</h4></div>");
#nullable restore
#line 7 "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor"
 if (_employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MyWebUI.Shared.Loading>(1);
            __builder.AddAttribute(2, "Title", "Emolyees List");
            __builder.AddAttribute(3, "Message", "please wait...");
            __builder.CloseComponent();
#nullable restore
#line 10 "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<div style=\"margin-bottom:10px;\"><a href=\"/employee/create\" class=\"btn btn-success\">Create new</a></div>");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-responsive");
            __builder.AddMarkupContent(7, @"<thead><tr><th>id</th>
                <th>name</th>
                <th>department</th>
                <th>phone</th>
                <th>job</th>
                <th></th>
                <th>options</th>
                <th></th></tr></thead>
        ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 31 "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor"
             foreach (var item in _employees)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 34 "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor"
                     item.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 35 "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor"
                     item.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 36 "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor"
                     item.department

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 37 "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor"
                     item.phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 38 "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor"
                     item.job

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", 
#nullable restore
#line 40 "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor"
                               $"/employee/details/{item.id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "class", "btn-sm btn-primary");
            __builder.AddContent(29, "view");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", 
#nullable restore
#line 43 "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor"
                               $"/employee/edit/{item.id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "class", "btn-sm btn-success");
            __builder.AddContent(35, "edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", 
#nullable restore
#line 46 "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor"
                               $"/employee/delete/{item.id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "class", "btn-sm btn-danger");
            __builder.AddContent(41, "delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\Projects\MyWebAPI\MyWebUI\Pages\Employee\List.razor"
       

    [Inject]
    public IEmployeeService _service { get; set; }

    private IEnumerable<Employee> _employees;

    protected override async Task OnInitializedAsync()
    {
        _employees = await _service.GetAll();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591