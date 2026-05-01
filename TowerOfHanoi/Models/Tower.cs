using System;
using System.Collections.Generic;
using System.Text;
using TowerOfHanoi.DataStructures;

namespace TowerOfHanoi.Models
{
    internal class Tower
    {
        private string name;
        private MyStack stack;

        public Tower(string name)
        {
            this.name = name;
            this.stack = new MyStack();
        }

        public MyStack GetStack() { return this.stack; }
        public string GetName() { return this.name; }
    }
}
