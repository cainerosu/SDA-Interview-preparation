public class SolutionPb2()
{
    public void FizzBuzz(int n)
    {
        for (int i = 0; i < n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
                continue;
            }

            if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
                continue;
            }

            if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
                continue;
            }

            Console.WriteLine(i.ToString());
        }
    }

    public void PrintStairs(int n)
    {
        int current = 1;
        int counter = 1;

        while (counter <= n)
        {
            for (int i = 0; i < counter; i++)
            {
                Console.Write(current.ToString());
                current++;
            }

            Console.WriteLine();
            counter++;
        }
    }
}