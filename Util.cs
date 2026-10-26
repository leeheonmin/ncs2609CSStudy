namespace MyUtil;
using MyUtil;
public class Util
{
    public static void PrintArray(int[] answer)
    {
        Console.Write("[");
        for (int i = 0; i < answer.Length; i++)
        {
            Console.Write(answer[i]);
            if (i < answer.Length - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("]");
    }
}