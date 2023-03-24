using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] heights = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int i = 0, j = 2, minDistancia = int.MaxValue;

        while (j < n)
        {
            if (heights[j - 2] < heights[j - 1] && heights[j - 1] > heights[j])
            {
                minDistancia = Math.Min(minDistancia, heights[j - 1] - heights[i]);
                i++;
            }
            else
            {
                j++;
            }
        }
        Console.WriteLine(minDistancia);
    }
}





