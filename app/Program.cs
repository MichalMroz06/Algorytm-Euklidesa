using System;
namespace app;

public class Euclid
{
    public static int Nwd(int a, int b)
    {
        if (a == 0 && b == 0)
            throw new ArgumentException("NWD nie jest zdefiniowane dla (0, 0).");

        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    static void Main(string[] args)
    {
        
    }
}
