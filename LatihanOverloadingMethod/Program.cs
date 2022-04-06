using System;

namespace LatihanOverloadingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();

            Console.WriteLine("Minimum #1: {0}", number.FindingMinimum(3, 1));
            Console.WriteLine("Minimum #2: {0}", number.FindingMinimum(3, 2, 4));
            Console.WriteLine();//baris kosong
            Console.WriteLine("Maximum #1: {0}", number.FindMaximum(3,1));
            Console.WriteLine("Maximum #2: {0}", number.FindMaximum(3,2,4));

            Console.ReadKey();
        }
    }
}
