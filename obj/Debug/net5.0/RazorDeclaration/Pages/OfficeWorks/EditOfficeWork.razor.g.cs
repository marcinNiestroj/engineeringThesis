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
#line 1 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\OfficeWorks\EditOfficeWork.razor"
using ProjektInzynierskiBlazor.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\OfficeWorks\EditOfficeWork.razor"
using ProjektInzynierskiBlazor.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\OfficeWorks\EditOfficeWork.razor"
using ProjektInzynierskiBlazor.Data;

#line default
#line hidden
#nullable disable
    public partial class EditOfficeWork : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\OfficeWorks\EditOfficeWork.razor"
       
    [Parameter]
    public string EditObjId { get; set; }

    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    private List<OfficeWork> AllOfficeWorks = new List<OfficeWork>();
    private List<Order> AllOrders = new List<Order>();
    private List<Employee> AllEmployees = new List<Employee>();

    OfficeWork officeWork = new OfficeWork();
    Order _order = new Order();
    Employee _employee = new Employee();

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }

    protected async void UpdateOfficeWork()
    {
        await officeWorkService.UpdateOfficeWorkAsync(officeWork);
        await ModalCancel();
    }

    protected override async Task OnInitializedAsync()
    {
        officeWork = await Task.Run(() => officeWorkService.GetOfficeWorkAsync(EditObjId));
        AllOrders = await Task.Run(() => orderService.GetAllOrdersAsync());
        AllEmployees = await Task.Run(() => employeeService.GetAllEmployeesAsync());

        _order = officeWork.Order;
        _employee = officeWork.Employee;
    }

    private async Task OrderChangeHandler(ChangeEventArgs args)
    {
        _order = await Task.Run(() => orderService.GetOrderAsync(args.Value.ToString()));
        officeWork.Order = _order;
        StateHasChanged();
    }

    private async Task EmployeeChangeHandler(ChangeEventArgs args)
    {
        _employee = await Task.Run(() => employeeService.GetEmployeeAsync(args.Value.ToString()));
        officeWork.Employee = _employee;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderService orderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService employeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OfficeWorkService officeWorkService { get; set; }
    }
}
#pragma warning restore 1591
