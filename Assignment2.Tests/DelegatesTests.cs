namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void ReverseStringTest()
    {

        using var writer = new StringWriter();
        Console.SetOut(writer);

        var result = (string s) =>  s.Reverse().ToList().ForEach(Console.Write);
        result("hej");

        var output = writer.GetStringBuilder().ToString().TrimEnd();

        Assert.Equal("jeh", output);

    }

    [Fact]
    public void TakeToDoublesReturnProduct()
    {
        var input = 4.4;
        var result = (double x, double y) => y*x;
        Assert.Equal(19.360000000000003, result(input, input));
    }


    [Fact]
    public void NumberEqualToString()
    {
        var inputString = " 0042";
        var inputInt = 42;

        var result = (string s, int i) => int.Parse(s) == i;
        Assert.Equal(true, result(inputString, inputInt));
    }
}
