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
        public delegate bool Clause(Node<T> node, Node<T> root = null);
        
        int res = 0;

        #region Delegates

        public Clause isLeave = (node, root) => node.left == null && node.right == null;
        public Clause isInternalNode = (node, root) => node != root && (node.left != null || node.right != null);

        public Clause hasOnlyLeftNode = (node, root) => node.left != null && node.right == null;
        public Clause hasLeftNode = (node, root) => node.left != null;

        public Clause hasOnlyRightNode = (node, root) => node.left == null && node.right != null;
        public Clause hasRightNode = (node, root) => node.right != null;

        public Clause hasTwoNodes = (node, root) => node.left != null && node.right != null;
        public Clause hasOnlyOneNode = (node, root) => (node.left != null && node.right == null) || (node.left == null && node.right != null);

        public Clause isLeft = (node, root) => node.parent.left == node;
        public Clause isRight = (node, root) => node.parent.right == node;


        private delegate int Max(int node1, int node2);
        private Max max = (node1, node2) => node1 > node2 ? node1 : node2;

        #endregion

        public Tree(T val) {
            root = new Node<T>(val);
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
            {
                node = new Node<T>(key, parent);
            }
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
            if (clause == null || clause(node, root)){
                count++;
                if (nodes != "" && nodes != null) nodes += " ";
                nodes += node.key;
            }
            PreorderWalk(node.left, clause, false);
            PreorderWalk(node.right, clause, false);
            
        }
        
        public int Depth(Node<T> node, string s, bool first = true) {
            if (first) res = 0;
            if (node == null) return res;
            res++;
            if(s == "min") Depth(node.left, s, false);
            else Depth(node.right, s, false);
            return res;
        }

        public double Average() {
            PreorderWalk(root);
            String[] c = this.nodes.Split();
            int i = 0, sum = 0;
            for (; i < c.Length; i++)
                sum += Int32.Parse(c[i]);
            return sum / i;
        }

        public int height(Node<T> node)
        {
            Node<T> temp = node;
            int hleft = 0, hright = 0;
            if (node == null) return 0;
            if (node.left != null)  hleft = height(node.left); 
            if (node.right != null)  hright = height(node.right); 
            return(max(hleft,hright) + 1);
        }

        public Node<T> Search(T target, Node<T> node,  string str = null) 
        {
            if (node == null) return null;
            if (target.Equals(node.key))
            {
                if (str == null) return node;
                else if (isLeave(node) || (str == "previous" && hasOnlyRightNode(node)) || (str == "next" && hasOnlyLeftNode(node))) return SearchIfNull(node, str);
                else return SearchNP(target, node, str);
            }
            else
            {
                if (target.CompareTo(node.key) < 0) return Search(target, node.left, str);
                else return Search(target, node.right, str);
            }
        }

        private Node<T> SearchNP(T target, Node<T> node, string str, bool rotate = false)
        {
            if (node == null) return null;
            if (str == "next") {
                if (!hasLeftNode(node) && node.key.CompareTo(target) > 0) return node;
                if (!rotate) return SearchNP(target, node.right, str, true);
                else return SearchNP(target, node.left, str, true);
            }
            else {
                if (!hasRightNode(node)&& node.key.CompareTo(target) < 0) return node;
                if (!rotate) return SearchNP(target, node.left, str, true);
                else return SearchNP(target, node.right, str, true);
            }
        }
        private Node<T> SearchIfNull(Node<T> node, string str) {
            if (str == "next"){
                if (node.parent == null) return null;
                if (node.parent.key.CompareTo(node.key) > 0) return node.parent;
                else return SearchIfNull(node.parent, str);
            }
            else {
                if (node.parent == null) return null;
                if (node.parent.key.CompareTo(node.key) < 0) return node.parent;
                else return SearchIfNull(node.parent, str);
            }
        }

        public void Delete(T node){
            Node<T> nod = Search(node, root);
            if (nod == root && hasOnlyLeftNode(nod)) { 
                root = nod.left; 
                return; 
            }
            if (nod == root && hasOnlyRightNode(nod)) { 
                root = nod.right; 
                return; 
            }
            Node<T> temp = Search(node, root).right;
            if (temp != null) 
                for (; temp.left != null; temp = temp.left);
            DeleteNode(nod, temp);
        }
        private void DeleteNode(Node<T> node, Node<T> temp)
        {
            if (isLeave(node)){
                if (isLeft(node)) node.parent.left = null;
                else node.parent.right = null;
            }
            else {
                DeleteNode(Search(temp.key, root), temp);
                if (node.Equals(root)) root = temp;
                else if (isLeft(node)) node.parent.left = temp;
                else node.parent.right = temp;
                temp.left = node.left;
                temp.right = node.right;
            }

        }
    }
}
