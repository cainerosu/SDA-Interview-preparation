public class Program()
{
    static void Main(string[] args)
    {
        SolutionPb1 pb1 = new SolutionPb1();

        Console.WriteLine(pb1.checkIfPower(2, 16));
        Console.WriteLine(pb1.checkIfPower(2, 11));

        //Console.WriteLine(pb1.numberOfOnes(13));
        //Console.WriteLine(pb1.numberOfOnes(12));

        SolutionPb2 pb2 = new SolutionPb2();
        pb2.PrintStairs(4);
    }
}