namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void isSecure_returns_true_when_using_hypertext_transfor_true()
    {
        var link = new Uri ("https://itu.dk/");

        bool isSecure = link.isSecure();

        Assert.Equal(true, isSecure);
    }

    [Fact]
    public void isSecure_returns_false_when_not_using_hypertext_transfor_false()
    {
        var link = new Uri ("http://monicahardt.dk/");

        bool isSecure = link.isSecure();

        Assert.Equal(false, isSecure);
    }

    [Fact]
    public void WordCount_should_return_only_the_words_in_given_string()
    {
        String s = "hej med jer vi programmere C# opgave 2";
    
        // When
        int result = s.WordCount();
        
        // Then
        Assert.Equal(7,result);
    }

    [Fact]
    public void WordCount_should_return_only_the_words_in_given_string_finds_no_words()
    {
        String s = "#€&&/&%€##€%&/()=  (&%%# ?)";
    
        // When
        int result = s.WordCount();
        
        // Then
        Assert.Equal(0,result);
    }
}
