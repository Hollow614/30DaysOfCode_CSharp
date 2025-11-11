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
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> names = new List<string>();
        Regex gmailRegex = new Regex("@gmail\\.com$");

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string firstName = firstMultipleInput[0];
            string emailID = firstMultipleInput[1];

            if (gmailRegex.IsMatch(emailID))
            {
                names.Add(firstName);
            }
        }

        names.Sort();

        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i]);
        }
    }
}
