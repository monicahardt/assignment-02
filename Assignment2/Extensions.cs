namespace Assignment2;

using System.Text.RegularExpressions;

public static class Extensions
{
    public static bool isSecure(this Uri uri){

        string s =  uri.AbsoluteUri;
        return s.StartsWith("https");
    }

    public static int WordCount(this string s){

        string[] result = Regex.Split(s, @"\P{L}+");
        return result.Where(n => n != "").Count();
    }
}
