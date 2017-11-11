using System;
using System.Collections.Generic;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
      var arr = new List<long>();
      for (int i=0; Math.Pow(10, i)-1<=n; i++) 
          arr.Add(n/Convert.ToInt64(Math.Pow(10, i))%10);
      return arr.ToArray();
    }
  }
}
