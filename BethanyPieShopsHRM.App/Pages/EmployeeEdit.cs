﻿using BethanyPieShopsHRM.App.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShopsHRM.App.Pages
{
    public partial class EmployeeEdit
    {
        [Inject]
        public ICountryDataService CountryDataService { get; set; }

        [Inject]
        public IJobCategoryDataService JobCategoryDataService { get; set; }


        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

      
     
        [Parameter]
        public string EmployeeId { get; set; }
       

        public Employee Employee { get; set; } = new Employee();

        public List<Country> Countries { get; set; }=new List<Country>();
        public List<JobCategory> JobCategory { get; set; } = new List<JobCategory>();
        protected string CountryId=string.Empty;
        protected string JobCategoryId=string.Empty;

        protected override async Task OnInitializedAsync()
        {
            Countries= (await CountryDataService.GetAllCountries()).ToList();
            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
            JobCategory=(await JobCategoryDataService.GetAllJobCategories()).ToList();
            CountryId=Employee.CountryId.ToString();
            JobCategoryId=Employee.JobCategoryId.ToString();
        }

        
    }
}