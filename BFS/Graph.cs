using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    class Graph
    {
        public int nVertices { get; set; }
        public List<Node> Vertices { get; set; }

        public Graph()
        {
            this.nVertices = 0;
            this.Vertices = new List<Node>();
        }

        public int SearchNodeByKey(int key)
        {
            for (int i = 0; i < this.Vertices.Count; i++)
            {
                if (this.Vertices[i].Key == key)
                {
                    return i;
                }
            }
            return -1;
        }

        public int AddNodeToNodeIndex(int key, int parentIndex)
        {
            if (SearchNodeByKey(key) > 0) return -1;
            Node newNode = new Node(key);
            this.Vertices.Add(newNode);
            this.Vertices[parentIndex].AdjacentNode.Add(newNode);
            this.nVertices++;
            return 1;
        }
        /// <summary>
        /// Create path from node with index: index1 to node with index2
        /// </summary>
        /// <param name="index1">Index of node 1</param>
        /// <param name="index2">Index of node 2</param>
        /// <returns>If path is succesfully added then the function returns positive integer else a negative integer</returns>
        public int CreatePathBetweenNodes(int index1, int index2)
        {
            if (index1 > Vertices.Count || index2 > Vertices.Count || index2 < 0 || index1 < 0) return -1;
            this.Vertices[index1].AdjacentNode.Add(this.Vertices[index2]);
            return 1;
        }
        /// <summary>
        /// Create path from node with key: key1 to node with key: key2
        /// </summary>
        /// <param name="key1">Key of node 1</param>
        /// <param name="key2">Key of node 2</param>
        /// <returns></returns>
        public int CreatePathBewteenNodesByKey(int key1, int key2)
        {
            int index1 = SearchNodeByKey(key1);
            int index2 = SearchNodeByKey(key2);
            if (index1 > Vertices.Count || index2 > Vertices.Count || index2 < 0 || index1 < 0) return -1;
            this.Vertices[index1].AdjacentNode.Add(this.Vertices[index2]);
            return 1;
        }

        public int AddNodeToGraph(int key)
        {
            if (SearchNodeByKey(key) > 0) return -1;
            Node newNode = new Node(key);
            this.Vertices.Add(newNode);
            this.nVertices++;
            return 1;
        }

        public int AddNodeToNodeWithKey(int key, int parentKey)
        {
            int parentIndex = SearchNodeByKey(parentKey);
            if (parentIndex < 0 || SearchNodeByKey(key) > 0) return -1;
            Node newNode = new Node(key);
            this.Vertices.Add(newNode);
            this.Vertices[parentIndex].AdjacentNode.Add(newNode);
            this.nVertices++;
            return 1;
        }

    }
}
