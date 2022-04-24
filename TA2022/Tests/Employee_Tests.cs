using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA2022.pages;
using TA2022.Utilities;

namespace TA2022.Tests

{
    [TestFixture]
    [Parallelizable]
    internal class Employee_Tests:CommonDriver
            {
        
        [Test, Order(1)]
        public void CreateEmployee_Test()
        {
            // Home page object initailazion and definition

            Homepage HomePageobj = new Homepage();
            HomePageobj.GOtoEmployeePage(mydriver);

            // Employee page object initailazion and definition

            EmployeePage EmployeePageobj = new EmployeePage();
            EmployeePageobj.CreateEmployee(mydriver);

        }

        [Test, Order(2)]

        public void EditEmployee_Test()
        {
            // Home page object initailazion and definition

            Homepage HomePageobj = new Homepage();
            HomePageobj.GOtoEmployeePage(mydriver);
            // Edit Employee

            EmployeePage EmployeePageobj = new EmployeePage();
            EmployeePageobj.EditEmployee(mydriver);

        }
        [Test, Order(3)]
        public void DeleteEmployee_Test()
        {
            // Home page object initailazion and definition

            Homepage HomePageobj = new Homepage();
            HomePageobj.GOtoEmployeePage(mydriver);

            // Delete Employee

            EmployeePage EmployeePageobj = new EmployeePage();
            EmployeePageobj.DeleteEmployee(mydriver);


        }
        
    }
}
    

