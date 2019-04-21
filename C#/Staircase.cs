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

    // Complete the staircase function below.
    static void staircase(int n) {
        for(int i = 1; i < n + 1; i++){
            string thisLine = "";
            for(int j = 0; j < (n - i); j++){
                thisLine += " ";
            }
            for(int k = 0; k < i; k++){
                thisLine += "#";
            }
            Console.WriteLine(thisLine);

        }

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
