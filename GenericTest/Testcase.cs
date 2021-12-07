using Genric;
using NUnit.Framework;

namespace GenricTest
{
    public class Testcase
    {


        [Test]
        public void GivenMaxIntFirst_WhenPrintMaxValue_ThenShouldGiveFirstValue()
        {
            int[] intArray = { 9, 1, 2, 4 };
            int expected = intArray[0];
            GenricMaximum<int> genric = new GenricMaximum<int>();
            int result = genric.PrintMaxValue(intArray);
            Assert.AreEqual(expected, result);
        }
        public void GivenMaxIntSecond_WhenPrintMaxValue_ThenShouldGiveSecondValue()
        {
            int[] intArray = { 2, 9, 1, 4 };
            int expected = intArray[1];
            GenricMaximum<int> genric = new GenricMaximum<int>();
            int result = genric.PrintMaxValue(intArray);
            Assert.AreEqual(expected, result);
        }
        public void GivenMaxIntThird_WhenPrintMaxValue_ThenShouldGiveThirdValue()
        {
            int[] intArray = { 2, 1, 9, 4 };
            int expected = intArray[2];
            GenricMaximum<int> genric = new GenricMaximum<int>();
            int result = genric.PrintMaxValue(intArray);
            Assert.AreEqual(expected, result);
        }
        public void GivenMaxDoubleFirst_WhenPrintMaxValue_ThenShouldGiveFirstValue()
        {
            double[] doubleArray = { 8.3, 6.2, 2.3 };
            double expected = doubleArray[0];
            GenricMaximum<double> genric = new GenricMaximum<double>();
            double result = genric.PrintMaxValue(doubleArray);
            Assert.AreEqual(expected, result);
        }
        public void GivenMaxDoubleSecond_WhenPrintMaxValue_ThenShouldGiveSecondValue()
        {
            double[] doubleArray = { 6.2, 8.3, 2.3 };
            double expected = doubleArray[1];
            GenricMaximum<double> genric = new GenricMaximum<double>();
            double result = genric.PrintMaxValue(doubleArray);
            Assert.AreEqual(expected, result);
        }
        public void GivenMaxDoubleThird_WhenPrintMaxValue_ThenShouldGiveThirdValue()
        {
            double[] doubleArray = { 6.2, 2.3, 8.3 };
            double expected = doubleArray[2];
            GenricMaximum<double> genric = new GenricMaximum<double>();
            double result = genric.PrintMaxValue(doubleArray);
            Assert.AreEqual(expected, result);
        }
    }
}