using System;

namespace MyLearningAlgorithms
{
    public class Fibonacci
    {

        public int GetFibonacci(int numberof)
        {
            int[] dataArray = new int[numberof + 1];
            dataArray[0] = 0;
            dataArray[1] = 1;

            for (int i = 2; i < numberof; i++)
            {
                dataArray[i] = dataArray[i - 2] + dataArray[i - 1];
            }

            return dataArray[numberof];
        }
    }
}
