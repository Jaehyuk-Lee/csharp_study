class Program
{
    public static void Main(string[] args)
    {
        print();
        int switchValue = 3;
        int i = 10, j = 5;
        Console.WriteLine(i + " + " + j + " = " + sum(i, j));
        Console.WriteLine(i + " - " + j + " = " + sub(i, j));
        Console.WriteLine(i + " * " + j + " = " + mul(i, j));
        Console.WriteLine(i + " / " + j + " = " + div(i, j) + " ... " + mod(i, j));

        Console.WriteLine("주사위: " + dice());

        string resultText = switchValue switch
        {
            1 or 2 or 3 => "one, two, or three",
            4 => "four",
            5 => "five",
            _ => "unknown",
        };
        Console.WriteLine(resultText);
        print("abc");

        Point2D point = new Point2D(10, 20);

        point.print();

        Point3D point3 = new Point3D();
        point3.Z = 30000;
        point3.print();

        printi(1);
        printi(2, 3);
        printi(3, 4, 5);

        // Point2D point2 = new();
        // point2.print();

        Point3D point32 = new(40, 50, 60);
        point32.print();
    }

    private static void printi(params int[] i)
    {
        for (int a = 0; a < i.Length; a++)
        {
            Console.WriteLine("i[" + a + "]: " + i[a]);
        }
    }

    private static void print()
    {
        Console.WriteLine("Hello, World!");
    }

    private static void print(string str)
    {
        Console.WriteLine("Hello, World! " + str);
    }

    private static int sum(int a, int b)
    {
        return a + b;
    }

    private static int sub(int a, int b)
    {
        return a - b;
    }

    private static int mul(int a, int b)
    {
        return a * b;
    }

    private static int div(int a, int b)
    {
        return a / b;
    }

    private static int mod(int a, int b)
    {
        return a % b;
    }

    private static int dice()
    {
        Random random = new Random();
        return random.Next(1, 7);
    }
}