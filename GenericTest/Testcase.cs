using Genric;
using NUnit.Framework;

namespace GenricTest
{
    public class Testcase
    {
       

        [Test]
        public void GivenMaxIntSecond_WhenPrintMaxValue_ThenShouldGiveSecondValue()
        {
            int[] intArray = { 1, 9, 2, 4 };
            int expected = intArray[1];
            GenricMaximum<int> genric = new GenricMaximum<int>();
            int result = genric.PrintMaxValue(intArray);
            Assert.AreEqual(expected,result);
        }


    }
}