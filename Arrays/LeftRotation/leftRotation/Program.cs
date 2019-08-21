

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
    static int[] rotLeft(int[] arr, int d)
    {
        int n = arr.Length;
        int i, j, k, temp;
        int g_c_d = gcd(d, n);
        for (i = 0; i < g_c_d; i++)
        {
            /* move i-th values of blocks */
            temp = arr[i];
            j = i;
            while (true)
            {
                k = j + d;
                if (k >= n)
                    k = k - n;
                if (k == i)
                    break;
                arr[j] = arr[k];
                j = k;
            }
            arr[j] = temp;
        }

        return arr;
    }

    /* Fuction to get gcd (greatest common divisor) of a and b*/
    static int gcd(int a, int b)
    {
        if (b == 0)
            return a;
        else
            return gcd(b, a % b);
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

