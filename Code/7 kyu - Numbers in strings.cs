//after submitting this solution I looked at another users' variants, my my conclusion: Regex is MUST KNOW thing)
using System;

public static class Kata
{
  public static int Solve(string s)
  { 
    string ans = "";
    string temp = ""; 
    var mode = false;
    for(int i=0; i<s.Length; i++)
       {
       char word = s[i];
       if ("0123456789".IndexOf(word)!=-1)
         {
              if (!mode) {mode = true;}
              temp+=word;
         }
       else if (mode) 
            {if (ans == "") {ans=temp;}
             else if (int.Parse(ans) < int.Parse(temp)) {ans = temp;} 
             temp = "";
             mode = false;
             }
       }
    if (mode)
     {if (ans==""&&temp!="") {ans=temp;}
      else if (temp.Length>0&&int.Parse(ans)<int.Parse(temp)) {ans=temp;}
     }
    if (ans.Length == 0)
        throw new NotImplementedException();
    Console.WriteLine($"-{ans}-");

    return int.Parse(ans);
  }
}
