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
            float floatOutput = maximumNumberCheck.MaxFloatNumber(15.8f, 17.77f, 17.76f);
            Console.WriteLine(floatOutput);
            string stringOutput = maximumNumberCheck.MaxStringValue("Apple", "Peach", "Banana");
            Console.WriteLine(stringOutput);

            Console.WriteLine("Max Values By Generic Class");
            int intOutputByGeneric = new MaximumNumberCheckGenericClass<int>(10, 23, 43).MaxValue();
            Console.WriteLine(intOutputByGeneric);
            float floatOutputByGeneric = new MaximumNumberCheckGenericClass<float>(15.8f, 17.77f, 17.76f).MaxValue();
            Console.WriteLine(floatOutputByGeneric);
            string stringOutputByGeneric = new MaximumNumberCheckGenericClass<string>("Apple", "Peach", "Banana").MaxValue();
            Console.WriteLine(stringOutputByGeneric);
        }
    }
}
