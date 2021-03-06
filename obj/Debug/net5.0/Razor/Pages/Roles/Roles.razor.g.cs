#pragma checksum "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c44a93ed24c7f8572c10295d4a2d633a6d8875e"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjektInzynierskiBlazor.Pages.Roles
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
#line 2 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
using ProjektInzynierskiBlazor.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
using ProjektInzynierskiBlazor.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
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
            __builder.AddMarkupContent(0, "<h3>Zarz??dzaj uprawnieniami i rolami u??ytkownik??w</h3>");
#nullable restore
#line 13 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
 if (AllRoles is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>??adowanie...!</em></p>");
#nullable restore
#line 16 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
}
else
{
    //Uncomment this part after add admin role to admim user
    /*<AuthorizeView Roles="@rolesAccessString">
        <Authorized>*/

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.OpenElement(3, "th");
            __builder.AddAttribute(4, "scope", "row");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-info");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                       () => OpenAddRoleDialog()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "Dodaj rol??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table table-bordered");
            __builder.AddMarkupContent(13, "<thead><tr><th scope=\"col\">Nazwa</th></tr></thead>\r\n                    ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 34 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                         foreach (var item in AllRoles)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "th");
            __builder.AddAttribute(17, "scope", "row");
            __builder.AddContent(18, 
#nullable restore
#line 37 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                 item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                                ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "class", "btn btn-primary btn-sm");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                                                                   () => OpenEditRoleDialog(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Edytuj");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                ");
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "type", "button");
            __builder.AddAttribute(30, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                                                                  () => OpenDeleteRoleDialog(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "Usu??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "<h3>Zarz??dzaj uprawnieniami dost??pu</h3>\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-info");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                       () => OpenAddAccessDialog()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "Dodaj stron??");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n                ");
            __builder.OpenElement(40, "div");
            __builder.OpenElement(41, "table");
            __builder.AddAttribute(42, "class", "table table-bordered");
            __builder.AddMarkupContent(43, "<thead><tr><th scope=\"col\">Nazwa</th>\r\n                                <th scope=\"col\">Adres URL</th>\r\n                                <th scope=\"col\">Dost??p</th></tr></thead>\r\n                        ");
            __builder.OpenElement(44, "tbody");
#nullable restore
#line 66 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                             foreach (var item in AllRolesAccesses)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "tr");
            __builder.OpenElement(46, "th");
            __builder.AddAttribute(47, "scope", "row");
            __builder.AddContent(48, 
#nullable restore
#line 69 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                     item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                    ");
            __builder.OpenElement(50, "th");
            __builder.AddAttribute(51, "scope", "row");
            __builder.AddContent(52, 
#nullable restore
#line 70 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                     item.UrlAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                                    ");
            __builder.OpenElement(54, "th");
            __builder.AddAttribute(55, "scope", "row");
            __builder.AddContent(56, 
#nullable restore
#line 71 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                     item.AccessString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                    ");
            __builder.OpenElement(58, "td");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "type", "button");
            __builder.AddAttribute(61, "class", "btn btn-primary btn-sm");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                                                                       () => OpenEditAccessDialog(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(63, "Edytuj");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                    ");
            __builder.OpenElement(65, "td");
            __builder.OpenElement(66, "button");
            __builder.AddAttribute(67, "type", "button");
            __builder.AddAttribute(68, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                                                                      () => OpenDeleteAccessDialog(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(70, "Usu??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 79 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "<h3>Zarz??dzaj rolami u??ytkownik??w</h3>\r\n            ");
            __builder.OpenElement(72, "div");
            __builder.OpenElement(73, "div");
            __builder.OpenElement(74, "table");
            __builder.AddAttribute(75, "class", "table table-bordered");
            __builder.AddMarkupContent(76, "<thead><tr><th scope=\"col\">Nazwa u??ytkownika</th></tr></thead>\r\n                        ");
            __builder.OpenElement(77, "tbody");
#nullable restore
#line 96 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                             foreach (var item in AllUsers)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(78, "tr");
            __builder.OpenElement(79, "th");
            __builder.AddAttribute(80, "scope", "row");
            __builder.AddContent(81, 
#nullable restore
#line 99 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                     item.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                                    ");
            __builder.OpenElement(83, "td");
            __builder.OpenElement(84, "button");
            __builder.AddAttribute(85, "type", "button");
            __builder.AddAttribute(86, "class", "btn btn-success btn-sm");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                                                                       () => OpenAddUserRolesDialog(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(88, "Przypisz rol??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                    ");
            __builder.OpenElement(90, "td");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "type", "button");
            __builder.AddAttribute(93, "class", "btn btn-primary btn-sm");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                                                                       () => OpenEditUserRolesDialog(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(95, "Edytuj");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                                    ");
            __builder.OpenElement(97, "td");
            __builder.OpenElement(98, "button");
            __builder.AddAttribute(99, "type", "button");
            __builder.AddAttribute(100, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 107 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                                                                      () => OpenDeleteUserRolesDialog(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(102, "Usu??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 110 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 115 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
    //Uncomment this part after add admin role to admim user
    /*</Authorized>
    <NotAuthorized>
        <h5>Brak uprawnie?? do zarz??dzania pojazdami</h5>
    </NotAuthorized>
</AuthorizeView>*/

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
     if (AddRoleDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Roles.AddRole>(103);
            __builder.AddAttribute(104, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 124 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                          OnAddRoleDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 125 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
     if (EditRoleDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Roles.EditRole>(105);
            __builder.AddAttribute(106, "EditObjId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 129 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                              roleId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 129 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                               OnEditRoleDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 130 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
     if (DeleteRoleDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Roles.DeleteRole>(108);
            __builder.AddAttribute(109, "DeleteObjId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 134 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                  roleId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 134 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                   OnDeleteRoleDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 135 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
     if (AddAccessDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Roles.AddRolesAccess>(111);
            __builder.AddAttribute(112, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 139 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                 OnAddAccessDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 140 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
     if (EditAccessDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Roles.EditRolesAccess>(113);
            __builder.AddAttribute(114, "EditObjId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 144 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                     roleAccessId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(115, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 144 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                            OnEditAccessDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 145 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
     if (DeleteAccessDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Roles.DeleteRolesAccess>(116);
            __builder.AddAttribute(117, "DeleteObjId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 149 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                         roleAccessId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 149 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                                OnDeleteAccessDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 150 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
     if (AddUserRolesDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Roles.AddUserRole>(119);
            __builder.AddAttribute(120, "AddObjId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 154 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                userId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 154 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                 OnAddUserRolesDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 155 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
     if (EditUserRolesDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Roles.EditUserRole>(122);
            __builder.AddAttribute(123, "EditObjId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 159 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                  userId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 159 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                   OnEditUserRolesDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 160 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
     if (DeleteUserRolesDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjektInzynierskiBlazor.Pages.Roles.DeleteUserRole>(125);
            __builder.AddAttribute(126, "DeleteObjId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 164 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                      userId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(127, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 164 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
                                                       OnDeleteUserRolesDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 165 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 165 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 168 "C:\Users\Marcin\source\repos\ProjektInzynierski\ProjektInzynierskiBlazor\Pages\Roles\Roles.razor"
       
    //Roles
    private List<IdentityRole> AllRoles = new List<IdentityRole>();
    private List<IdentityUser> AllUsers = new List<IdentityUser>();
    private List<RolesAccess> AllRolesAccesses = new List<RolesAccess>();
    private List<IdentityUserRole<string>> AllUserRoles = new List<IdentityUserRole<string>>();

    IdentityUserRole<string> IdentityUserRole = new IdentityUserRole<string>();

    public IdentityRole role { get; set; }
    public IdentityUser user { get; set; }
    public RolesAccess rolesAccess { get; set; }
    public bool AddRoleDialogOpen { get; set; }
    public bool AddUserRolesDialogOpen { get; set; }
    public bool AddAccessDialogOpen { get; set; }
    public bool EditRoleDialogOpen { get; set; }
    public bool EditUserRolesDialogOpen { get; set; }
    public bool EditAccessDialogOpen { get; set; }
    public bool DeleteRoleDialogOpen { get; set; }
    public bool DeleteUserRolesDialogOpen { get; set; }
    public bool DeleteAccessDialogOpen { get; set; }
    public string roleId { get; set; }
    public string userId { get; set; }
    public string roleAccessId { get; set; }
    public string rolesAccessString { get; set; }

    //Accesses
    protected List<string> SelectedItems = new List<string>();
    public string OutputValue { get; set; }


    //rest Roles
    protected override async Task OnInitializedAsync()
    {
        base.OnInitialized();

        AllRoles = await Task.Run(() => rolesService.GetAllRolesAsync());
        AllUsers = await Task.Run(() => userService.GetAllUsersAsync());
        AllUserRoles = await Task.Run(() => userRolesService.GetAllIdentityUserRolesAsync());
        AllRolesAccesses = await Task.Run(() => rolesAccessService.GetAllRolesAccessesAsync());

        //Uncomment this part after add admin role to admim user
        /*var SiteRoleAccess = AllRolesAccesses.Where(x => (x.UrlAddress.ToString()).Contains("/Roles"));
        rolesAccess = SiteRoleAccess.First();
        rolesAccessString = rolesAccess.AccessString.ToString();*/

        StateHasChanged();
    }

    private async Task OnAddRoleDialogClose(bool accepted)
    {
        AddRoleDialogOpen = false;
        AllRoles = await Task.Run(() => rolesService.GetAllRolesAsync());
        StateHasChanged();
    }

    private void OpenAddRoleDialog()
    {
        AddRoleDialogOpen = true;
        StateHasChanged();
    }

    private async Task OnEditRoleDialogClose(bool accepted)
    {
        EditRoleDialogOpen = false;
        AllRoles = await Task.Run(() => rolesService.GetAllRolesAsync());
        StateHasChanged();
    }

    private void OpenEditRoleDialog(string idToEdit)
    {
        EditRoleDialogOpen = true;
        roleId = idToEdit;
        StateHasChanged();
    }

    private async Task OnDeleteRoleDialogClose(bool accepted)
    {
        if (accepted)
        {
            role = await Task.Run(() => rolesService.GetRoleAsync(roleId));
            await rolesService.DeleteRoleAsync(role);
        }

        DeleteRoleDialogOpen = false;
        AllRoles = await Task.Run(() => rolesService.GetAllRolesAsync());
        StateHasChanged();
    }

    private void OpenDeleteRoleDialog(string idToDelete)
    {
        DeleteRoleDialogOpen = true;
        roleId = idToDelete;
        StateHasChanged();
    }

    //access
    private async Task OnAddAccessDialogClose(bool accepted)
    {
        AddAccessDialogOpen = false;
        AllRolesAccesses = await Task.Run(() => rolesAccessService.GetAllRolesAccessesAsync());
        StateHasChanged();
    }

    private void OpenAddAccessDialog()
    {
        AddAccessDialogOpen = true;
        StateHasChanged();
    }

    private async Task OnEditAccessDialogClose(bool accepted)
    {
        EditAccessDialogOpen = false;
        AllRolesAccesses = await Task.Run(() => rolesAccessService.GetAllRolesAccessesAsync());
        StateHasChanged();
    }

    private void OpenEditAccessDialog(string idToEdit)
    {
        EditAccessDialogOpen = true;
        roleAccessId = idToEdit;
        StateHasChanged();
    }

    private async Task OnDeleteAccessDialogClose(bool accepted)
    {
        if (accepted)
        {
            rolesAccess = await Task.Run(() => rolesAccessService.GetRolesAccessAsync(roleAccessId));
            await rolesAccessService.DeleteRolesAccessAsync(rolesAccess);
        }

        DeleteAccessDialogOpen = false;
        AllRolesAccesses = await Task.Run(() => rolesAccessService.GetAllRolesAccessesAsync());
        StateHasChanged();
    }

    private void OpenDeleteAccessDialog(string idToDelete)
    {
        DeleteAccessDialogOpen = true;
        roleAccessId = idToDelete;
        StateHasChanged();
    }

    //user roles
    private async Task OnAddUserRolesDialogClose(bool accepted)
    {
        AddUserRolesDialogOpen = false;
        AllUsers = await Task.Run(() => userService.GetAllUsersAsync());
        StateHasChanged();
    }

    private void OpenAddUserRolesDialog(string idToAdd)
    {
        AddUserRolesDialogOpen = true;
        userId = idToAdd;
        StateHasChanged();
    }

    private async Task OnEditUserRolesDialogClose(bool accepted)
    {
        EditUserRolesDialogOpen = false;
        AllUsers = await Task.Run(() => userService.GetAllUsersAsync());
        StateHasChanged();
    }

    private void OpenEditUserRolesDialog(string idToEdit)
    {
        EditUserRolesDialogOpen = true;
        userId = idToEdit;
        StateHasChanged();
    }

    private async Task OnDeleteUserRolesDialogClose(bool accepted)
    {
        if (accepted)
        {
            IdentityUserRole = await Task.Run(() => userRolesService.GetUserRoleAsync(userId));
            await userRolesService.DeleteUserRoleAsync(IdentityUserRole);
        }

        DeleteUserRolesDialogOpen = false;
        AllUsers = await Task.Run(() => userService.GetAllUsersAsync());
        StateHasChanged();
    }

    private void OpenDeleteUserRolesDialog(string idToDelete)
    {
        DeleteUserRolesDialogOpen = true;
        userId = idToDelete;
        StateHasChanged();
    }

    //private void OpenSelectUserDialog()
    //{
    //    //body
    //}

    //accesses
    protected void ShowSelectedValues()
    {
        OutputValue = string.Join(", ", SelectedItems.ToArray());
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserRolesService userRolesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RolesAccessService rolesAccessService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RolesService rolesService { get; set; }
    }
}
#pragma warning restore 1591
