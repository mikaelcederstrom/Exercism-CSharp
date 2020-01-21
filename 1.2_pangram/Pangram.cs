using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        Dictionary<char, char> dict = new Dictionary<char, char>();
        foreach (var c in input)
        {
            if (Regex.IsMatch(c.ToString(), "[a-z]", RegexOptions.IgnoreCase))
            {
                char lowerChar = ToLowerCase(c);
                if (!dict.ContainsKey(lowerChar))
                    dict.Add(c, c);
            }
        }

        if (dict.Count == 26)
            return true;
        else
            return false;        
    }

    private static char ToLowerCase(char input)
    {
        return Convert.ToChar(Convert.ToString(input).ToLower());
    }
}
