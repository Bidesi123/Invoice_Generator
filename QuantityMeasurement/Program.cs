using System;

namespace QuantityMeasurement
{
    class Program
    {
        static void Main(string[] args)
        {
            Feet ff = new Feet(0);
            Feet ss = new Feet(0);
            Console.WriteLine(ff.ConvertedFeetValue(ss));
        }
    }
}
