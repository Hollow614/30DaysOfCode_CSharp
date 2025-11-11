using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var phoneBook = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string[] entry = Console.ReadLine().Split(' ');
            string name = entry[0];
            string phoneNumber = entry[1];
            phoneBook[name] = phoneNumber;
        }

        string query;
        while ((query = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(query))
            {
                Console.WriteLine($"{query}={phoneBook[query]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
