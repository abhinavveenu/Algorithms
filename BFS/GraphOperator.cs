using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    class GraphOperator : Graph, BFS
    {
        public Queue<Node> BFSQueue { get; set; }


        public GraphOperator()
        {
            BFSQueue = new Queue<Node>();
        }

        public void BFSInit(Node StartNode)
        {
            BFSQueue.Enqueue(StartNode);
            BFSSearchRecursion();
        }

        public void BFSSearchRecursion()
        {
            while (BFSQueue.Count != 0)
            {
                Node currentNode = BFSQueue.Dequeue();
                Console.WriteLine(currentNode.Key);
                currentNode.IsVisited = true;
                for (int i = 0; i < currentNode.AdjacentNode.Count; i++)
                {
                    if (!currentNode.AdjacentNode[i].IsVisited)
                        BFSQueue.Enqueue(currentNode.AdjacentNode[i]);
                }
            }
        }

        public void DFSTraverseRecursion(Node node)
        {
            if (node.IsVisited) return;
            node.IsVisited = true;
            Console.WriteLine(node.Key);

            for (int i = 0; i < node.AdjacentNode.Count; i++)
            {
                if (!node.AdjacentNode[i].IsVisited)
                    DFSTraverseRecursion(node.AdjacentNode[i]);
            }
        }

        public void DFSTraverse(Node node)
        {
            for (int i = 0; i < Vertices.Count; i++) Vertices[i].IsVisited = false;
            DFSTraverseRecursion(node);
        }
        
    }
}
