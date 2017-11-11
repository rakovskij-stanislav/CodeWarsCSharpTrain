public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        if (((a>=b)&&(a>=c)&&(a<b+c))||((b>=a)&&(b>=c)&&(b<a+c))||((c>=b)&&(c>=a)&&(c<b+a)))
            return true;
        return false;
    }
}
