using System;
using System.Collections.Generic;
using System.IO;
class Solution {
     static void Main(String[] args) {
        int T = int.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++) {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n) ? "Prime" : "Not prime");
        }
    }

    static bool IsPrime(long n) {
        if (n < 2) return false;
        if (n == 2 || n == 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;

        
        for (long i = 5; i * i <= n; i += 6) {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }
        return true;
    }
}
