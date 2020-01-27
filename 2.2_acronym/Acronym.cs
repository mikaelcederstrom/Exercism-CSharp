using System;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        phrase = phrase.ToUpper();
        phrase = phrase.Trim('\'');
        string[] words = phrase.Split(' ', '-', '_');        
        string acronym = "";

        foreach (var word in words)
        {
            if (Regex.IsMatch(word, @"[A-Z]"))
                acronym = acronym + word[0];
        }
        return acronym;
    }
}