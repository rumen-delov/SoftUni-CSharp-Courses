﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> elements;
        int currentIndex;

        public ListyIterator(params T[] elements)
        {
            this.elements = new List<T>(elements);
        }

        public bool Move()
        {
            if (currentIndex < elements.Count - 1)
            {
                currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return currentIndex + 1 < elements.Count;
        }

        public void Print()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(elements[currentIndex]);
        }
    }
}
