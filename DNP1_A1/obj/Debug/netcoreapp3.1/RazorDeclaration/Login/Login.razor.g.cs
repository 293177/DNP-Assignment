#pragma checksum "c:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP_A2\DNP1_A1\Login\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2f5704205bcb03a8c417d16617018f7973fc906"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Login
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP_A2\DNP1_A1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP_A2\DNP1_A1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP_A2\DNP1_A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP_A2\DNP1_A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP_A2\DNP1_A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP_A2\DNP1_A1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP_A2\DNP1_A1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP_A2\DNP1_A1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP_A2\DNP1_A1\Login\Login.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP_A2\DNP1_A1\Login\Login.razor"
using OnlineCalendarSystem_Tier1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP_A2\DNP1_A1\Login\Login.razor"
using OnlineCalendarSystem_Tier1.Login;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "c:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP_A2\DNP1_A1\Login\Login.razor"
       
    private User user;
    private string username;
    private string password;
    private string errorMessage;
    
    protected override Task OnInitializedAsync()
    {   
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "c:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP_A2\DNP1_A1\Login\Login.razor"
                                             
    }
    public async Task PerformLogin()
    {
        errorMessage = "";
        try
        {
            ((Authentication) AuthenticationStateProvider).validateLogin(username, password);
            username = "";
            password = "";
            NavigationManager.NavigateTo("/main");
        }
        catch (Exception e)
        {
            errorMessage = "User is not registered";
        }
    }

    public async Task PerformLogout()
    {
        errorMessage = "";
        username = "";
        password = "";
        try
        {
            ((Authentication) AuthenticationStateProvider).LogOut();
            NavigationManager.NavigateTo("/Login");
        }
        catch (Exception e)
        {
          errorMessage = "404 Not found";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591