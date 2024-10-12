namespace Shape
{
    class Program
    {
        public static void Main(string[] args)
        {
            var s = new Shape[3];
            s[0] = new Circle();
            s[1] = new Rectangle();
            s[2] = new Triangle();

            foreach (Shape sh in s)
            {
                PrintArea(sh);
            }
        }

        private static void PrintArea(Shape s)
        {
            s.Area();
            Console.WriteLine("Area: " + s.res);
        }
    }
}