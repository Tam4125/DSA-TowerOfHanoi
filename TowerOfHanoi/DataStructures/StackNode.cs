using System;
using System.Collections.Generic;
using System.Text;
using TowerOfHanoi.Models;

namespace TowerOfHanoi.DataStructures
{
    internal class StackNode
    {
        private object data;
        private StackNode next;

        public StackNode() { }
        public StackNode(object data)
        {
            this.data = data;
        }

        public object GetData() { return data; }
        public void SetData(object data) { this.data = data; }

        public StackNode GetNext() { return next; }
        public void SetNext(StackNode next) { this.next = next; }
    }
}
