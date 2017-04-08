using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    class trie
    {
        trie[] children { get; set; }
        bool isLeaf;

        public trie()
        {
            children = new trie[26];
        }

        /// <summary>
        /// Inserts string in trie if it does not there in the trie object
        /// </summary>
        /// <param name="str"></param>
        public void insert(string str)
        {
            if (ContainsString(str)) return;
            trie crawler = this;
            for (int i = 0; i < str.Length; i++)
            {
                int index = str[i] - 'a';
                if (crawler.children[index] == null)
                {
                    crawler.children[index] = new trie();
                }
                crawler = crawler.children[index];
            }
        }

        /// <summary>
        /// Search for the string in trie data structure. If string exists then it returns true else false
        /// </summary>
        /// <param name="str"></param>
        /// <returns>true: if string exists, else returns false</returns>
        public bool ContainsString(string str)
        {
            bool result = true;
            trie crawler = this;
            for (int i = 0; i < str.Length; i++)
            {
                int index = str[i] - 'a';
                if (crawler.children[index] == null)
                {
                    result = false;
                    break;
                }
                crawler = crawler.children[index];
            }

            return result;
        }
    }
}
