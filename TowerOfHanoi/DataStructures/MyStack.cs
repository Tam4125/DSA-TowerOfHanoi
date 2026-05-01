using System;
using System.Collections.Generic;
using System.Text;

namespace TowerOfHanoi.DataStructures
{
    internal class MyStack
    {
        private StackNode top;
        private int size;

        public MyStack() { }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(object data)
        {
            StackNode newNode = new StackNode(data);

            newNode.SetNext(this.top);
            this.top = newNode;

            size++;
        }

        public object Pop()
        {
            if(this.IsEmpty())
            {
                throw new InvalidOperationException("Cannot pop from an empty stack.");
                return null;
            } 

            StackNode tmp = this.top;
            this.top = tmp.GetNext();
            tmp.SetNext(null);
            size--;
            return tmp.GetData();
        }

        public object Peek()
        {
            if(this.IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return null;
            }
            return this.top.GetData();
        }

        public int GetSize()
        {
            return this.size;
        }

        public void Clear()
        {
            this.top = null;
            this.size = 0;
        }

        public object[] ToArray()
        {
            object[] arr = new object[size];
            StackNode current = top;
            for (int i = 0; i < size; i++)
            {
                arr[i] = current.GetData();
                current = current.GetNext();
            }
            return arr; // Note: Returns top-to-bottom order
        }
    }




}
