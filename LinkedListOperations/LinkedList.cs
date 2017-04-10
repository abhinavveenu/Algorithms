using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    class LinkedList
    {
        public int Key { get; set; }
        public LinkedList Next { get; set; }

        public LinkedList(int key)
        {
            this.Key = key;
        }

        /// <summary>
        /// Loop detect using slow and fast pointers
        /// </summary>
        /// <returns></returns>
        public bool IsLooped()
        {
            LinkedList slowPointer = this;
            LinkedList fastPointer = this;
            while (slowPointer != null && fastPointer != null && fastPointer.Next!=null)
            {
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next.Next;
                if (slowPointer == fastPointer) return true;
            } 
                return false;
        }
    }
}
