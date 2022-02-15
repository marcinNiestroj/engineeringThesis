// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProjektInzynierskiBlazor.Pages.OfficeWorks
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
#line 2 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\OfficeWorks\OfficeWorks.razor"
using ProjektInzynierskiBlazor.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\OfficeWorks\OfficeWorks.razor"
using ProjektInzynierskiBlazor.Data.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/OfficeWorks")]
    public partial class OfficeWorks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\OfficeWorks\OfficeWorks.razor"
           
        private List<OfficeWork> AllOfficeWorks = new List<OfficeWork>();
        private List<Order> AllOrders = new List<Order>();

        public OfficeWork officeWork { get; set; }
        public bool AddDialogOpen { get; set; }
        public bool EditDialogOpen { get; set; }
        public bool DeleteDialogOpen { get; set; }
        public string officeWorkId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            base.OnInitialized();

            AllOrders = await Task.Run(() => orderService.GetAllOrdersAsync());
            AllOfficeWorks = await Task.Run(() => officeWorkService.GetAllOfficeWorksAsync());
            StateHasChanged();
        }

        private async Task OnAddDialogClose(bool accepted)
        {
            AddDialogOpen = false;
            AllOfficeWorks = await Task.Run(() => officeWorkService.GetAllOfficeWorksAsync());
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
            AllOfficeWorks = await Task.Run(() => officeWorkService.GetAllOfficeWorksAsync());
            StateHasChanged();
        }

        private void OpenEditDialog(string idToEdit)
        {
            EditDialogOpen = true;
            officeWorkId = idToEdit;
            StateHasChanged();
        }

        private async Task OnDeleteDialogClose(bool accepted)
        {
            if (accepted)
            {
                officeWork = await Task.Run(() => officeWorkService.GetOfficeWorkAsync(officeWorkId));
                await officeWorkService.DeleteOfficeWorkAsync(officeWork);
            }

            DeleteDialogOpen = false;
            AllOfficeWorks = await Task.Run(() => officeWorkService.GetAllOfficeWorksAsync());
            StateHasChanged();
        }

        private void OpenDeleteDialog(string idToDelete)
        {
            DeleteDialogOpen = true;
            officeWorkId = idToDelete;
            StateHasChanged();
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService employeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DepartmentService departmentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderService orderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OfficeWorkService officeWorkService { get; set; }
    }
}
#pragma warning restore 1591
