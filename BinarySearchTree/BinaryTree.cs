using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        private Node parent;
        private Node root;
        private Node current;
        private List<string> position = new List<string>() { "root" };
        private string direction;
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
        public void SearchTree()
        {
            try
            {
                bool search = SearchTree( Int32.Parse(InteractWithUser("Please enter an integer to search for")));
                if (search == false)
                {
                    InteractWithUser("Node not found, press <enter> to continue");
                    MainMenu();
                }
                else
                {
                    MainMenu();
                }
            }
            catch (FormatException e)
            {
                InteractWithUser(e.Message + ". Please try again");
                SearchTree();
            }
        }
        public bool SearchTree(int number)
        {
            position.Clear();
            position.Add("root"); 
            Node current = root;
            if (current == null)
            {
                return false;
            }
            else if (number > root.data)
            {
                position.Add("right");
                return SearchTree(current.rightChild, number);
            }
            else if (number < root.data)
            {
                position.Add("left");
                return SearchTree(current.leftChild, number);
            }
            else if (number == root.data)
            {
                
                InteractWithUser("Node was found at root" );
                return true;
            }
            else return false;
            
        }
        public bool SearchTree(Node _current,int number)
        {
           
            current = _current;
            if (current == null)
            {
                return false;
            }
            else if (number > _current.data)
            {
                parent = _current;
                direction = "right";
                position.Add(direction);
                return SearchTree(current.rightChild, number);
            }
            else if (number < _current.data)
            {
                parent = _current;
                direction = "left";
                position.Add(direction);
                return SearchTree(current.leftChild, number);
            }
            else if (number == _current.data)
            {   
                string _position = string.Join(", ", position);
                InteractWithUser("Node was found at " + _position);
                return true;
            }
            else return false;
            
        }
        public int GetNode()
        {         
            try
            {
                return  Int32.Parse(InteractWithUser("Please enter an integer to be added to tree"));
            }
            catch (FormatException e)
            {
                InteractWithUser(e.Message + ". Please try again");
                return GetNode();                
            }           
        }       
        public string InteractWithUser(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();

       }
        public int CheckNode()
        {
            int number = GetNode();
            if (SearchTree(number) == false)
            {
                return number;
            }
            InteractWithUser("Node already exists.");
            return CheckNode();
        }
        private void InsertNode(int number)
        {
            if (direction == "left")
            {
                parent.leftChild = new Node(number);
            }
            else parent.rightChild = new Node(number);
                             
        }
        public void AddNode()
        {
            InsertNode(CheckNode());
            string _position = string.Join(", ", position);
            InteractWithUser("Your Node was added at " + _position);
            MainMenu();
        }
        public void MainMenu()
        {   
            string response = InteractWithUser("Press 'S' to Search for node , 'A' to add node or 'Q' to quit.");
            if (response == "s" || response == "S"){
                SearchTree();
            }
            else if (response == "a"||response == "A")
            {
                AddNode();
            }
            else if (response == "q"||response == "Q")
            {
                Environment.Exit(0);
            }
            else
            {
                MainMenu();
            }
        }
        
        

        

        
    }
}
