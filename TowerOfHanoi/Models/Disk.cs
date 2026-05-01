using System;
using System.Collections.Generic;
using System.Text;

namespace TowerOfHanoi.Models
{
    internal class Disk
    {
        private int size;

        public Disk(int size)       
        {
            this.size = size;
        }

        public int GetSize()
        {
            return this.size;
        }

        public void SetSize(int size)
        {
            this.size = size;
        }

    }
}
