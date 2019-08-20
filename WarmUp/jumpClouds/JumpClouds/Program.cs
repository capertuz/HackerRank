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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {
        int lc = c.Length;
        int i = 0;
        int counter = 0;
        while ( i < lc-1) {
            if (i + 2 < lc)
            {
                if (c[i + 2] == 1) i++;
                else i += 2;
            }
            else i++;
            
            counter++;

        }
        return counter;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        //int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        //;
        int[] c = { 0, 0, 1, 0, 0, 1, 0}; 
        //int[] c = { 0, 0, 0, 0, 1, 0 };
        //int[] c = { 0, 0, 1, 0, 0, 1, 0,0 };
        int result = jumpingOnClouds(c);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
