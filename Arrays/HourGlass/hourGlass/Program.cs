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

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        int rows = arr.GetLength(0);
        int columns = arr.GetLength(0);
        int HourglassSum = -63;
        int thisHourglassSum = 0;

        for (int j = 0; j + 2 < arr.Length; j++)
        {

            for (int i = 0; i + 2 < arr[j].Length; i++)
            {
                thisHourglassSum = arr[j][i] + arr[j][i + 1] + arr[j][i + 2] + arr[j + 1][i + 1] + arr[j + 2][i] + arr[j + 2][i + 1] + arr[j + 2][i + 2];
                if (thisHourglassSum > HourglassSum) HourglassSum = thisHourglassSum;
            }
        }

        return HourglassSum;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("C:/Users/caper/source/repos/hackerrank/stream.txt", true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
