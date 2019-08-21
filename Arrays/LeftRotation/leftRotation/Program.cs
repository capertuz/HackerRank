

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

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {
        int length = a.Length;
        int realRotations = d % length;

        if (realRotations == 0) return a;
        else
        {
            int[] b = new int[length];
            int newindex;
            for (int i = 0; i < length; i++)
            {
                newindex = i + realRotations;
                if (newindex >= length) newindex = newindex - length;
                b[i] = a[newindex];
            }

            return b;
        }
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@"C:/Users/caper/source/repos/hackerrank/stream.txt", true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int[] result = rotLeft(a, d);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}

