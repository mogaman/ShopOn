#pragma checksum "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Admin\ProductPages\ProductForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd733e128c0db111d81e1737c5e9e8dd079f732d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.Admin.ProductPages
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
#line 1 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Admin\ProductPages\ProductForm.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    public partial class ProductForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Admin\ProductPages\ProductForm.razor"
                  p

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Admin\ProductPages\ProductForm.razor"
                                     OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "table");
                __builder2.OpenElement(5, "tr");
                __builder2.AddContent(6, "Name: ");
                __builder2.OpenElement(7, "input");
                __builder2.AddAttribute(8, "type", "text");
                __builder2.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Admin\ProductPages\ProductForm.razor"
                                             p.productName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => p.productName = __value, p.productName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n\r\n        ");
                __builder2.OpenElement(12, "tr");
                __builder2.AddContent(13, "Description: ");
                __builder2.OpenElement(14, "textarea");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "style", "width: 390px; height: 90px");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Admin\ProductPages\ProductForm.razor"
                                                                                          p.productDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => p.productDescription = __value, p.productDescription));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\r\n        ");
                __builder2.OpenElement(20, "tr");
                __builder2.AddContent(21, "Price: $");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "type", "number");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Admin\ProductPages\ProductForm.razor"
                                                 p.productPrice

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => p.productPrice = __value, p.productPrice, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n        ");
                __builder2.OpenElement(27, "tr");
                __builder2.AddContent(28, "Quantity: ");
                __builder2.OpenElement(29, "input");
                __builder2.AddAttribute(30, "type", "number");
                __builder2.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Admin\ProductPages\ProductForm.razor"
                                                   p.productQuantity

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => p.productQuantity = __value, p.productQuantity, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\r\n    ");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "type", "submit");
                __builder2.AddAttribute(36, "class", "btn btn-success");
                __builder2.AddAttribute(37, "value", 
#nullable restore
#line 14 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Admin\ProductPages\ProductForm.razor"
                                                         ButtonText

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\ryann\Documents\FYP\ShopOnBlazorWebAssembly\BlazorApp1\BlazorApp1\Pages\Admin\ProductPages\ProductForm.razor"
       
    [Parameter] public Product p { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public string ButtonText { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591