#pragma checksum "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "250c39f3d3134c31ca507b361cd91c18acdb5fa0"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Zarządzaj rolami</h3>");
#nullable restore
#line 9 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
 if (AllRoles is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Ładowanie...!</em></p>");
#nullable restore
#line 12 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-info");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                           () => OpenAddDialog()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "Dodaj rolę");
            __builder.CloseElement();
            __builder.OpenElement(6, "div");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-bordered");
            __builder.AddMarkupContent(9, "<thead><tr><th scope=\"col\">Nazwa</th></tr></thead>\r\n            ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 25 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                 foreach (var item in AllRoles)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "th");
            __builder.AddAttribute(13, "scope", "row");
            __builder.AddContent(14, 
#nullable restore
#line 28 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                         item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "btn btn-primary btn-sm");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                                                           () => OpenEditDialog(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Edytuj");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                                                          () => OpenDeleteDialog(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "Usuń");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
     if (AddDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Roles.AddRole>(29);
            __builder.AddAttribute(30, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 43 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                          OnAddDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 44 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
     if (EditDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Roles.EditRole>(31);
            __builder.AddAttribute(32, "EditObjId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                              roleId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 48 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                               OnEditDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 49 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
     if (DeleteDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Roles.DeleteRole>(34);
            __builder.AddAttribute(35, "DeleteObjId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                  roleId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 53 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                   OnDeleteDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 54 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
     

}

#line default
#line hidden
#nullable disable
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
