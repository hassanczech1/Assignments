using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
   
        public class Stack<T> : IStack<T>
        {
            private T[] stack;
            private int top;
            private int maxSize;

            public Stack(int size)
            {
                stack = new T[size];
                top = -1;
                maxSize = size;
            }

            public void Push(T item)
            {
                if (top >= maxSize - 1)
                    throw new StackOverflowException("Stack is full");
                stack[++top] = item;
            }

            public T Pop()
            {
                if (top < 0)
                    throw new InvalidOperationException("Stack is empty");
                return stack[top--];
            }
        }
    }

