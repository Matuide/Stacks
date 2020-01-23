using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    class Stack
    {
        private char[] stack;
        private int bottom;
        private int top;

        public Stack (int size)
        {
            stack = new char[size];
            bottom = 0;
        }
        public void AddToStack (char c)
        {
            top = top + 1;
            top = c;
            
        }
        public char RemoveFromStack()
        {
            if(IsEmpty(top) == true)
            {
                Console.WriteLine("stack already empty");
            }
            if (IsEmpty(top) == false)
            {
                
            }

            return ' ';
        }

        private static bool IsEmpty(int top)
        {
            if (top == 0)
            {
                return true;
            }
                return false;
        }
    }
}
