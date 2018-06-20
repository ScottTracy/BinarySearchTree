using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }


        public void CreateTree()
        {
            root = new Node(50);
            root.leftChild = new Node(25);
            root.rightChild = new Node(75);
            root.leftChild.leftChild = new Node(19);
            root.leftChild.rightChild = new Node(39);
            root.rightChild.leftChild = new Node(69);
            root.rightChild.rightChild = new Node(89);
        }
    }
}
