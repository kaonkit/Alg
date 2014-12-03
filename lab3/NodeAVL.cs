using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class NodeAVL<T>  where T : IComparable
    {
        public new T key { get; set; }
        public new NodeAVL<T> left { get; set; }
        public new NodeAVL<T> right { get; set; }
        public new NodeAVL<T> parent { get; set; }
        public int height { get; set; }
        public NodeAVL(T val, NodeAVL<T> par = null){
            this.key = val;
            this.height = 1;
            this.parent = par;
            this.left = null;
            this.right = null;
        }

    }
}
