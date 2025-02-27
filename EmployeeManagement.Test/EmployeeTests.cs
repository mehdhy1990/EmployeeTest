using EmployeeManagement.DataAccess.Entities;
using Xunit;

namespace EmployeeManagement.Test;

public class EmployeeTests
{
    [Fact]
    public void EmployeeFullNamePropertyGetter_InputFirstAndLastName_FullNameIsConcatonated()
    {
        //arrange
        var employee = new InternalEmployee("John", "Doe",0,2500,false,1);
        
        
        //act
        employee.FirstName = "mehdi";
        employee.LastName = "Heidari";
        
        //assert
        Assert.Equal("Mehdi Heidari",employee.FullName,ignoreCase:true);
    } 
    [Fact]
    public void EmployeeFullNamePropertyGetter_InputFirstAndLastName_FullNameIStartsWithFirstName()
    {
        //arrange
        var employee = new InternalEmployee("John", "Doe",0,2500,false,1);
        
        
        //act
        employee.FirstName = "mehdi";
        employee.LastName = "Heidari";
        
        //assert
        Assert.StartsWith(employee.FirstName, employee.FullName,StringComparison.InvariantCulture);
    }  
    [Fact]
    public void EmployeeFullNamePropertyGetter_InputFirstAndLastName_FullNameContainName()
    {
        //arrange
        var employee = new InternalEmployee("John", "Doe",0,2500,false,1);
        
        
        //act
        employee.FirstName = "mehdi";
        employee.LastName = "heidari";
        
        //assert
        Assert.Contains("i hei", employee.FullName,StringComparison.InvariantCulture);
    }
}