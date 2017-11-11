public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        //yes I could just compare a<b+c, b<a+c, c<a+b, but i was too sleepy)
        if (((a>=b)&&(a>=c)&&(a<b+c))||((b>=a)&&(b>=c)&&(b<a+c))||((c>=b)&&(c>=a)&&(c<b+a)))
            return true;
        return false;
    }
}
