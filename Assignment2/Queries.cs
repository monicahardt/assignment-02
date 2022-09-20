namespace Assignment2;

public class Queries
{
    public static IEnumerable<string> FindRowlings(WizardCollection wizards)
    {
       return wizards.Where(c => c.Creator == "J.K.Rowling").Select(c => c.Name);
    }

    public static IEnumerable<string> FindRowlingsLINQ(WizardCollection wizards)
    {
       return from w in wizards
              where w.Creator == "J.K.Rowling"
              select w.Name; 
    }

     public static int FindTheFirstDarth(WizardCollection wizards)
    {
       return (int) wizards.Where(n => n.Name.StartsWith("Darth")).OrderBy(n => n.Year).First().Year!;
    }

     public static int FindTheFirstDarthLINQ(WizardCollection wizards)
    {
       var darthWizards = from w in wizards
             where w.Name.StartsWith("Darth")
             orderby w.Year
             select  w.Year;
        return (int) darthWizards.First()!;
    }

    public static IEnumerable<(string,int?)> UniqueWizards(WizardCollection wizards)
    {
        return wizards.Where(w => w.Medium == "Harry Potter").Select(w => (w.Name, w.Year));
    }

    public static IEnumerable<(string,int?)> UniqueWizardsLINQ(WizardCollection wizards)
    {
        return from w in wizards
               where w.Medium == "Harry Potter"
               select (w.Name, w.Year);
    }

    public static IEnumerable<string> ListOfWizards(WizardCollection wizards)
    {
        return wizards.OrderByDescending(w => w.Creator).ThenBy(w => w.Name).Select(w => w.Name);
   
    }

    public static IEnumerable<string> ListOfWizardsLINQ(WizardCollection wizards)
    {
        return from w in wizards
               orderby w.Creator descending, w.Name
               group w.Name by w.Creator into Creators
               from c in Creators
               select c;
    }
}
