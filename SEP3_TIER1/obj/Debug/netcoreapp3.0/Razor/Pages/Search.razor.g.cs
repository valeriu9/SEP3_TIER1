#pragma checksum "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c6f178c55532cd27fadce55e565ebf86d654bd7"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP3_TIER1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\_Imports.razor"
using SEP3_TIER1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\_Imports.razor"
using SEP3_TIER1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
using SEP3_TIER1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/search")]
    public class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-wrapper");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "wrapper wrapper--w1226");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card card-5 mt-2");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.AddMarkupContent(15, "<div class=\"col-4\">\r\n                        <label type=\"text\" class=\"label \">Search for a destination</label>\r\n                    </div>\r\n                    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-6");
            __builder.AddMarkupContent(18, "\r\n\r\n                        ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "class", "input--style-1 input-group");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 16 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
                                                                                                                                                SearchFlight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "placeholder", "City, Region or Airport");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
                                                                                           searchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchTerm = __value, searchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-2");
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn  btn-personalized");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
                                                                        SearchFlight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "wrapper wrapper--w1226");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "table");
            __builder.AddAttribute(45, "class", "table table-striped textedit");
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.AddMarkupContent(47, @"<thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Flight</th>
                    <th scope=""col"">Airplane</th>
                    <th scope=""col"">Airline</th>
                    <th scope=""col"">Origin</th>
                    <th scope=""col"">Destination</th>
                    <th scope=""col"">Delay</th>
                    <th scope=""col"">Departure time</th>
                    <th scope=""col"">Arrival time</th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(48, "tbody");
            __builder.AddMarkupContent(49, "\r\n\r\n");
#nullable restore
#line 44 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
                  
                    int id = 1;
                    foreach (var data in AirportDatas)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                        ");
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "\r\n                            ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 49 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
                                 id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                            ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 50 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
                                 data.CallSign

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                            ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 51 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
                                 data.Model

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                            ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 52 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
                                 data.Company

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                            ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 53 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
                                 data.StartLocation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                            ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 54 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
                                 data.EndLocation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                            ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 55 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
                                 data.Delay

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                            ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 56 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
                                 data.DepartureTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                            ");
            __builder.OpenElement(77, "td");
            __builder.AddContent(78, 
#nullable restore
#line 57 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
                                 data.ArrivalTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
#nullable restore
#line 59 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
                        id++;
                    }
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "D:\SEP3_TIER1_Val\SEP3C-_TIER1_WebApp\SEP3_TIER1\Pages\Search.razor"
       
    private List<PlaneDTO> datas = new List<PlaneDTO>();
    private IList<PlaneDTO> AirportDatas = new List<PlaneDTO>();

    private string searchTerm = "";

    protected override async Task OnInitializedAsync()
    {
        datas = await Http.GetJsonAsync<List<PlaneDTO>>("https://localhost:44397/FlightPlans");
    }

    private void SearchFlight()
    {
            AirportDatas.Clear();
         try
        {
            foreach (var data in datas)
            {
                if ((data.StartLocation.ToLower().Equals(searchTerm.ToLower()))
                    || (data.EndLocation.ToLower().Equals(searchTerm.ToLower())))
                {
                    AirportDatas.Add(data);
                }
            }
        }
        catch (Exception e)
        {
                
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
