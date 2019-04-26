using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the getTotalX function below.
     */
    static int getTotalX(int[] a, int[] b) {
     


    int ans = 0;
    for(int num = 1; num < 101; num++){
        bool checkA = true;
        foreach(int secondNum in a){
            if((num % secondNum) != 0){
                checkA = false;
            }
        }

        bool checkB = true;
        foreach(int secondNum in b){
            if((secondNum % num) != 0){
                checkB = false;
            }
        }

        if(checkA && checkB){
            ans++;
        }
    }

    return ans;


    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int total = getTotalX(a, b);

        tw.WriteLine(total);

        tw.Flush();
        tw.Close();
    }
}
