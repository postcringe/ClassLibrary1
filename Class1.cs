using System;

namespace ClassLibrary1
{
    public class Cl
    {
      public  double sum(int a, int b,int c ,int x)
        {
            if (x<0 && b!=0)
            return a*x*x+b;

            if (x > 0 && b == 0)
                return (x-a)/(x-c);
            return x / c;

        }
    }
}
