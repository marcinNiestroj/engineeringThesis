#pragma checksum "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20290db594da7fc510caaca1c3f190edc4c88631"
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
#line 1 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
using ProjektInzynierskiBlazor.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
using ProjektInzynierskiBlazor.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    public partial class EditRolesAccess : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show");
            __builder.AddAttribute(2, "id", "editModal");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:block");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog");
            __builder.AddAttribute(7, "role", "document");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.AddMarkupContent(12, "<h5 class=\"modal-title\">Edytuj role</h5>\r\n                ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "close");
            __builder.AddAttribute(16, "data-dismiss", "modal");
            __builder.AddAttribute(17, "aria-label", "Close");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
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
            __builder.AddMarkupContent(30, "<label for=\"Name\" class=\"control-label\">Nazwa</label>\r\n                                ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "form", "Name");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
                                                                                rolesAccess.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rolesAccess.Name = __value, rolesAccess.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "row");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-md-8");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group");
            __builder.AddMarkupContent(43, "<label for=\"UrlAddress\" class=\"control-label\">UrlAddress</label>\r\n                                ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "form", "UrlAddress");
            __builder.AddAttribute(46, "class", "form-control");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
                                                                                      rolesAccess.UrlAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rolesAccess.UrlAddress = __value, rolesAccess.UrlAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "row");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col-md-8");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "form-group");
            __builder.AddMarkupContent(56, "<label for=\"AccessString\" class=\"control-label\">AccessString</label>\r\n                                ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "form", "AccessString");
            __builder.AddAttribute(59, "class", "form-control");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
                                                                                        rolesAccess.AccessString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rolesAccess.AccessString = __value, rolesAccess.AccessString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "row");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "form-group");
            __builder.AddMarkupContent(67, "<label for=\"AccessChechbox\" class=\"control-label\"><b>Uprawnienia dostępu</b></label>\r\n                            ");
            __Blazor.ProjektInzynierskiBlazor.Pages.Roles.EditRolesAccess.TypeInference.CreateAccessesCheckboxList_0(__builder, 68, 69, 
#nullable restore
#line 45 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
                                                         AllRoles

#line default
#line hidden
#nullable disable
            , 70, 
#nullable restore
#line 45 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
                                                                                (x) => x.Name

#line default
#line hidden
#nullable disable
            , 71, 
#nullable restore
#line 45 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
                                                                                                              (x) => x.Name

#line default
#line hidden
#nullable disable
            , 72, 
#nullable restore
#line 45 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
                                                                                                                                               SelectedItems

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "col-md-4");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "type", "button");
            __builder.AddAttribute(78, "class", "btn btn-warning");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
                                                                                    SelectValues

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "value", "Potwierdź wybór");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "row");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "col-md-4");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group");
            __builder.OpenElement(88, "input");
            __builder.AddAttribute(89, "type", "button");
            __builder.AddAttribute(90, "class", "btn btn-success");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
                                                                                        UpdateRoleAccess

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "value", "Zapisz");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                                ");
            __builder.OpenElement(94, "input");
            __builder.AddAttribute(95, "type", "button");
            __builder.AddAttribute(96, "class", "btn btn-primary");
            __builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
                                                                                        ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(98, "value", "Anuluj");
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
#line 65 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\EditRolesAccess.razor"
       
    [Parameter]
    public string EditObjId { get; set; }

    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    private List<RolesAccess> AllRolesAccesses = new List<RolesAccess>();
    private List<IdentityRole> AllRoles = new List<IdentityRole>();
    protected List<string> SelectedItems = new List<string>();

    RolesAccess rolesAccess = new RolesAccess();

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }

    protected async void UpdateRoleAccess()
    {
        await rolesAccessService.UpdateRolesAccessAsync(rolesAccess);
        await ModalCancel();
    }

    protected override async Task OnInitializedAsync()
    {
        AllRoles = await Task.Run(() => rolesService.GetAllRolesAsync());
        rolesAccess = await Task.Run(() => rolesAccessService.GetRolesAccessAsync(EditObjId));
    }

    private void SelectValues()
    {
        rolesAccess.AccessString = string.Join(", ", SelectedItems.ToArray());
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RolesService rolesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RolesAccessService rolesAccessService { get; set; }
    }
}
namespace __Blazor.ProjektInzynierskiBlazor.Pages.Roles.EditRolesAccess
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateAccessesCheckboxList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Func<TItem, global::System.String> __arg1, int __seq2, global::System.Func<TItem, global::System.Object> __arg2, int __seq3, global::System.Collections.Generic.List<global::System.String> __arg3)
        {
        __builder.OpenComponent<global::ProjektInzynierskiBlazor.Pages.Roles.AccessesCheckboxList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextField", __arg1);
        __builder.AddAttribute(__seq2, "ValueField", __arg2);
        __builder.AddAttribute(__seq3, "SelectedValues", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
