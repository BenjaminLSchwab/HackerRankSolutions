using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades) {
        int i = 0;
        int[] finals = new int[grades.GetLength(0)];
        foreach(int grade in grades){
            if(grade < 38){
                finals[i] = grade;
            }
            else if((grade % 5) > 2){
                finals[i] = grade + (5 - (grade % 5));
            }
            else{
                finals[i] = grade;
            }
            i++;
        }
        return finals;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}
