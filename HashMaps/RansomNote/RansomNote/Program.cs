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

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note)
    {
        int lenMagazine = magazine.Length;
        int lenNote = note.Length;

        if (lenNote > lenMagazine) { Console.WriteLine("No"); return; }
        if (lenNote == 0) { Console.WriteLine("Yes"); return; }
        if (lenMagazine == 0) { Console.WriteLine("No"); return; }

        var magazineHash = new Hashtable();
        bool isSubset = true;
        foreach (string s in magazine)
        {
            

            if (magazineHash.ContainsKey(s))
            {
                magazineHash[s] = (int)magazineHash[s] + 1;
            }
            else
            {
                magazineHash.Add(s,1);
            }

        }

        foreach (string n in note) {

            if (magazineHash.ContainsKey(n))
            {
                if ((int)magazineHash[n] == 0)
                {
                     isSubset = false;

                    break;
                }
                else magazineHash[n] = (int)magazineHash[n] - 1;
            }
            else
            {
                 isSubset = false;

                break;
            }
        }

        if (isSubset) Console.WriteLine("Yes");
        else Console.WriteLine("No");


    }

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
