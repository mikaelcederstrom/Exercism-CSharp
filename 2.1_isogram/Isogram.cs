using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var list = new List<string>();
        
        foreach (var item in word)
        {
            string l = item.ToString().ToLower();
            if (!list.Contains(l) || Regex.IsMatch(l, @"[ _-]+$"))
                list.Add(l);
            else 
                return false;
        }
        return true;
    }
}
