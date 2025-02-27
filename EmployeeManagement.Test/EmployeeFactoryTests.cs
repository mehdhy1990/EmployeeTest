using EmployeeManagement.Business;
using EmployeeManagement.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmployeeManagement.Test
{
    public class EmployeeFactoryTests
    {
        [Fact]
        public void CreateEmployee_ConstructInternalEmployee_SalaryMustBe2500()
        {
            var employeeFactory = new EmployeeFactory();

            var employee = (InternalEmployee)employeeFactory
                .CreateEmployee("Kevin", "Dockx");

            Assert.Equal(2500, employee.Salary);
        }

        [Fact]
        public void CreateEmployee_ConstructInternalEmployee_SalaryMustBetween2500and3000()
        {
            var employeeFactory = new EmployeeFactory();

            var employee = (InternalEmployee)employeeFactory
                .CreateEmployee("Kevin", "Dockx");

            Assert.True(employee.Salary is >= 2500 and < 3000,"salary must be between 2500 and 3000");
        }
        [Fact]
        public void CreateEmployee_ConstructInternalEmployee_SalaryMustBe2500_PrecisionTest()
        {
            var employeeFactory = new EmployeeFactory();

            var employee = (InternalEmployee)employeeFactory
                .CreateEmployee("Kevin", "Dockx");
           employee.Salary = 2500.125m;

            Assert.Equal(2500, employee.Salary,0);
        }
    }
    
    

}