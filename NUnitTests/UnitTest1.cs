using NUnit.Framework;

namespace Lab28Fibonacci.Test
{
    public class Tests
    {
        [TestCase(1,1)]
        [TestCase(4,3)]
        [TestCase(5,5)]
        [TestCase(6,8)]
        [TestCase(8,21)]
        [TestCase(14,377)]
        public void FibonacciTest(int n, int expected)
        {
            Fibonacci Fib = new Fibonacci();
            int actual = Fib.ReturnFibonacciNthValue(n);
            Assert.AreEqual(expected, actual);
        }
    }
}

namespace Lab29SimpsonsRule.Test
{
    public class Tests
    {
        [TestCase(6,0,6,72)]
        [TestCase(10,0,10, 333.33333333333331)]
        [TestCase(12,0,12,576)]
        [TestCase(100,0,100, 333333.33333333331)]
        public void SimpsonsTestSquared(int n, int min, int max, double expected)
        {
            SimpsonsRule SR = new SimpsonsRule();
            double actual = SR.GetAreaUnderGraphSquared(n, min, max);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6,0,6,324)]
        [TestCase(10,0,10,2500)]
        [TestCase(20,00,20,40000)]
        public void SimpsonsTestCubed(int n, int min, int max, double expected)
        {
            SimpsonsRule sr = new SimpsonsRule();
            double actual = sr.GetAreaUnderGraphCubed(n, min, max);
            Assert.AreEqual(expected, actual);
        }
    }
}