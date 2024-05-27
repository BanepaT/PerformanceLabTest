class task2
{
    public static int Main(string[] args)
    {

        string[] circle = File.ReadAllLines(args[0]);
        string[] points = File.ReadAllLines(args[1]);
        
        string[] center = circle[0].Split(' ');
        double x0 = double.Parse(center[0]);
        double y0 = double.Parse(center[1]);

        var radius = double.Parse(circle[1]);

        string result = string.Empty;

        for (int i = 0; i < points.Length; i++)
        {
            string[] dots = points[i].Split(' ');
            double x1 = double.Parse(dots[0]);
            double y1 = double.Parse(dots[1]);

            double distance = Math.Sqrt(Math.Pow((x1 - x0), 2) + Math.Pow((y1 - y0), 2));

            switch (distance)
            {
                case var expression when (distance < radius):
                    result += "1" + '\n';
                    break;
                case var expression when (distance == radius):
                    result += "0" + "\n";
                    break;
                case var expression when (distance > radius):
                    result += "2" + "\n";
                    break;
            }

        }


        Console.WriteLine(result);
        return 1;

    }
}