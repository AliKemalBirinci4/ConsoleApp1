﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>

    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {

            T[] tempArray = items; //değer koruma
            items = new T[items.Length + 1]; //istediğin kadar eleman arttır tempArray elemanı koruyacak

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length  -  1 ] = item;
        }
    }
}
