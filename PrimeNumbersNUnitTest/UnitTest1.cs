using PrimeNumbers;

namespace PrimeNumbersNUnitTest
{
    public class Tests
    {
        private Prime _primecheck;

        [SetUp]
        public void Setup()
        {
            _primecheck = new Prime();
        }

        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(11)]
        [TestCase(13)]
        public void TestIsPrimeWithReturnOfTrue(int number)
        {
            Assert.IsTrue(_primecheck.isPrime(number));
        }

        [TestCase(4)]
        [TestCase(6)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        public void TestIsPrimeWithReturnOfFalse(int number)
        {
            Assert.IsFalse(_primecheck.isPrime(number));
        }

        [TestCase(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, new int[] { 2, 3, 5, 7, 11 })]
        [TestCase(new int[] { 2, 3, 5, 7, 11, 13 }, new int[] { 2, 3, 5, 7, 11, 13 })]
        [TestCase(new int[] { 4, 6, 8, 9, 10, 12 }, new int[] { })]
        [TestCase(new int[] { }, new int[] { })]
        public void TestOnlyPrimeNumbers(int[] input, int[] expectedOutput)
        {
            List<int> result = _primecheck.OnlyPrimeNumbers(new List<int>(input));
            //Assert.AreEqual(new List<int>(expectedOutput), result); // BACHKA!!!!!!!!
            CollectionAssert.AreEqual(new List<int>(expectedOutput), result);
        }
    }
}