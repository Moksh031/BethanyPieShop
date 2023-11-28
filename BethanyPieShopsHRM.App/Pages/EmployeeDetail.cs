using BethanyPieShopsHRM.App.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanyPieShopsHRM.App.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeId { get; set; }

        public Employee Employee { get; set; }=new Employee();

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        protected  override async Task OnInitializedAsync()
        {

            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));


        }
        public IEnumerable<Employee> Employees { get; set; }
        private List<Country> Countries { get; set; }
        private List<JobCategory> JobCategories { get; set; }
       
    }
}