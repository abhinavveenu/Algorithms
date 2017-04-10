using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    class BTree
    {
        public int Key { get; set; }
        public BTree Left { get; set; }
        public BTree Right { get; set; }

        public BTree(int key)
        {
            this.Key = key;
            this.Left = null;
            this.Right = null;
        }

        public void TreeLeftViewTraversalInit()
        {
            int maxLevel = 0;
            TreeLeftViewTraversal(this, 1, ref maxLevel);
        }

        public void TreeLeftViewTraversal(BTree root, int currentLevel, ref int maxLevel)
        {
            if (root == null) return;
            if (currentLevel > maxLevel)
            {
                Console.WriteLine(root.Key);
                maxLevel++;
            }
            TreeLeftViewTraversal(root.Left, currentLevel + 1, ref maxLevel);
            TreeLeftViewTraversal(root.Right, currentLevel + 1, ref maxLevel);
        }

        public void LevelOrderTraversal()
        {
            Queue<BTree> queue = new Queue<BTree>();
            queue.Enqueue(this);
            LevelOrderTraversalRecurse(queue);
        }

        public void LevelOrderTraversalRecurse(Queue<BTree> LevelTraversalQueue)
        {
            while (LevelTraversalQueue.Count > 0)
            {
                BTree node = LevelTraversalQueue.Dequeue();
                Console.WriteLine(node.Key);

                LevelTraversalQueue.Enqueue(node.Left);
                LevelTraversalQueue.Enqueue(node.Right);
            }
        }

    }
}
