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

using System;

class Result
{
    public static int factorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        else
        {
            return n * factorial(n - 1);
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int result = Result.factorial(n);
        Console.WriteLine(result);
    }
}

