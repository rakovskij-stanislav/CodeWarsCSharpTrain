using System;
using System.Linq;

public class Dubstep
    {
        public static string SongDecoder(string input)
        { 
           string ans = input.Replace("WUB", " ");
           while (ans[0]==' ') 
              ans=ans.Substring(1);
           while (ans[ans.Length-1]==' ') 
              ans=ans.Substring(0, ans.Length-1);           
           while (ans.IndexOf("  ")!=-1) 
              ans = ans.Replace("  ", " ");
           Console.WriteLine(ans);
        return ans;
        }
    }
