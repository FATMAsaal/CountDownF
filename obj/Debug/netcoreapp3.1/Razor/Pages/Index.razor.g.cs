#pragma checksum "/Users/fatmasaal/Projects/CountDownF/CountDownF/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6b5d27f824d40be191ecd6068631a36ec4ea9d2"
// <auto-generated/>
#pragma warning disable 1591
namespace CountDownF.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/fatmasaal/Projects/CountDownF/CountDownF/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/fatmasaal/Projects/CountDownF/CountDownF/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/fatmasaal/Projects/CountDownF/CountDownF/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/fatmasaal/Projects/CountDownF/CountDownF/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/fatmasaal/Projects/CountDownF/CountDownF/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/fatmasaal/Projects/CountDownF/CountDownF/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/fatmasaal/Projects/CountDownF/CountDownF/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/fatmasaal/Projects/CountDownF/CountDownF/_Imports.razor"
using CountDownF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/fatmasaal/Projects/CountDownF/CountDownF/_Imports.razor"
using CountDownF.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/fatmasaal/Projects/CountDownF/CountDownF/Pages/Index.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CountDown</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "countDown: ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "/Users/fatmasaal/Projects/CountDownF/CountDownF/Pages/Index.razor"
               actuel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "/Users/fatmasaal/Projects/CountDownF/CountDownF/Pages/Index.razor"
                                          count1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "/Users/fatmasaal/Projects/CountDownF/CountDownF/Pages/Index.razor"
       
    private int actuel = 2000;

    void count1()

    {
        Timer tim = new Timer();
        tim.Interval = 1000;
        tim.Elapsed += (s, e) => actuel -= 10;
        actuel -= 10;
        tim.Start();
        if (actuel == 0)
        {
            tim.Stop();
        }

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
