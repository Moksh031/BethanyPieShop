using BethanyPieShopsHRM.App.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using BethanyPieShopsHRM.App.Services;
namespace BethanyPieShopsHRM.App.Pages{
    public partial class EmployeeOverview
    {
        public IEnumerable<Employee> Employees { get; set; }
        private List<Country> Countries { get; set; }
        private List<JobCategory> JobCategories { get; set; }
         
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        protected  override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }
      
        
    }
}