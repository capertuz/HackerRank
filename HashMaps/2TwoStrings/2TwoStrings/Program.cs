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

    // Complete the twoStrings function below.
    static string twoStrings(string s1, string s2)
    {
        return s1.Intersect(s2).Any() ? "YES" : "NO";

        //int lens1 = s1.Length;
        //int lens2 = s2.Length;

        //string y = "YES";
        //string n = "NO";

        
        //if (lens2 == 0) return n;
        //if (lens1 == 0) return y;

        
        

        ////Check first single characters
        //for (int i = 0; i< lens1; i++)
        //{
        //    if (s2.Contains(s1[i])) return y;

        //}


        ////Create substrings with more than one character
        //var s1Substrings = new Dictionary<string, int>();
        //for (int i = 0; i < lens1; i++)
        //{
        //    for (int j = i + 1; j < lens1; j++)
        //    {
        //        string sub = s1.Substring(i, j - i + 1);

        //        if (s1Substrings.ContainsKey(sub)) s1Substrings[sub] = s1Substrings[sub] + 1;
        //        else s1Substrings.Add(sub, 1);
                
        //    }

        //}

        ////Check if substrings intercept

        //for (int i = 0; i < lens2; i++)
        //{
        //    for (int j = i + 1; j < lens2; j++)
        //    {
        //        if (s1Substrings.ContainsKey(s2.Substring(i, j - i + 1))) return y;
        //    }

        //}

        //return n;


    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("C:/Users/caper/source/repos/hackerrank/stream.txt", true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            string result = twoStrings(s1, s2);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
