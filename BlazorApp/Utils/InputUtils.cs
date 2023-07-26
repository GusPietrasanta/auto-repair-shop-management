using System.Globalization;
using System.Text.RegularExpressions;

namespace BlazorApp.Utils;

public static class InputUtils
{
    public static string RemoveWhiteSpaceAndTitleCase(this string input)
    {
        // Remove exterior white space
        string output = input.Trim();
        
        // Remove extra white spaces
        output = Regex.Replace(output, @"\s+", " ");
        
        // Remove extra white spaces between dashes
        output = Regex.Replace(output, @" - ", "-");
        
        // Title case
        output = output.ToTitleCase();
        
        return output;
    }

    public static string TrimAndUpperCaseNumberPlate(this string input)
    {
        return Regex.Replace(input, "[^a-zA-Z0-9]", String.Empty).ToUpper();
    }
    
    private static string ToTitleCase(this string original)
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(original.ToLower());
    }
}