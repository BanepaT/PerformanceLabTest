class task1
{
    public static int Main(string[] args)
    {
        int n = int.Parse(args[0]); // максимальное значение
        int m = int.Parse(args[1]); // длина интервала

        if (n <= 0 || m < 0 || args.Length != 2)
        {
            Console.WriteLine("Некорректные значения или кол-во переменных");
            return 0;
        }

        var result = string.Empty;
        int currentvalue = 1;
        
        do
        {
            result += Convert.ToString(currentvalue) + " ";
            currentvalue = (currentvalue - 2 + m) % n + 1;
        }
        while (currentvalue != 1);
        
        Console.WriteLine("Первые элементы полученных интервалов: " + result);
        return 1;
    }
}