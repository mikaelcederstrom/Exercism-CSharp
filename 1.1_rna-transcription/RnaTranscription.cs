using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        string toReturn = "";
        foreach (var letter in nucleotide)
        {
            switch (letter)
            {
                case 'G':
                    toReturn = toReturn + "C";
                    break;
                case 'C':
                    toReturn = toReturn + "G";
                    break;
                case 'T':
                    toReturn = toReturn + "A";
                    break;
                case 'A':
                    toReturn = toReturn + "U";
                    break;
            }
        }
        return toReturn;
    }
}