using System.Collections;

namespace yield_example
{
    class MyEnumerator
    {
        int[] numbers = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 3)
                {
                    yield break;
                }
                yield return numbers[i];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach (int i in obj)
            {
                Console.WriteLine(i);
            }
        }
    }
}