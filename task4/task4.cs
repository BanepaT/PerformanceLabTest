using System;
using System.IO;

class task4
{
    static int Main(string[] args)
    {
        String path = args[0];
        int[] numbers = Array.ConvertAll(File.ReadAllLines(path), int.Parse);

        Array.Sort(numbers);

        int median;
        int mid = numbers.Length / 2;

        if (numbers.Length % 2 == 0) median = (numbers[mid] + numbers[mid - 1]) / 2;
        else median = numbers[mid];

        int steps = 0;

        foreach (int i in numbers)
        {
            steps += Math.Abs(median - i);
        }

        Console.WriteLine(steps);
        return 1;
    }
}
