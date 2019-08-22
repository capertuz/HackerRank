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
        for (int i = length-1; i >= 0; i--)
        {
            thisPositionBribe = q[i] - (i + 1);
            if (thisPositionBribe >= 3)
            {
                chaos = true;
                break;
            }
            //count the number of people who overtook a person.
            for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                if (q[j] > q[i]) minBribes++;
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
