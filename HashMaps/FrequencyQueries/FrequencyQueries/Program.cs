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

    // Complete the freqQuery function below.
    static List<int> freqQuery(List<List<int>> queries)
    {

        var list = new List<int>();
        var numbersFrequency = new Dictionary<int, int>();
        var frequencyMap = new Dictionary<int, int>();

        foreach (var query in queries)
        {

            int action = query[0];
            int number = query[1];
            int previousFrequency;
            switch (action)
            {
                case 1: //Increase value in numbersFrequency
            
                    if (numbersFrequency.ContainsKey(number))
                    {
                        previousFrequency = numbersFrequency[number];
                        numbersFrequency[number]++;
                        
                    }
                    else
                    {
                        previousFrequency = 0;
                        numbersFrequency[number] = 1;
                    }

                    //Increase new frequency and decrease old frequency, the minimum frequency value is zero
 
                    if (frequencyMap.ContainsKey(previousFrequency))
                    {
                          
                        if (frequencyMap[previousFrequency] > 0) frequencyMap[previousFrequency]--;
                    }
                    if (frequencyMap.ContainsKey(previousFrequency + 1))
                    {

                        frequencyMap[previousFrequency + 1]++;
                    }
                    else
                    {
                        frequencyMap[previousFrequency + 1] = 1;
                    }


                    break;

                case 2: //Decrease value in numbersFrequency
                    
                    if (numbersFrequency.ContainsKey(number))
                    {
                        previousFrequency = numbersFrequency[number];
                        if (numbersFrequency[number] > 0) numbersFrequency[number]--;
                    }
                    else previousFrequency = 0;

                    //decrease old frequency and Increase new frequency  , the minimum frequency value is zero

                    if (frequencyMap.ContainsKey(previousFrequency))
                    {

                        if (frequencyMap[previousFrequency] > 0) frequencyMap[previousFrequency]--;
                    }
                    if (frequencyMap.ContainsKey(previousFrequency - 1))
                    {

                        frequencyMap[previousFrequency - 1]++;
                    }
                    else
                    {
                        frequencyMap[previousFrequency - 1] = 1;
                    }
                    break;

                default: //Check numbersFrequency for values            

                    if (frequencyMap.ContainsKey(number))
                    {
                        if (frequencyMap[number] > 0) list.Add(1);
                        else list.Add(0);
                    }
                    else
                    {
                        list.Add(0);
                    }
                    break;
            
            }
        }


        return list;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("C:/Users/caper/source/repos/hackerrank/stream.txt", true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> ans = freqQuery(queries);

        textWriter.WriteLine(String.Join("\n", ans));

        textWriter.Flush();
        textWriter.Close();
    }
}
