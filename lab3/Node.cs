using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Node<T> where T : IComparable
    {
        public T key { get; set; }
        public Node<T> left { get; set; }
        public Node<T> right { get; set; }
        public Node<T> parent { get; set; }
        public Node(T val, Node<T> par = null)
        {
            key = val;
            parent = par;
            left = null;
            right = null;
        }
    }
}
