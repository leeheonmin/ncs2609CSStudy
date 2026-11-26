namespace MyUtil;
using MyUtil;
public class Util
{
    public static void PrintArray<T>(T[] answer)
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
    public static void Swap<T>(ref T x, ref T y) // out은 초기화 필요 x, 하지만 내부 초기화 필요
    {
        // Console.WriteLine($"x = {x}, y = {y}");
        T temp = x;
        x = y;
        y = temp;
        // Console.WriteLine($"x = {x}, y = {y}");
    }


    public delegate int CompareDelegate(int i1, int i2);

    public static void Sort(int[] arr, CompareDelegate comp)
    {
        if (arr.Length < 2) return;
        Console.WriteLine("함수 Property : " + comp.Method);

        int ret;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                ret = comp(arr[i], arr[j]);
                if (ret == - 1)
                {
                    Swap(ref arr[i], ref arr[j]);
                }
            }
        }
        PrintArray(arr);
    }

}