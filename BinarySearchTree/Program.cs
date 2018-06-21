using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinarySearchTree;

namespace BinarySearchTree
{
    static class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.CreateTree();
            tree.MainMenu();
            
        }
    }
}
