using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab
{
    public class GenericList<T> : IEnumerable<T>
    {
        public T[] genericArray;
        string genericString;
        int count;

        public GenericList()
        {
            genericArray = new T[0]; 
        }

                public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < genericArray.Length; i++)
            {
                if (genericArray[i] != null)
                {
                    yield return genericArray[i];
                }
            }
        }

        public void Add(T item)
        {
            T[] temporaryArray = new T[genericArray.Length + 1];
            for (int i = 0; i < genericArray.Length; i++)
            {
                temporaryArray[i] = genericArray[i];
            }
            temporaryArray[genericArray.Length] = item;
            genericArray = temporaryArray;
        }
        public static GenericList<T> operator +(GenericList<T> list1, GenericList<T> list2)
        {
            GenericList<T> combinedList = new GenericList<T>();
            foreach (T listItem in list1.genericArray)
            {
                combinedList.Add(listItem);
            }
            foreach (T listItem2 in list2.genericArray)
            {
                combinedList.Add(listItem2);
            }
            return combinedList;
        }
        public void Remove(T itemToRemove)
        {
            bool item = true;
            T[] temporaryList = new T[genericArray.Length - 1];
            for (int i = 0; i <= temporaryList.Length; i++)
            {
                if (item)
                {
                    if (genericArray[i].Equals(itemToRemove))
                    {
                        item = false;
                    }
                    else
                    {
                        temporaryList[i] = genericArray[i];
                    }
                }
                else
                {
                    temporaryList[i - 1] = genericArray[i];
                }
            }
            genericArray = temporaryList;
        }

        public static GenericList<T> operator -(GenericList<T> combinedList, GenericList<T> list)
        {
            foreach(T listItem in list.genericArray)
            {
                combinedList.Remove(listItem); 
            }
            return combinedList;
        }
        public string GenericToString()
        {
            for (int i = 0; i < genericArray.Length; i++)
            {
                genericString = genericString + " * " + genericArray[i];
            }
            return genericString;
        }

        public int Count()
        {
           for (int i = 0; i < genericArray.Length; i++)
            {
                count++;
            }
            return count;
        }

        public void Print()
        {
            foreach (T list in genericArray)
            {
                Console.WriteLine(list);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Zipper(GenericList<T> list1, GenericList<T> list2)
        {
            if (list1.genericArray.Length > list2.genericArray.Length || list1.genericArray.Length < list2.genericArray.Length || list1.genericArray.Length == list2.genericArray.Length)
            {
                for (int i = 0; i < list2.genericArray.Length; i++)
                {
                    Console.WriteLine("{0}\n{1}", list1.genericArray[i], list2.genericArray[i]);
                }
                for (int i = list2.genericArray.Length; i < list1.genericArray.Length; i++)
                {
                    Console.WriteLine("{0}", list1.genericArray[i]);
                }
           
            }
        }
    }
}
