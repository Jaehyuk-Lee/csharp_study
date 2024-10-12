namespace Exception_Handling
{
    class Program
    {
        public static void Main(string[] args)
        {
            makeZero();
            parseIntError();
            nullReference();
            try
            {
                Thread myThread = new Thread(MyFunction);
                myThread.Start();
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Main thread: Do some work. " + i);
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        private static void MyFunction()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
                Thread.Sleep(100);
            }
        }

        private static void makeZero()
        {
            try
            {
                int a = 0;
                Console.WriteLine(10 / a);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("ArithmeticException: " + ex.Message);
                // throw;
            }
        }

        private static void parseIntError()
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int num = int.Parse(input);
                Console.WriteLine("입력: " + num);
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException: Cannot convert string to integer.");
                // throw;
            }
        }

        private static void nullReference()
        {
            try
            {
                string null_ = null;
                Console.WriteLine(null_.Length);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("NullReferenceException: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block is executed");
            }
        }
    }
}
