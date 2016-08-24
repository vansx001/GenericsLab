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
        private T[] genericArray; 

        public GenericList()
        {
            genericArray = new T[0]; 
        }
        public void Add(T itemToAdd)
        {
            T[] temporaryArray = new T[genericArray.Length + 1];
            for (int i = 0; i < genericArray.Length; i++)
            {
                temporaryArray[i] = genericArray[i];
            }
            temporaryArray[genericArray.Length] = itemToAdd;
            genericArray = temporaryArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < genericArray.Length; i++)
            {
                yield return genericArray[i];
            }
        }

        public void Remove(T removeItem)
        {
            bool notFound = true;
            T[] temporaryGenericArray = new T[genericArray.Length - 1];
            for (int i = 0; i < genericArray.Length; i++)
            {
                if (notFound)
                {
                    if (genericArray[i].Equals(removeItem))
                    {
                        notFound = false;
                    }
                    else
                    {
                        temporaryGenericArray[i] = genericArray[i];
                    }
                }
                else
                {
                    temporaryGenericArray[i - 1] = genericArray[i];
                }
            }
            genericArray = temporaryGenericArray;
        }

        public static void StringBuilder(T[] genericArray)
        {
            StringBuilder builder = new StringBuilder();
            foreach (T itemToAdd in genericArray) // Loop through all strings
            {
                builder.Append(itemToAdd).Append(" , "); // Append string to StringBuilder
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
