public class oddnums
{
    public static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach(int num in nums)
        {
            if (num % 2 != 0)
                {
                Console.WriteLine(num);
                }

        }
       
    }
}