using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
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
        public bool SearchTree(int number)
        {
            Node current = root;
            if (number > root.data)
            {
                return SearchTree(current.rightChild, number);
            }
            else if (number < root.data)
            {
                return SearchTree(current.leftChild, number);
            }
            else if (number == root.data)
            {
                return true;
            }
            else return false;
        }
        public bool SearchTree(Node position,int number)
        {
            Node current = position;
            if (number > root.data)
            {
                return SearchTree(current.rightChild, number);
            }
            else if (number < position.data)
            {
                return SearchTree(current.leftChild, number);
            }
            else if (number == position.data)
            {
                return true;
            }
            else return false;
        }

    }
}
