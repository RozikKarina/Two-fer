using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static Dictionary<char, int> Count(string dnaSequence)
    {
        // Ініціалізуємо словник з нулями для кожного нуклеотиду
        var nucleotideCounts = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        // Перебираємо кожен символ у послідовності ДНК
        foreach (var nucleotide in dnaSequence)
        {
            if (!nucleotideCounts.ContainsKey(nucleotide))
            {
                // Якщо знайдений символ не є нуклеотидом, кидаємо ArgumentException
                throw new ArgumentException("Invalid nucleotide found in DNA sequence.");
            }

            // Збільшуємо лічильник відповідного нуклеотиду
            nucleotideCounts[nucleotide]++;
        }

        return nucleotideCounts;
    }
}