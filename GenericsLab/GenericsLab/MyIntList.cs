using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab
{
    class MyIntList<T,Y>//this T can be used anywhere in this class as a data type
    {
        private T[] intArray;
        private int count;

        public MyIntList()
        {
            intArray = new T[5];
            count = 0;
        }

        public void Add(T value)
        {
            if (count >= 5)//makes sure you're in the bounds of the array above
            {
                return;
            }
            intArray[count] = value;
            count++;

        }

        public void Show()
        {
            for(int i = 0; i < count; i++)//adding the count ensures it only shows values up to the "count" index not include 0's if there are only 3 or 5 numbers
            {
                Console.WriteLine(intArray[i]);
                Console.ReadLine();
            }
        }
    }
}
