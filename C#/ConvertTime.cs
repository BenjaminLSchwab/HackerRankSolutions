
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        bool AM = true;
        Console.WriteLine(s[8]);
        if(s[8] == 'P'){
            AM = false;
        }

        int hours = Int32.Parse(s.Substring(0,2));
        int mins = Int32.Parse(s.Substring(3,2));
        int secs = Int32.Parse(s.Substring(6,2));
        
        if(AM == false){
            hours += 12;
        }
        if(AM == true && hours == 12){
            hours = 0;
        }
        if(hours == 24 && (secs != 0 || mins != 0)){
            hours = 12;
        }
        string sHours = "";
        if(hours < 10){
            sHours = "0" + hours;
        }
        else{
            sHours = hours.ToString();
        }

        string sMins = "";
        if(mins < 10){
            sMins = "0" + mins;
        }
        else{
            sMins = mins.ToString();
        }

        string sSecs = "";
        if(secs < 10){
            sSecs = "0" + secs;
        }
        else{
            sSecs = secs.ToString();
        }
        string ans = sHours + ":" + sMins + ":" + sSecs;
        return ans;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
