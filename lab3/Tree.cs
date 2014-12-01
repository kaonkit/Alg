using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{

    class Tree<T> where T : IComparable
    {
        public Node<T> root{get; private set;}
        public int count {get; private set;}
        public string nodes { get; private set; }
        public delegate bool Clause(Node<T> node);
        
        int res = 0;

        #region Delegates

        public Clause isLeave = node => node.left == null && node.right == null;
        public Clause isInternalNode = node => node.left != null || node.right != null;

        public Clause hasOnlyLeftNode = node => node.left != null && node.right == null;
        public Clause hasLeftNode = node => node.left != null;

        public Clause hasOnlyRightNode = node => node.left == null && node.right != null;
        public Clause hasRightNode = node => node.right != null;

        public Clause hasTwoNodes = node => node.left != null && node.right != null;
        public Clause hasOneNode = node => (node.left != null && node.right == null) || (node.left == null && node.right != null);


        private delegate int Max(int node1, int node2);
        private Max max = (node1, node2) => node1 > node2 ? node1 : node2;

        #endregion

        public Tree(T val) {
            root = new Node<T>(val);
        }

        public int height(Node<T> node)
        {
            Node<T> temp = node;
            int hleft = 0, hright = 0;
            if (node == null) return (0);
            if (node.left != null)  hleft = height(node.left); 
            if (node.right != null)  hright = height(node.right); 
            return(max(hleft,hright) + 1);
        }

        public Node<T> Add(T key)
        {
            Node<T> node = root;
            Add(root, key);
            return node;
        }
        private Node<T> Add(Node<T> node, T key, Node<T> parent = null)
        {

            if (node == null)
                node = new Node<T>(key, parent);
            else if (key.CompareTo(node.key) < 0)
                node.left = Add(node.left, key, node);
            else
                node.right = Add(node.right, key, node);
            return node;
        }

        public void PreorderWalk(Node<T> node, Clause clause = null, bool first = true)
        {
            if (first) { count = 0; nodes = ""; }
            if (node == null) return;
            if (clause == null || clause(node)){
                count++;
                nodes += node.key + " ";
            }
            PreorderWalk(node.left, clause, false);
            PreorderWalk(node.right, clause, false);
            if (nodes == "") nodes = "-";
        }
        
        public int Depth(Node<T> node, string s, bool first = true) {
            if (first) res = 0;
            if (node == null) return res;
            res++;
            if(s == "min") Depth(node.left, s, false);
            else Depth(node.right, s, false);
            return res;
        }
    }
}
