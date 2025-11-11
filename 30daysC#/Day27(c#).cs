using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int minimum_index(List<int> seq)
    {
        if (seq.Count == 0)
        {
            throw new ArgumentException("Cannot get the minimum value index from an empty sequence");
        }

        int minIdx = 0;
        for (int i = 1; i < seq.Count; i++)
        {
            if (seq[i] < seq[minIdx])
            {
                minIdx = i;
            }
        }

        return minIdx;
    }

    class TestDataEmptyArray
    {
        public static List<int> GetArray()
        {
            return new List<int>();
        }
    }

    class TestDataUniqueValues
    {
        public static List<int> GetArray()
        {
            return new List<int> { 5, 3, 8, 2 };
        }

        public static int GetExpectedResult()
        {
            List<int> v = GetArray();
            return minimum_index(v);
        }
    }

    class TestDataExactlyTwoDifferentMinimums
    {
        public static List<int> GetArray()
        {
            return new List<int> { 1, 2, 1, 3 };
        }

        public static int GetExpectedResult()
        {
            return 0;
        }
    }

    static void TestWithEmptyArray()
    {
        try
        {
            List<int> seq = TestDataEmptyArray.GetArray();
            int result = minimum_index(seq);
        }
        catch (ArgumentException)
        {
            return;
        }

        throw new Exception("Exception was not thrown for empty array");
    }

    static void TestWithUniqueValues()
    {
        List<int> seq = TestDataUniqueValues.GetArray();
        if (seq.Count < 2)
        {
            throw new Exception("Array has less than 2 elements");
        }

        if (seq.Distinct().Count() != seq.Count)
        {
            throw new Exception("Array elements are not unique");
        }

        int expected = TestDataUniqueValues.GetExpectedResult();
        int result = minimum_index(seq);

        if (result != expected)
        {
            throw new Exception("Result is different from expected");
        }
    }

    static void TestWithExactlyTwoDifferentMinimums()
    {
        List<int> seq = TestDataExactlyTwoDifferentMinimums.GetArray();
        if (seq.Count < 2)
        {
            throw new Exception("Array has less than 2 elements");
        }

        List<int> tmp = seq.OrderBy(x => x).ToList();
        if (!(tmp[0] == tmp[1] && (tmp.Count == 2 || tmp[1] < tmp[2])))
        {
            throw new Exception("Array does not have exactly two minimums");
        }

        int expected = TestDataExactlyTwoDifferentMinimums.GetExpectedResult();
        int result = minimum_index(seq);

        if (result != expected)
        {
            throw new Exception("Result is different from expected");
        }
    }

    static void Main(string[] args)
    {
        TestWithEmptyArray();
        TestWithUniqueValues();
        TestWithExactlyTwoDifferentMinimums();
        Console.WriteLine("OK");
    }
}
