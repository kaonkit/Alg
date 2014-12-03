using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class AVLTree<T>: Tree<T> where T: IComparable
    {
        public new NodeAVL<T> root { get; private set; }
        //
        public new delegate bool Clause(NodeAVL<T> node);
        public Clause isLeft = node => node.parent.left == node;
        public Clause isRight = node => node.parent.right == node;

        public AVLTree() { }
        public AVLTree(T val){
            root = new NodeAVL<T>(val);
        }
        private int height(NodeAVL<T> node) {
            return node != null ? node.height : 0;
        }
        private int balanceFactor(NodeAVL<T> node) {
            return height(node.right) - height(node.left);
        }
        private void fixHeight(NodeAVL<T> node){
            node.height = (height(node.left) > height(node.right) ? height(node.left) : height(node.right)) + 1;
        }

        public NodeAVL<T> rotateRight(NodeAVL<T> node) // правый поворот вокруг node
        {
            NodeAVL<T> newNode = node.left;

            if (node.Equals(root)) {
                newNode.parent = null;
                root = newNode;
            }
            else {
                if (isLeft(node)) node.parent.left = newNode;
                else node.parent.right = newNode;
            }

	        node.left = newNode.right;    
	        newNode.right = node;
            newNode.parent = node.parent;
            node.parent = newNode;
  
	        fixHeight(node);    
	        fixHeight(newNode);
            return newNode;
        } 
        NodeAVL<T> rotateLeft(NodeAVL<T> node) // левый поворот вокруг node
        {
            
            NodeAVL<T> newNode = node.right;

            if (node.Equals(root)) {
                newNode.parent = null;
                root = newNode;
            }
            else
            {
                if (isLeft(node)) node.parent.left = newNode;
                else node.parent.right = newNode;
            }

	        node.right = newNode.left;    
	        newNode.left = node;
            newNode.parent = node.parent;
            node.parent = newNode;
   
	        fixHeight(node);    
	        fixHeight(newNode);    
	        return newNode;
        }

        NodeAVL<T> balance(NodeAVL<T> node) // балансировка узла
        {
            fixHeight(node);
            if (balanceFactor(node) == 2)
            {
                if (balanceFactor(node.right) < 0)
                    rotateRight(node.right);
                rotateLeft(node);
            }
            else if (balanceFactor(node) == -2)
            {
                if (balanceFactor(node.left) > 0)
                    node.left = rotateLeft(node.left);
                rotateRight(node);
            }
            return node;
        }

        public NodeAVL<T> insert(T key)//вставка элемента
        {
            NodeAVL<T> node = (NodeAVL <T>)root;
            insert(key, node);
            return node;
        }
        private NodeAVL<T> insert(T key, NodeAVL<T> node, NodeAVL<T> parent = null)
        {
            if (node == null)
                node = new NodeAVL<T>(key, parent);
            else if (key.CompareTo(node.key) < 0)
                balance(node.left = insert(key, (NodeAVL <T>)node.left, node));
            else
                balance(node.right = insert(key, (NodeAVL<T>)node.right, node));
            return node;
        }
    }
    

}
