using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string s = Console.ReadLine();
            string even = "";
            string odd = "";

            for (int j = 0; j < s.Length; j++)
            {
                if (j % 2 == 0)
                    even += s[j];
                else
                    odd += s[j];
            }

            Console.WriteLine($"{even} {odd}");
        }
    }
}
