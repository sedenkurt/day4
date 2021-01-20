using System;
using System.Collections.Generic;
using System.Text;

namespace genericsIntro
{
    class myList<T>
    {
        T[] items;
        //constructor
        public myList()
        {
            items = new T[0];
        }
        public void Add(T item)
        { //temparray önceki referansı kaybolmaması için tutar.
            T[] tempArray = items;
            items = new T[items.Length + 1];
            //temparraya tutturduğumuz değerleri birleştirmek için 
            for (int i = 0; i < tempArray.Length; i++)
            { 
                items[i] = tempArray[i];

            }

            items[items.Length - 1] = item;
            //son elemanı girmek için??? item.Length-1=itemin eleman sayısı -1 yani son elemanı


        }
    }
}
