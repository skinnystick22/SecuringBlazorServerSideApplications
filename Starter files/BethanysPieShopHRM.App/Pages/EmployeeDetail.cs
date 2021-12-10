using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.ComponentsLibrary.Map;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.App.Pages;

public partial class EmployeeDetail
{
    [Inject]
    public IEmployeeDataService EmployeeDataService { get; set; }

    public Employee Employee { get; set; } = new();

    [Parameter]
    public string EmployeeId { get; set; }


    public List<Marker> MapMarkers { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));

        MapMarkers = new List<Marker>
        {
            new() {Description = $"{Employee.FirstName} {Employee.LastName}",  ShowPopup = false, X = Employee.Longitude, Y = Employee.Latitude}
        };
    }
}