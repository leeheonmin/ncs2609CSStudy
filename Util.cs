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
    /// <summary>
    /// 정수값 바꾸기
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public static void Swap(ref int x, ref int y) // out은 초기화 필요 x, 하지만 내부 초기화 필요
    {
        Console.WriteLine($"x = {x}, y = {y}");
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"x = {x}, y = {y}");
    }

}