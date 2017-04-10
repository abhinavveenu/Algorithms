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
                if (slowPointer == fastPointer)
                {
                    //Basic brute force algorithm
                    //removeLoopNaive(slowPointer);

                    //Optimized algorithm
                    removeLoopOptimized(slowPointer);
                    return true;
                }
            } 
                return false;
        }

        public void removeLoopNaive(LinkedList loopNode)
        {
            LinkedList ptr1 = this;
            LinkedList ptr2 = loopNode;

            while (true)
            {
                ptr2 = ptr2.Next;
                while(ptr2.Next !=ptr1 && ptr2 != loopNode)
                {
                    ptr2 = ptr2.Next;
                }

                if (ptr2.Next == ptr1) break;

                ptr1 = ptr1.Next;

            }

            ptr2.Next = null;
        }

        public void removeLoopOptimized(LinkedList loopNode)
        {
            LinkedList ptr1 = this;
            LinkedList ptr2 = loopNode;

            while(ptr2.Next != ptr1.Next)
            {
                ptr1 = ptr1.Next;
                ptr2 = ptr2.Next;
            }

            ptr2.Next = null;
        }

    }
}
