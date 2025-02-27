using EmployeeManagement.DataAccess.Entities;
using Xunit;

namespace EmployeeManagement.Test;

public class CourseTest
{
    [Fact]
    public void ConstructCourse_CourseConstructor_IsNewMustBeTrue()
    {
        //arrange
        //nothing to arrange
        
        //act
        var course = new Course("disaster management 101");

        //assert
        Assert.True(course.IsNew);
    }
}