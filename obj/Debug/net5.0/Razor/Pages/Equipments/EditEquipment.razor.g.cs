#pragma checksum "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Equipments\EditEquipment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66027124c5f97e44bc3e232e976d96226e38c723"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjektInzynierskiBlazor.Pages.Equipments
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
#line 1 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Equipments\EditEquipment.razor"
using ProjektInzynierskiBlazor.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Equipments\EditEquipment.razor"
using ProjektInzynierskiBlazor.Data.Services;

#line default
#line hidden
#nullable disable
    public partial class EditEquipment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show");
            __builder.AddAttribute(2, "id", "deleteModal");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:block");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog");
            __builder.AddAttribute(7, "role", "document");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.AddMarkupContent(12, "<h5 class=\"modal-title\">Edytuj wyposażenie</h5>\r\n                ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "close");
            __builder.AddAttribute(16, "data-dismiss", "modal");
            __builder.AddAttribute(17, "aria-label", "Close");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Equipments\EditEquipment.razor"
                                                                                                       ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "modal-body");
            __builder.OpenElement(23, "form");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-md-8");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.AddMarkupContent(30, "<label for=\"Number\" class=\"control-label\">Oznaczenie</label>\r\n                                ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "form", "Number");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Equipments\EditEquipment.razor"
                                                                                  equipment.Number

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => equipment.Number = __value, equipment.Number));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group");
            __builder.AddMarkupContent(39, "<label for=\"Elements\" class=\"control-label\">Zawartość</label>\r\n                                ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "form", "Elements");
            __builder.AddAttribute(42, "class", "form-control");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Equipments\EditEquipment.razor"
                                                                                    equipment.Elements

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => equipment.Elements = __value, equipment.Elements));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "form-group");
            __builder.AddMarkupContent(48, "<label for=\"Review\" class=\"control-label\">Przegląd</label>\r\n                                ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "form", "Review");
            __builder.AddAttribute(51, "class", "form-control");
            __builder.AddAttribute(52, "type", "date");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Equipments\EditEquipment.razor"
                                                                                              equipment.Review

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => equipment.Review = __value, equipment.Review, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                            ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "form-group");
            __builder.AddMarkupContent(58, "<label for=\"Informations\" class=\"control-label\">Informacje</label>\r\n                                ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "form", "Informations");
            __builder.AddAttribute(61, "class", "form-control");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Equipments\EditEquipment.razor"
                                                                                        equipment.Informations

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => equipment.Informations = __value, equipment.Informations));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n                    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "row");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col-md-4");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "form-group");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "type", "button");
            __builder.AddAttribute(73, "class", "btn btn-success");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Equipments\EditEquipment.razor"
                                                                                        UpdateEqiupment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "value", "Zapisz");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                                ");
            __builder.OpenElement(77, "input");
            __builder.AddAttribute(78, "type", "button");
            __builder.AddAttribute(79, "class", "btn btn-primary");
            __builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Equipments\EditEquipment.razor"
                                                                                        ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "value", "Anuluj");
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
#line 51 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Equipments\EditEquipment.razor"
       
    [Parameter]
    public string EditObjId { get; set; }

    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    Equipment equipment = new Equipment();

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }

    protected async void UpdateEqiupment()
    {
        await equipmentService.UpdateEquipmentAsync(equipment);
        await ModalCancel();
    }

    protected override async Task OnInitializedAsync()
    {
        equipment = await Task.Run(() => equipmentService.GetEquipmentAsync(EditObjId));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EquipmentService equipmentService { get; set; }
    }
}
#pragma warning restore 1591
