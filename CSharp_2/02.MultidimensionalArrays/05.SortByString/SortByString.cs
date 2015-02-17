using System;
//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

class SortByString
{
    static void Main()
    {
        string[] arrey = { "a", "b", "abc", "birichka", "bac", "c", "ab", "kiufte", "kor", "aa" };
        Array.Sort(arrey, (x, y) => x.Length.CompareTo(y.Length));
        Console.WriteLine(string.Join(", ", arrey));
    }
}

