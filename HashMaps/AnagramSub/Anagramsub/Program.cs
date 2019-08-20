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

    // Complete the sherlockAndAnagrams function below.
    static int sherlockAndAnagrams(string s)
    {

        if (String.IsNullOrEmpty(s)) return 0;        

        int length = s.Length;

        if (length == 1) return 0;

        // d is the number of characters in the input alphabet
        int d = 26; 

        var hashDictionary = new Dictionary<int, int>();
        
        
        //create dictionary of substring hashes
        for (int i = 0; i < length; i++)
        {
            int p = 0; // hash value for pattern
            int subLength = 1;
            while (i + subLength - 1 < length)
            {
                string sub = s.Substring(i, subLength);

                //This is one method to compare substrings.
                sub = String.Concat(sub.OrderBy(c => c)); 

                //Other method is to generate rolling hash.

                int hashCode = sub.GetHashCode();
                if (hashDictionary.ContainsKey(hashCode)) hashDictionary[hashCode] = hashDictionary[hashCode] + 1;
                        else hashDictionary.Add(hashCode, 1);
                subLength++;

            }
        }

        int counter = 0;
        foreach (KeyValuePair<int, int> entry in hashDictionary)
        {
            // do something with entry.Value or entry.Key

            if (entry.Value > 1)
            {
                int n = entry.Value - 1;
                //int pairs = 1;

                //for (int i = 2; i < entry.Value; i++)
                //{
                //    pairs = pairs + i;
                //}
                counter += (n*(n+1)/2);
            }
        }



        return counter;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("C:/Users/caper/source/repos/hackerrank/stream.txt", true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = sherlockAndAnagrams(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
        int h = 0;

    }
}
