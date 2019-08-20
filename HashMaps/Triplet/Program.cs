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

    // Complete the countTriplets function below.
    static long countTriplets(List<long> arr, long r)
    {
        var potential = new Dictionary<long, long>();
        var counter = new Dictionary<long, long>();
        long count = 0;
        foreach (var a in arr)
        {
            
            long key = a / r;
            long reminder = a % r;

            if (counter.ContainsKey(key) && reminder == 0)
            {
                count += counter[key];
            }

            if (potential.ContainsKey(key) && reminder == 0)
            {
                long c = potential[key];
                if (counter.ContainsKey(a)) counter[a] = counter[a] + c;
                else counter.Add(a,c);
            }

            if (potential.ContainsKey(a))  potential[a] = potential[a]  + 1;
            else potential.Add(a, 1);// Every number can be the start of a triplet.
        }
        return count;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("C:/Users/caper/source/repos/hackerrank/stream.txt", true);

        string[] nr = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(nr[0]);

        long r = Convert.ToInt64(nr[1]);

        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        long ans = countTriplets(arr, r);

        textWriter.WriteLine(ans);

        textWriter.Flush();
        textWriter.Close();
    }
}
