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

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        decimal posTotal = 0;
        decimal negTotal = 0;
        foreach(int i in arr){
            if(i > 0){
                posTotal++;
            }
            else if(i < 0){
                negTotal++;
            }

        }
        decimal total = arr.GetLength(0);
        decimal zeroTotal = total - (posTotal + negTotal);
        Console.WriteLine(posTotal / total);
        Console.WriteLine(negTotal / total);
        Console.WriteLine(zeroTotal / total);

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
