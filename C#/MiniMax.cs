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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        var sortedArr = new int[5];
        foreach(int num in arr){
            int higherThanCount = 0;
            int sameCount = 0;
            foreach(int secondNum in arr){
                if(num > secondNum){
                    higherThanCount++;
                }
                if(num == secondNum){
                    sameCount++;
                }
            }
            sortedArr[higherThanCount] = num;
            for(int k = 0; k < sameCount; k++){
                sortedArr[higherThanCount + k] = num;
            }
            
        }
        long low = 0;
        long high = 0;
        for(int i = 0; i < 4; i++){
            low += sortedArr[i];
            high += sortedArr[i+1];
        }
        Console.WriteLine(low + " " + high);
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
