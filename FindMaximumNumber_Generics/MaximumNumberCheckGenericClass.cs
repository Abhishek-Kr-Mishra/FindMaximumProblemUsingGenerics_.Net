using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumNumber_Generics
{
    public class MaximumNumberCheckGenericClass<T> where T : IComparable<T>
    {        
        public T MaxValue(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("Frist Value,Second Value and Third Value.. All are Same");
        }
    }
}
