using System;

namespace FindMaximumNumber_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            int intOutput = maximumNumberCheck.MaxIntegerNumber(10, 23, 43);
            Console.WriteLine(intOutput);   
        }
    }
}
