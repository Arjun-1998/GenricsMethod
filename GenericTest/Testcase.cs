using Genric;
using NUnit.Framework;

namespace GenricTest
{
    public class Testcase
    {
       

        [Test]
        public void GivenMaxIntFirst_WhenPrintMaxValue_ThenShouldGiveFirstValue()
        {
            int[] intArray = { 9, 1, 4, 2 };
            int expected = intArray[0];
            GenricMaximum<int> genric = new GenricMaximum<int>();
            int result = genric.PrintMaxValue(intArray);
            Assert.AreEqual(expected,result);
        }


    }
}