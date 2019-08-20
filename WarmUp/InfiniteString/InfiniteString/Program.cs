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

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        long counter = 0;
        long reminder;
        long totalas=0;
        reminder = n % s.Length;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].Equals('a'))
            {
                if (i + 1 <= reminder) totalas++;
                counter++;
            }
        }        
        totalas += ((n / s.Length) * counter);
        return totalas;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = "aba";

        long n = 10;
        long result = repeatedString(s, n);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
