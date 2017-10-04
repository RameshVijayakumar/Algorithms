using System;

namespace MyLearningAlgorithms
{
    public class Fibonacci
    {

        public int GetFibonacciIterativeWay(int numberof)
        {
            int[] dataArray = new int[numberof + 1];
            dataArray[0] = 0;
            dataArray[1] = 1;

            for (int i = 2; i < numberof + 1; i++)
            {
                dataArray[i] = dataArray[i - 2] + dataArray[i - 1];
            }

            return dataArray[numberof];
        }

        public int GetFibonacciReccursiveWay(int numberof)
        {
            if (numberof == 0)
                return 0;

            if (numberof == 1)
                return 1;

            return GetFibonacciReccursiveWay(numberof - 1) + GetFibonacciReccursiveWay(numberof - 2);
        }
    }
}
