// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProjektInzynierskiBlazor.Pages.Home
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
#line 1 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\AddOfficeWork.razor"
using ProjektInzynierskiBlazor.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\AddOfficeWork.razor"
using ProjektInzynierskiBlazor.Data.Services;

#line default
#line hidden
#nullable disable
    public partial class AddOfficeWork : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\AddOfficeWork.razor"
       
    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    private List<Order> AllOrders = new List<Order>();
    private List<Employee> AllEmployees = new List<Employee>();

    OfficeWork officeWork = new OfficeWork();

    Order _selectedOrder;
    Employee _selectedEmployee;

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }

    protected async void CreateOfficeWork()
    {
        officeWork.Status = Data.Statuses.Zlecone;
        officeWork.Department = _selectedOrder.Department;
        await officeWorkService.InsertOfficeWorkAsync(officeWork);
        await ModalCancel();
    }

    protected override async Task OnInitializedAsync()
    {
        base.OnInitialized();

        AllOrders = await Task.Run(() => orderService.GetAllOrdersAsync());
        AllEmployees = await Task.Run(() => employeeService.GetAllEmployeesAsync());
        StateHasChanged();
    }

    private async Task OrderChangeHandler(ChangeEventArgs args)
    {
        _selectedOrder = await Task.Run(() => orderService.GetOrderAsync(args.Value.ToString()));
        officeWork.Order = _selectedOrder;
        StateHasChanged();
    }

    private async Task EmployeeChangeHandler(ChangeEventArgs args)
    {
        _selectedEmployee = await Task.Run(() => employeeService.GetEmployeeAsync(args.Value.ToString()));
        officeWork.Employee = _selectedEmployee;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService employeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderService orderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OfficeWorkService officeWorkService { get; set; }
    }
}
#pragma warning restore 1591
