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
        return true;
        //return number > 0 && (number & (number - 1) == 0);
    }

    public int numberOfOnes(int number)
    {
        int counter = 0;

        while (number > 0)
        {
            if ((number & 1) == 1) counter++;
            number /= 2;
        }

        return counter;
    }

    public int numberOfOnesOpt(int number)
    {
        int count = 0;

        while (number > 0)
        {
            number = number & (number - 1);
            count++;
        }

        return count;
    }
}