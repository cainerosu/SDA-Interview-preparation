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

    public bool checkBitMaskForPowerOfTwo(int number)
    {
        return number > 0 && (number & (number - 1) == 0);
    }
}