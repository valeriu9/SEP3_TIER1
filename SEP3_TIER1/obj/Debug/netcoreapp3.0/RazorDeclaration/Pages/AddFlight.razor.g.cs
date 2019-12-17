#pragma checksum "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\Pages\AddFlight.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41093891b1958951e856a28f42b96513bf1b7ec9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SEP3_TIER1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using SEP3_TIER1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\_Imports.razor"
using SEP3_TIER1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\Pages\AddFlight.razor"
using SEP3_TIER1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\Pages\AddFlight.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\Pages\AddFlight.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddFlight")]
    public class AddFlight : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\valera\Documents\GitHub\SEP3_TIER1\SEP3_TIER1\Pages\AddFlight.razor"
       
    private List<PlaneDTO> Datas = new List<PlaneDTO>();
    private PlaneDTO planeDTO = new PlaneDTO { CallSign = "", Model="", Company="",StartLocation="", EndLocation="", DepartureTime="", ArrivalTime="" };
    private List<string> companyList = new List<string>();
    private DateTime bindDepartureTime = new DateTime();
    private DateTime bindArrivalTime = new DateTime();
    private int result = 0;
    private string relationship="";

    protected async Task InvalidSubmit()
    {
         planeDTO = new PlaneDTO { CallSign = "", Model="", Company="",StartLocation="", EndLocation="", DepartureTime="", ArrivalTime="" };
        bindArrivalTime = new DateTime();
        bindDepartureTime = new DateTime();
    }
    protected List<string> GetCompanyList()
    {
        foreach(var data in Datas)
        {
            companyList.Add(data.Company);
        }
        return companyList;
    }

    protected PlaneDTO create()
    {

        planeDTO.DepartureTime = bindDepartureTime.ToString("dd/MM/yyyy HH:mm:ss");
        planeDTO.ArrivalTime = bindArrivalTime.ToString("dd/MM/yyyy HH:mm:ss");
        result = DateTime.Compare(bindArrivalTime, bindDepartureTime);

        if (result < 0)
            relationship = "Cannot add an Arrival Time erlier than Departure Time ";
        else if (result == 0)
        {
            relationship = "Arrival Time and Departure Time are the same";
            return null;
        }
        planeDTO.FlightNumber = getFlightPlanIndex();
        return planeDTO;
    }
    protected override async Task OnInitializedAsync()
    {
        Datas = await Http.GetJsonAsync<List<PlaneDTO>>("https://localhost:44397/planes");
        GetCompanyList();
    }

    private async Task postRequest()
    {

        await Http.PostJsonAsync("https://localhost:44397/FlightPlans", create());
        planeDTO = new PlaneDTO{ CallSign = "", Model="", Company="",StartLocation="", EndLocation="", DepartureTime="", ArrivalTime="" };
        bindArrivalTime = new DateTime();
        bindDepartureTime = new DateTime();
    }

    protected int getFlightPlanIndex()
    {
        int i = 0;
        foreach (PlaneDTO flightPlan in Datas.OrderBy(flightPlan => flightPlan.FlightNumber))
        {
            if (i == flightPlan.FlightNumber)
            {
                i++;
            }
            else
            {
                return i;
            }
        }
        return Datas.Max(flightPlan => flightPlan.FlightNumber) + 1;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
