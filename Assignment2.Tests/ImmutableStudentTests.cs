namespace Assignment2.Tests;
using Assignment2;

public class ImmutableStudentTests
{
    [Fact]
    public void toString_test_immutable_student_builtIn()
    {
        var immutableStudent = new ImmutableStudent(1, "Monica", "Hardt", Status.Dropout, new DateTime(2022,09, 16), new DateTime(2022,09,18), 
        new DateTime(2022,09,19));

        var immutableStudentToString =  immutableStudent.ToString();

        Assert.Equal("ImmutableStudent { Id = 1, GivenName = Monica, SurName = Hardt, Status = Dropout, StartDate = 16/09/2022 00:00:00, EndDate = 18/09/2022 00:00:00, GraduationDate = 19/09/2022 00:00:00 }", immutableStudentToString);
    }

    [Fact]
    public void ImmutableStudent_test_of_builtIn_comparator_should_be_true()
    {

        var immutableStudent0 = new ImmutableStudent(1, "Monica", "Hardt", Status.Dropout, new DateTime(2022,09, 16), new DateTime(2022,09,18), 
        new DateTime(2022,09,19));

        var immutableStudent1 = new ImmutableStudent(1, "Monica", "Hardt", Status.Dropout, new DateTime(2022,09, 16), new DateTime(2022,09,18), 
        new DateTime(2022,09,19));

        bool result =  immutableStudent0 == immutableStudent1;

        Assert.Equal(true, result);
    
    }

     [Fact]
    public void ImmutableStudent_test_of_builtIn_comparator_should_be_false()
    {

        var immutableStudent0 = new ImmutableStudent(1, "Tobias", "Skov", Status.Dropout, new DateTime(2022,09, 16), new DateTime(2022,09,18), 
        new DateTime(2022,09,19));

        var immutableStudent1 = new ImmutableStudent(1, "Monica", "Hardt", Status.Dropout, new DateTime(2022,09, 16), new DateTime(2022,09,18), 
        new DateTime(2022,09,19));

        bool result =  immutableStudent0 == immutableStudent1;

        Assert.Equal(false, result);
    
    }

    
}
