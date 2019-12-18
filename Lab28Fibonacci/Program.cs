using System;

namespace Lab28Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Fibonacci
    {
        public int ReturnFibonacciNthValue(int n)
        {
            int CurrentNum = 1;
            int PreviousNum = 0;
            int FibNum = 1;
            for (int i = 1; i < n; i++)
            {
                FibNum = CurrentNum + PreviousNum;
                PreviousNum = CurrentNum;
                CurrentNum = FibNum;
            }
            return FibNum;
        }
    }
}
