// Linq Methods


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Average: Calculates the numerical average of a collection.

        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        double average = numbers.Average();
        Console.WriteLine("Average: " + average);

        // Concat: It combines two collections.

        List<int> numbers1 = new List<int> { 1, 2, 3 };
        List<int> numbers2 = new List<int> { 4, 5, 6 };
        var combinedList = numbers1.Concat(numbers2);
        Console.WriteLine("Concatenated List: " + string.Join(", ", combinedList));

        // Distinct: Cleans the collection by removing duplicate elements.

        List<int> repeatedNumbers = new List<int> { 1, 2, 2, 3, 3, 3 };
        var distinctNumbers = repeatedNumbers.Distinct();
        Console.WriteLine("Distinct Numbers: " + string.Join(", ", distinctNumbers));

        // Skip: Skips the specified number of elements.

        List<int> skipList = new List<int> { 1, 2, 3, 4, 5 };
        var skippedList = skipList.Skip(2);
        Console.WriteLine("Skipped List: " + string.Join(", ", skippedList));

        // Union: It takes the combination of two collections

        List<int> nmbers1 = new List<int> { 1, 2, 3 };
        List<int> nmbers2 = new List<int> { 3, 4, 5 };
        var unionList = nmbers1.Union(nmbers2);
        Console.WriteLine("Union List: " + string.Join(", ", unionList));

        // Intersect: It takes the intersection of two collections 

        List<int> numbers3 = new List<int> { 1, 2, 3 };
        List<int> numbers4 = new List<int> { 3, 4, 5 };
        var intersectionList = numbers3.Intersect(numbers4);
        Console.WriteLine("Intersection List: " + string.Join(", ", intersectionList));

        // OrderBy: Sorts the collection according to a specified key

        List<int> numbrs = new List<int> { 5, 2, 8, 1, 3 };
        var sortedNumbers = numbrs.OrderBy(n => n);
        Console.WriteLine("Sorted Numbers: " + string.Join(", ", sortedNumbers));

        // Max: returns the max value in the collection

        List<int> numbers5 = new List<int> { 5, 2, 8, 1, 3 };
        int maxNumber = numbers5.Max();
        Console.WriteLine("Max Number: " + maxNumber);

        // Min: returns the min value in the collection

        List<int> numbers6 = new List<int> { 1, 2, 3, 4, 5 };
        int minNumber = numbers6.Min();
        Console.WriteLine("Min Number: " + minNumber);
    }
}

