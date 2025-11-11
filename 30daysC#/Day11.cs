using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int[,] arr = new int[6, 6];

        for (int i = 0; i < 6; i++)
        {
            string[] parts = Console.ReadLine().Split(' ');
            for (int j = 0; j < 6; j++)
            {
                arr[i, j] = int.Parse(parts[j]);
            }
        }

        int maxSum = -63;

        for (int i = 0; i <= 3; i++)
        {
            for (int j = 0; j <= 3; j++)
            {
                int sum = 0;
                sum += arr[i, j];
                sum += arr[i, j + 1];
                sum += arr[i, j + 2];
                sum += arr[i + 1, j + 1];
                sum += arr[i + 2, j];
                sum += arr[i + 2, j + 1];
                sum += arr[i + 2, j + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }

        Console.WriteLine(maxSum);
    }
}
