using overloading;
public class fert
{
    public static void Main()
    {
        Classover classover = new Classover(45,90);
        Classover classover1 = new Classover(45, 90,100);
        Console.WriteLine(classover.c);
        Console.WriteLine(classover1.c);

    }
}