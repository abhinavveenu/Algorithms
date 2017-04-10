using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{

    /// <summary>
    /// Running Script
    ///       BFS graph = new BFS();
            //graph.AddNodeToGraph(1);
            //graph.AddNodeToGraph(2);
            //graph.AddNodeToGraph(3);
            //graph.AddNodeToGraph(0);
            //graph.CreatePathBewteenNodesByKey(2, 3);
            //graph.CreatePathBewteenNodesByKey(0, 2);
            //graph.CreatePathBewteenNodesByKey(2, 0);
            //graph.CreatePathBewteenNodesByKey(0, 1);
            //graph.CreatePathBewteenNodesByKey(3, 3);
            //graph.CreatePathBewteenNodesByKey(1, 2);
            //graph.BFSInit(graph.Vertices[1]);
    /// </summary>
    public interface BFS
    {


        void BFSInit(Node StartNode);

        void BFSSearchRecursion();
    }
}
