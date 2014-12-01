using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Node<T> where T : IComparable
    {
        public T key;
        public Node<T> left;
        public Node<T> right;
        public Node<T> parent;
        public Node(T val, Node<T> par = null)
        {
            key = val;
            parent = par;
            left = null;
            right = null;
        }
    }
}
