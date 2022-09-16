namespace Assignment2.Tests;
using Assignment2;

public class StudentTests
{
    [Fact]
    public void toString_test()
    {
        var student = new Student {Id = 1, GivenName = "Monica", SurName = "Hardt", Status = Status.Dropout, 
        StartDate = new DateTime(2022,09, 16), EndDate = new DateTime(2022,09,18), 
        GraduationDate = new DateTime(2022,09,19)};

        var studentToString =  student.ToString();

        Assert.Equal("Id: 1 GivenName: Monica SurName: Hardt Status: Dropout StartDate: 2022-09-16 EndDate: 2022-09-18 GraduationDate: 2022-09-19", studentToString);


    }
}
