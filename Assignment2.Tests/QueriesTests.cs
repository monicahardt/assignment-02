namespace Assignment2.Tests;

public class QueriesTests
{
    

    /*[Theory]
    [InlineData("Harry Potter", "Harry Potter", 1997, "J.K.Rowling")]
    [InlineData("Hermione Granger", "Harry Potter", 1997, "J.K.Rowling")]
    [InlineData("Ron Weasly", "Harry Potter", 1997, "J.K.Rowling")]
    [InlineData("Cedric Diggory", "Harry Potter", 1997, "J.K.Rowling")]
    [InlineData("Profesor Dumbledor", "Harry Potter", 1997, "J.K.Rowling")]
    public void Spot_check_wizards(string name, string medium, int year, string creator)
    {
        var wizards = WizardCollection.Create();

        Assert.Contains(wizards, w => w == new Wizard(name, medium, year, creator));
    }*/

    [Theory]
    [InlineData("Harry Potter")]
    [InlineData("Hermione Granger")]
    [InlineData("Ron Weasly")]
    [InlineData("Cedric Diggory")]
    [InlineData("Profesor Dumbledor")]
    public void Spot_check_Rowling(string name)
    {
        var wizards = WizardCollection.Create();
        var result = Queries.FindRowlings(wizards);

        Assert.Contains(result, w => w == name);
    }

    [Theory]
    [InlineData("Harry Potter")]
    [InlineData("Hermione Granger")]
    [InlineData("Ron Weasly")]
    [InlineData("Cedric Diggory")]
    [InlineData("Profesor Dumbledor")]
    public void Spot_check_RowlingLINQ(string name)
    {
        var wizards = WizardCollection.Create();
        var result = Queries.FindRowlingsLINQ(wizards);

        Assert.Contains(result, w => w == name);
    }
    
    [Fact]
    public void Spot_check__the_first_Darth()
    {
        var wizards = WizardCollection.Create();

        var result = Queries.FindTheFirstDarth(wizards);

        Assert.Equal(1977,result);
    }

      [Fact]
    public void Spot_check__the_first_Darth_LINQ()
    {
        var wizards = WizardCollection.Create();

        var result = Queries.FindTheFirstDarthLINQ(wizards);

        Assert.Equal(1977,result);
    }

    [Theory]
    [InlineData("Harry Potter", 1997)]
    [InlineData("Hermione Granger", 1997)]
    [InlineData("Ron Weasly", 1997)]
    [InlineData("Cedric Diggory", 1997)]
    [InlineData("Profesor Dumbledor",1997)]
    public void Unique_wizards_harry_potter(string name, int year)
    {
        var wizards = WizardCollection.Create();
        var result = Queries.UniqueWizards(wizards);

        Assert.Contains(result, w => w == (name,year));
    }

    [Theory]
    [InlineData("Harry Potter", 1997)]
    [InlineData("Hermione Granger", 1997)]
    [InlineData("Ron Weasly", 1997)]
    [InlineData("Cedric Diggory", 1997)]
    [InlineData("Profesor Dumbledor",1997)]
    public void Unique_wizards_harry_potterLINQ(string name, int year)
    {
        var wizards = WizardCollection.Create();
        var result = Queries.UniqueWizardsLINQ(wizards);

        Assert.Contains(result, w => w == (name,year));
    }

    //return en liste af wizard, sorteret på creator z-a name a-z
    [Fact]
    public void listOfWizard()
    {
        var wizards = WizardCollection.Create();

        var result = Queries.ListOfWizards(wizards);

        Assert.Equal(new List<string>{"Katrine", "Sauron", "Cedric Diggory", "Harry Potter", "Hermione Granger", "Profesor Dumbledor", "Ron Weasly", "Darth Vader", "Monica", "Tobias"},result);
    }

    [Fact]
    public void listOfWizardLINQ()
    {
        var wizards = WizardCollection.Create();

        var result = Queries.ListOfWizardsLINQ(wizards);

        Assert.Equal(new List<string>{"Katrine", "Sauron", "Cedric Diggory", "Harry Potter", "Hermione Granger", "Profesor Dumbledor", "Ron Weasly", "Darth Vader", "Monica", "Tobias"},result);
    }

    





    
}
