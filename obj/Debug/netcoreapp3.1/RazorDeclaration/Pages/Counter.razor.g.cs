#pragma checksum "/Users/fatmasaal/Projects/CountDownF/CountDownF/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2eac91c9f91d43fe54281e3ec3fd3b8aad7311c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "/Users/fatmasaal/Projects/CountDownF/CountDownF/Pages/Counter.razor"
using CountDownF.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "/Users/fatmasaal/Projects/CountDownF/CountDownF/Pages/Counter.razor"
       
    private int currentCount = 0;
    private int Value = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
    private void RecuperateValue()
    {
        Value = CountDown.get();
    }
    



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
