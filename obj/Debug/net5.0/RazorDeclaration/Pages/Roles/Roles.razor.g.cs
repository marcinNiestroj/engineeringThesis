// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProjektInzynierskiBlazor.Pages.Roles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\_Imports.razor"
using ProjektInzynierskiBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\_Imports.razor"
using ProjektInzynierskiBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
using ProjektInzynierskiBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
using ProjektInzynierskiBlazor.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Roles")]
    public partial class Roles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
       
    public List<IdentityRole> AllRoles = new List<IdentityRole>();

    public IdentityRole role { get; set; }
    public bool AddDialogOpen { get; set; }
    public bool EditDialogOpen { get; set; }
    public bool DeleteDialogOpen { get; set; }
    public string roleId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        base.OnInitialized();

        AllRoles = await Task.Run(() => rolesService.GetAllRolesAsync());
        StateHasChanged();
    }

    private async Task OnAddDialogClose(bool accepted)
    {
        AddDialogOpen = false;
        AllRoles = await Task.Run(() => rolesService.GetAllRolesAsync());
        StateHasChanged();
    }

    private void OpenAddDialog()
    {
        AddDialogOpen = true;
        StateHasChanged();
    }

    private async Task OnEditDialogClose(bool accepted)
    {
        EditDialogOpen = false;
        AllRoles = await Task.Run(() => rolesService.GetAllRolesAsync());
        StateHasChanged();
    }

    private void OpenEditDialog(string idToEdit)
    {
        EditDialogOpen = true;
        roleId = idToEdit;
        StateHasChanged();
    }

    private async Task OnDeleteDialogClose(bool accepted)
    {
        if (accepted)
        {
            role = await Task.Run(() => rolesService.GetRoleAsync(roleId));
            await rolesService.DeleteRoleAsync(role);
        }

        DeleteDialogOpen = false;
        AllRoles = await Task.Run(() => rolesService.GetAllRolesAsync());
        StateHasChanged();
    }

    private void OpenDeleteDialog(string idToDelete)
    {
        DeleteDialogOpen = true;
        roleId = idToDelete;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RolesService rolesService { get; set; }
    }
}
#pragma warning restore 1591
