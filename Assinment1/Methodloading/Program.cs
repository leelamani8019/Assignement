using Methodloading;

public class peter
{
    public static void Main()
    {
        Method m= new Method();
        m.ping();
        m.ping(-45);
        m.ping(3, 4);
    }


}