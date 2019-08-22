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

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {
        int length = q.Length;
        int minBribes = 0;
        int thisPositionBribe;
        bool chaos = false;
        for (int i = 0; i < length; i++)
        {
            thisPositionBribe = q[i] - (i + 1);
            if (thisPositionBribe >= 3)
            {
                chaos = true;
                break;
            }
            if (thisPositionBribe > 0) minBribes += thisPositionBribe;
        }
        if(chaos) Console.WriteLine("Too chaotic");
        else      Console.WriteLine(minBribes);

    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
