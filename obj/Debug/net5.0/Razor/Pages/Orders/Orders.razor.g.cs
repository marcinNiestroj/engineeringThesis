#pragma checksum "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0dbeaa6af525be9fc44edb9479202ad5b32a289"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjektInzynierskiBlazor.Pages.Orders
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
#line 2 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
using ProjektInzynierskiBlazor.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
using ProjektInzynierskiBlazor.Data.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Orders")]
    public partial class Orders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Zlecenia</h3>");
#nullable restore
#line 14 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
 if (AllEmployees is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Ładowanie...!</em></p>");
#nullable restore
#line 17 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
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
#line 20 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                           () => OpenAddDialog()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Dodaj zlecenie");
            __builder.CloseElement();
            __builder.OpenElement(6, "div");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-bordered");
            __builder.AddMarkupContent(9, @"<thead><tr><th scope=""col"">Data i godzina</th>
                    <th scope=""col"">Status</th>
                    <th scope=""col"">Czas wykonania</th>
                    <th scope=""col"">Obiekt</th>
                    <th scope=""col"">Oddział</th>
                    <th scope=""col"">Zleceniodawca</th>
                    <th scope=""col"">Treść zlecenia</th>
                    <th scope=""col"">Informacje</th></tr></thead>
            ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 37 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                 foreach (var item in AllOrders)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "th");
            __builder.AddAttribute(13, "scope", "row");
            __builder.OpenElement(14, "p");
            __builder.AddContent(15, 
#nullable restore
#line 41 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                            string.Format("{0:yyyy-MM-dd HH:mm}", item.OrderFrom)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, 
#nullable restore
#line 42 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                            string.Format("{0:yyyy-MM-dd HH:mm}", item.OrderTo)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "th");
            __builder.AddAttribute(21, "scope", "row");
            __builder.AddContent(22, 
#nullable restore
#line 44 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                     item.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "th");
            __builder.AddAttribute(25, "scope", "row");
            __builder.OpenElement(26, "p");
            __builder.AddContent(27, 
#nullable restore
#line 46 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                            string.Format("{0:yyyy-MM-dd HH:mm}", item.DoneFrom)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "p");
            __builder.AddContent(30, 
#nullable restore
#line 47 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                            string.Format("{0:yyyy-MM-dd HH:mm}", item.DoneTo)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "th");
            __builder.AddAttribute(33, "scope", "row");
            __builder.AddContent(34, 
#nullable restore
#line 49 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                     item.Location.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "th");
            __builder.AddAttribute(37, "scope", "row");
            __builder.AddContent(38, 
#nullable restore
#line 50 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                     item.Department.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "th");
            __builder.AddAttribute(41, "scope", "row");
            __builder.AddContent(42, 
#nullable restore
#line 51 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                     item.Orderer.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "th");
            __builder.AddAttribute(45, "scope", "row");
            __builder.AddContent(46, 
#nullable restore
#line 52 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                     item.WhatToDo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "th");
            __builder.AddAttribute(49, "scope", "row");
            __builder.AddContent(50, 
#nullable restore
#line 53 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                     item.Informations

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "td");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "btn btn-secondary btn-sm");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                                                                         () => OpenDetailsDialog(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(57, "Szczegóły");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "td");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "type", "button");
            __builder.AddAttribute(62, "class", "btn btn-primary btn-sm");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                                                                       () => OpenEditDialog(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(64, "Edytuj");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "td");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "type", "button");
            __builder.AddAttribute(69, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                                                                      () => OpenDeleteDialog(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(71, "Usuń");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
     if (AddDialogOpen)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Orders.AddOrder>(72);
            __builder.AddAttribute(73, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 71 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                            OnAddDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 72 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
     if (EditDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Orders.EditOrder>(74);
            __builder.AddAttribute(75, "EditObjId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 76 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                               orderId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 76 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                                  OnEditDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 77 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
     if (DeleteDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Orders.DeleteOrder>(77);
            __builder.AddAttribute(78, "DeleteObjId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                   orderId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 81 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                                      OnDeleteDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 82 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
     if (DetailsDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Orders.OrderDetails>(80);
            __builder.AddAttribute(81, "DetailsObjId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 86 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                     orderId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 86 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
                                                        OnDetailsDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 87 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Orders\Orders.razor"
       
    private List<Order> AllOrders = new List<Order>();
    private List<Employee> AllEmployees = new List<Employee>();
    private List<Department> AllDepartments = new List<Department>();
    private List<Orderer> AllOrderers = new List<Orderer>();
    private List<Equipment> AllEquipments = new List<Equipment>();
    private List<Car> AllCars = new List<Car>();

    public Order order { get; set; }
    public bool AddDialogOpen { get; set; }
    public bool EditDialogOpen { get; set; }
    public bool DeleteDialogOpen { get; set; }
    public bool DetailsDialogOpen { get; set; }
    public string orderId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        base.OnInitialized();

        AllOrders = await Task.Run(() => orderService.GetAllOrdersAsync());
        AllEmployees = await Task.Run(() => employeeService.GetAllEmployeesAsync());
        AllDepartments = await Task.Run(() => departmentService.GetAllDepartmentsAsync());
        AllOrderers = await Task.Run(() => ordererService.GetAllOrderersAsync());
        AllEquipments = await Task.Run(() => equipmentService.GetAllEquipmentAsync());
        AllCars = await Task.Run(() => carService.GetAllCarsAsync());
        StateHasChanged();
    }

    private async Task OnAddDialogClose(bool accepted)
    {
        AddDialogOpen = false;
        AllOrders = await Task.Run(() => orderService.GetAllOrdersAsync());
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
        AllOrders = await Task.Run(() => orderService.GetAllOrdersAsync());
        StateHasChanged();
    }

    private void OpenEditDialog(string idToEdit)
    {
        EditDialogOpen = true;
        orderId = idToEdit;
        StateHasChanged();
    }

    private async Task OnDetailsDialogClose(bool accepted)
    {
        DetailsDialogOpen = false;
        AllOrders = await Task.Run(() => orderService.GetAllOrdersAsync());
        StateHasChanged();
    }

    private void OpenDetailsDialog(string id)
    {
        DetailsDialogOpen = true;
        orderId = id;
        StateHasChanged();
    }

    private async Task OnDeleteDialogClose(bool accepted)
    {
        if (accepted)
        {
            order = await Task.Run(() => orderService.GetOrderAsync(orderId));
            await orderService.DeleteOrderAsync(order);
        }

        DeleteDialogOpen = false;
        AllOrders = await Task.Run(() => orderService.GetAllOrdersAsync());
        StateHasChanged();
    }

    private void OpenDeleteDialog(string idToDelete)
    {
        DeleteDialogOpen = true;
        orderId = idToDelete;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService employeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CarService carService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EquipmentService equipmentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocationService locationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrdererService ordererService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DepartmentService departmentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderService orderService { get; set; }
    }
}
#pragma warning restore 1591
