using System;

public class Program
{
    public static void Main()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        ShellSort(arr);
        Console.WriteLine(string.Join(", ", arr));
    }

    public static void ShellSort(int[] arr)
    {
        int n = arr.Length;
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = arr[i];
                int j;
                for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                {
                    arr[j] = arr[j - gap];
                }
                arr[j] = temp;
            }
        }
    }
}