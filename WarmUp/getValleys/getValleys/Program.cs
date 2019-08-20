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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {

        int counter = 0;
        int valleyCounter = 0;
        int thisstep;

        for(int i = 0; i < n; i++)
        {
            
            thisstep = s[i].Equals('U') ? 1 : -1;
            if (thisstep == 1 && counter == -1) valleyCounter++;
            counter += thisstep;
        }

        return valleyCounter;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        //string s = Console.ReadLine();

        int result = countingValleys(8,"UDDDUDUU");

        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
