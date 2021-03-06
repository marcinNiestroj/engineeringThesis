// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProjektInzynierskiBlazor.Pages.Departments
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Departments\Departments.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Departments\Departments.razor"
using ProjektInzynierskiBlazor.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Departments\Departments.razor"
using ProjektInzynierskiBlazor.Data.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Departments")]
    public partial class Departments : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Departments\Departments.razor"
       
    private List<Department> AllDepartments = new List<Department>();
    private List<RolesAccess> AllRolesAccesses = new List<RolesAccess>();

    public Department department { get; set; }
    private RolesAccess rolesAccess { get; set; }
    public bool AddDialogOpen { get; set; }
    public bool EditDialogOpen { get; set; }
    public bool DeleteDialogOpen { get; set; }
    public string departmentId { get; set; }
    public string rolesAccessString { get; set; }

    protected override async Task OnInitializedAsync()
    {
        base.OnInitialized();

        AllRolesAccesses = await Task.Run(() => rolesAccessService.GetAllRolesAccessesAsync());
        AllDepartments = await Task.Run(() => departmentService.GetAllDepartmentsAsync());

        var SiteRoleAccess = AllRolesAccesses.Where(x => (x.UrlAddress.ToString()).Contains("/Departments"));
        rolesAccess = SiteRoleAccess.First();
        rolesAccessString = rolesAccess.AccessString.ToString();

        StateHasChanged();
    }

    private async Task OnAddDialogClose(bool accepted)
    {
        AddDialogOpen = false;
        AllDepartments = await Task.Run(() => departmentService.GetAllDepartmentsAsync());
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
        AllDepartments = await Task.Run(() => departmentService.GetAllDepartmentsAsync());
        StateHasChanged();
    }

    private void OpenEditDialog(string idToEdit)
    {
        EditDialogOpen = true;
        departmentId = idToEdit;
        StateHasChanged();
    }

    private async Task OnDeleteDialogClose(bool accepted)
    {
        if (accepted)
        {
            department = await Task.Run(() => departmentService.GetDepartmentAsync(departmentId));
            await departmentService.DeleteDepartmentAsync(department);
        }

        DeleteDialogOpen = false;
        AllDepartments = await Task.Run(() => departmentService.GetAllDepartmentsAsync());
        StateHasChanged();
    }

    private void OpenDeleteDialog(string idToDelete)
    {
        DeleteDialogOpen = true;
        departmentId = idToDelete;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RolesAccessService rolesAccessService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DepartmentService departmentService { get; set; }
    }
}
#pragma warning restore 1591
