﻿namespace TriviaGame.Data.Extensions;

public static class ListExtensions
{
    // Fisher-Yates shuffle algorithm // Knuth shuffle algorithm
    public static List<T> Shuffle<T>(this List<T> list)
    {
        var random = new Random();
        var n = list.Count;
        while (n > 1)
        {
            n--;
            var k = random.Next(n + 1);
            var value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
        return list;
    }
}
