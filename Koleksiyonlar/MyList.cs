﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Koleksiyonlar
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];

            
        }
        public void Add(T item)
        {
            T[] tempArray = items;

            
            
            items = new T[items.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }
            items[items.Length - 1] = item;

            
        }
        public void Yazdir()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
