#pragma checksum "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Order Process\CreateCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5de57110d9e9ba2ba1571bab20180df86f295ae6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.Order_Process
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Order Process\CreateCard.razor"
using BlazorApp1.Data.CreditCard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Order Process\CreateCard.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addcreditcard")]
    public partial class CreateCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Credit Card Info</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Order Process\CreateCard.razor"
                  card

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Order Process\CreateCard.razor"
                                        CardInsert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "table");
                __builder2.OpenElement(6, "tr");
                __builder2.AddMarkupContent(7, "<td>Card Number:</td>\r\n            ");
                __builder2.OpenElement(8, "td");
                __builder2.OpenElement(9, "input");
                __builder2.AddAttribute(10, "type", "number");
                __builder2.AddAttribute(11, "required");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Order Process\CreateCard.razor"
                                            card.cardNumber

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => card.cardNumber = __value, card.cardNumber, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "tr");
                __builder2.AddMarkupContent(16, "<td>Name on Card:</td>\r\n            ");
                __builder2.OpenElement(17, "td");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "text");
                __builder2.AddAttribute(20, "required");
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Order Process\CreateCard.razor"
                                          card.cardName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => card.cardName = __value, card.cardName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenElement(24, "tr");
                __builder2.AddMarkupContent(25, "<td>Expiration Date:</td>\r\n            ");
                __builder2.OpenElement(26, "td");
                __builder2.OpenElement(27, "input");
                __builder2.AddAttribute(28, "type", "number");
                __builder2.AddAttribute(29, "min", "1");
                __builder2.AddAttribute(30, "max", "12");
                __builder2.AddAttribute(31, "placeholder", "Month");
                __builder2.AddAttribute(32, "required");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Order Process\CreateCard.razor"
                                            card.cardExpireMonth

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => card.cardExpireMonth = __value, card.cardExpireMonth, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n            /\r\n            ");
                __builder2.OpenElement(36, "td");
                __builder2.OpenElement(37, "input");
                __builder2.AddAttribute(38, "type", "number");
                __builder2.AddAttribute(39, "min", "20");
                __builder2.AddAttribute(40, "max", "99");
                __builder2.AddAttribute(41, "placeholder", "Year");
                __builder2.AddAttribute(42, "required");
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Order Process\CreateCard.razor"
                                            card.cardExpireYear

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => card.cardExpireYear = __value, card.cardExpireYear, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.OpenElement(46, "tr");
                __builder2.AddMarkupContent(47, "<td>Security Code:</td>\r\n            ");
                __builder2.OpenElement(48, "td");
                __builder2.OpenElement(49, "input");
                __builder2.AddAttribute(50, "type", "number");
                __builder2.AddAttribute(51, "required");
                __builder2.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Order Process\CreateCard.razor"
                                            card.cardCVV

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => card.cardCVV = __value, card.cardCVV, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.AddMarkupContent(55, "<tr><td colspan=\"2\" style=\"text-align:center\"><input type=\"submit\" value=\"Register\"></td></tr>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Order Process\CreateCard.razor"
       
    CreditCard card = new CreditCard();
    //int id;

    ////Method gets stored customerID
    //protected override async Task OnInitializedAsync()
    //{
    //    id = await sessionStorage.GetItemAsync<int>("customer");
    //}

    protected async Task CardInsert()
    {
        card.userID = await sessionStorage.GetItemAsync<int>("user");
        await CardService.CardInsert(card);
        await js.InvokeVoidAsync("alert", $"Credit Card Added!");
        nav.NavigateTo("/choosecard");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICreditCardService CardService { get; set; }
    }
}
#pragma warning restore 1591
