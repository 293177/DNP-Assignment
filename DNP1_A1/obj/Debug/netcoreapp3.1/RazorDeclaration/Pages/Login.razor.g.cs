#pragma checksum "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "287ac5e9123b37d0f1db39dd94a5effcf0c4f895"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\Pages\Login.razor"
using DNP1_A1.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\Pages\Login.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\javic\Desktop\UNI\3 Semester\DNP\DNP1_A1\Pages\Login.razor"
       
    private User user;
    private string username;
    private string password;
    private string errorMessage;
    
    protected override Task OnInitializedAsync()
    {
        user = new User();
        return base.OnInitializedAsync();
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
    private async Task<bool> RegisterUser()
    {
        //assume that user is valid
        userService.AddUser(user.username,user.password,"User");
        return await Task.FromResult(true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUser userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591