using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumNumber_Generics
{
    public class MaximumNumberCheckGenericClass<T> where T : IComparable<T>
    {
        T firstValue, secondValue, thirdValue;

        public MaximumNumberCheckGenericClass(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        public T MaxValue()
        {
            if (this.firstValue.CompareTo(this.secondValue) > 0 && this.firstValue.CompareTo(this.thirdValue) > 0)
            {
                return firstValue;
            }
            if (this.secondValue.CompareTo(this.firstValue) > 0 && this.secondValue.CompareTo(this.thirdValue) > 0)
            {
                return secondValue;
            }
            if (this.thirdValue.CompareTo(this.firstValue) > 0 && this.thirdValue.CompareTo(this.secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("Frist Value,Second Value and Third Value.. All are Same");
        }
    }
}
