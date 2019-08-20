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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        int pairCounter = 0;
        var map = new Dictionary<int, int>();

        foreach (int i in ar) {

            if (!map.ContainsKey(i)) map.Add(i, 1);
            else map[i] = map[i] + 1;

        }

        foreach (var element in map) {

            pairCounter = pairCounter + element.Value / 2;
        }

        return pairCounter;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        //;

        int n = 7;
        int[] ar = new int[] { 1, 2, 1, 2, 1, 3, 2, 10, 20 };

        int result = sockMerchant(n, ar);

        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}