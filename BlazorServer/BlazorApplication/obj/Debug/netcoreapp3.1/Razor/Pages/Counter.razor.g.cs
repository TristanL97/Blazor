#pragma checksum "C:\Dev\BlazorServer\BlazorApplication\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b2dbb722533bf1572a5113f952702208e8434a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dev\BlazorServer\BlazorApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\BlazorServer\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\BlazorServer\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\BlazorServer\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\BlazorServer\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\BlazorServer\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\BlazorServer\BlazorApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\BlazorServer\BlazorApplication\_Imports.razor"
using BlazorApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\BlazorServer\BlazorApplication\_Imports.razor"
using BlazorApplication.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : CounterBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddAttribute(2, "style", "font-family:" + (
#nullable restore
#line 6 "C:\Dev\BlazorServer\BlazorApplication\Pages\Counter.razor"
                       fontFamily

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.AddContent(3, " Current count: ");
            __builder.AddContent(4, 
#nullable restore
#line 6 "C:\Dev\BlazorServer\BlazorApplication\Pages\Counter.razor"
                                                     currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-primary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Dev\BlazorServer\BlazorApplication\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
