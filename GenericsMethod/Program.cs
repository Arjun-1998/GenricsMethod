using Genric;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Find Maximum Number!");

        int[] intArray = { 1, 2, 9, 4 };
        GenricMaximum<int> generic = new GenricMaximum<int>();
        generic.PrintMaxValue(intArray);

        double[] doubleArray = { 2.3, 6.2, 8.3 };
        GenricMaximum<double> genericDouble = new GenricMaximum<double>();
        genericDouble.PrintMaxValue(doubleArray);






    }
}