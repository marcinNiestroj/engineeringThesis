#pragma checksum "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33e546495fceed4e512e676d0aa77ba00a1f8453"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
using ProjektInzynierskiBlazor.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
using ProjektInzynierskiBlazor.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
using ProjektInzynierskiBlazor.Data;

#line default
#line hidden
#nullable disable
    public partial class HomeEditOfficeWork : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show");
            __builder.AddAttribute(2, "id", "editModal");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "tabindex", "0");
            __builder.AddAttribute(5, "aria-labelledby", "editModalTitle");
            __builder.AddAttribute(6, "aria-hidden", "true");
            __builder.AddAttribute(7, "style", "overflow:auto; display:block");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-dialog modal-lg");
            __builder.AddAttribute(10, "role", "document");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-content");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-header");
            __builder.AddMarkupContent(15, "<h5 class=\"modal-title\" id=\"editModalTitle\">Edytuj pracę kameralną</h5>\r\n                ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "close");
            __builder.AddAttribute(19, "data-dismiss", "modal");
            __builder.AddAttribute(20, "aria-label", "Close");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                                                       ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "modal-body");
            __builder.OpenElement(26, "form");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-md-8");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.OpenElement(33, "table");
            __builder.AddAttribute(34, "class", "table");
            __builder.AddMarkupContent(35, "<thead><tr><th scope=\"col\">Termin zlecenia</th></tr></thead>\r\n                                    ");
            __builder.OpenElement(36, "tbody");
            __builder.OpenElement(37, "tr");
            __builder.OpenElement(38, "th");
            __builder.AddAttribute(39, "scope", "row");
            __builder.OpenElement(40, "p");
            __builder.AddMarkupContent(41, "<th scope=\"row\"><label for=\"OrderFrom\" class=\"control-label\">Od</label></th>\r\n                                            ");
            __builder.OpenElement(42, "th");
            __builder.AddAttribute(43, "scope", "row");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "form", "OrderTo");
            __builder.AddAttribute(46, "class", "form-control");
            __builder.AddAttribute(47, "type", "datetime");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                                                                                                                   officeWork.From

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => officeWork.From = __value, officeWork.From));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddContent(50, "{0:yyyy-MM-dd HH:mm}");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                            ");
            __builder.OpenElement(52, "p");
            __builder.AddMarkupContent(53, "<th scope=\"row\"><label for=\"OrderTo\" class=\"control-label\">Do</label></th>\r\n                                            ");
            __builder.OpenElement(54, "th");
            __builder.AddAttribute(55, "scope", "row");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "form", "OrderTo");
            __builder.AddAttribute(58, "class", "form-control");
            __builder.AddAttribute(59, "type", "datetime");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                                                                                                                   officeWork.To

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => officeWork.To = __value, officeWork.To));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddContent(62, "{0:yyyy-MM-dd HH:mm}");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                            ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-group");
            __builder.AddMarkupContent(66, "<th scope=\"col\">Określ status pracy kameralnej</th>\r\n                                ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "form-control-wrapper");
            __builder.OpenElement(69, "select");
            __builder.AddAttribute(70, "class", "form-control=label");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                               officeWork.Status

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => officeWork.Status = __value, officeWork.Status));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(73, "option");
            __builder.AddAttribute(74, "value");
            __builder.AddContent(75, 
#nullable restore
#line 48 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                          officeWork.Status.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                         foreach (var item in Enum.GetValues(typeof(Statuses)))
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(76, "option");
            __builder.AddAttribute(77, "value", 
#nullable restore
#line 51 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                            item

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(78, 
#nullable restore
#line 51 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                   item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                            ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "form-group");
            __builder.AddMarkupContent(82, "<th scope=\"col\">Wybierz zlecenie</th>\r\n                                ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "form-control-wrapper");
            __builder.OpenElement(85, "select");
            __builder.AddAttribute(86, "class", "form-control=label");
            __builder.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                                  OrderChangeHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(88, "option");
            __builder.AddAttribute(89, "value");
            __builder.AddContent(90, "-Brak-");
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                         foreach (var item in AllOrders)
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(91, "option");
            __builder.AddAttribute(92, "value", 
#nullable restore
#line 63 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                            item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(93, 
#nullable restore
#line 63 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                      item.Location.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(94, ", ");
            __builder.AddContent(95, 
#nullable restore
#line 63 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                                           item.Orderer.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(96, ", ");
            __builder.AddContent(97, 
#nullable restore
#line 63 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                                                               string.Format("{0:yyyy-MM-dd HH:mm}", item.OrderFrom)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(98, ", ");
            __builder.AddContent(99, 
#nullable restore
#line 63 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                                                                                                                       string.Format("{0:yyyy-MM-dd HH:mm}", item.OrderTo)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(100, ", ");
            __builder.AddContent(101, 
#nullable restore
#line 63 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                                                                                                                                                                             item.WhatToDo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                            ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "form-group");
            __builder.AddMarkupContent(105, "<th scope=\"col\">Wybierz pracownika</th>\r\n                                ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "form-control-wrapper");
            __builder.OpenElement(108, "select");
            __builder.AddAttribute(109, "class", "form-control=label");
            __builder.AddAttribute(110, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                                  EmployeeChangeHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(111, "option");
            __builder.AddAttribute(112, "value");
            __builder.AddContent(113, "-Brak-");
            __builder.CloseElement();
#nullable restore
#line 73 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                         foreach (var item in AllEmployees)
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(114, "option");
            __builder.AddAttribute(115, "value", 
#nullable restore
#line 75 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                            item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(116, 
#nullable restore
#line 75 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                      item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(117, ", ");
            __builder.AddContent(118, 
#nullable restore
#line 75 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                                       item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                            ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "form-group");
            __builder.AddMarkupContent(122, "<th scope=\"col\">Praca do wykonania</th>\r\n                                ");
            __builder.OpenElement(123, "input");
            __builder.AddAttribute(124, "form", "WhatToDo");
            __builder.AddAttribute(125, "class", "form-control");
            __builder.AddAttribute(126, "size", "50");
            __builder.AddAttribute(127, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 82 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                                              officeWork.WhatToDo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(128, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => officeWork.WhatToDo = __value, officeWork.WhatToDo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                            ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "form-group");
            __builder.AddMarkupContent(132, "<th scope=\"col\">Informacje</th>\r\n                                ");
            __builder.OpenElement(133, "input");
            __builder.AddAttribute(134, "form", "Informations");
            __builder.AddAttribute(135, "class", "form-control");
            __builder.AddAttribute(136, "size", "50");
            __builder.AddAttribute(137, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 86 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                                                  officeWork.Informations

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(138, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => officeWork.Informations = __value, officeWork.Informations));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                            ");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "class", "row");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "col-md-4");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "class", "form-group");
            __builder.OpenElement(146, "input");
            __builder.AddAttribute(147, "type", "button");
            __builder.AddAttribute(148, "class", "btn btn-success");
            __builder.AddAttribute(149, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                                                UpdateOfficeWork

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(150, "value", "Zapisz");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                                        ");
            __builder.OpenElement(152, "input");
            __builder.AddAttribute(153, "type", "button");
            __builder.AddAttribute(154, "class", "btn btn-primary");
            __builder.AddAttribute(155, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
                                                                                                ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(156, "value", "Anuluj");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Home\HomeEditOfficeWork.razor"
       
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
