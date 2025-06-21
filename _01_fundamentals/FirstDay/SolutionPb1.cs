public class SolutionPb1()
{
    public bool checkIfPower(int numberBase, int number)
    {
        while (number > 1)
        {
            if (number % numberBase != 0) return false;
            number /= numberBase;
        }

        return true;
    }

    public bool checkIfPowerBitMaskForPowerOfTwo(int number)
    {
        return true;
    }
}