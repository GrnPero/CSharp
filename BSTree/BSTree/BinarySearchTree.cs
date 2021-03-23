using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{

    class BinarySearchTree
    {
        public class Node
        {
            public int value;
            public Node left, right;

            public Node (int value)
            {
                this.value = value;
                this.left = null;
                this.right = null;
            }
        }

        Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void insert(int value)
        {
            root = insertRecursion(root, value);
        }

        public Node insertRecursion(Node root, int value)
        {
            // Empty Tree
            if (root == null)
            {
                root = new Node(value);
                return root;
            }

            if (value < root.value) // If the value inserted into the tree is less than the root value iterate to the left Node in a recursion 
            {
                root.left = insertRecursion(root.left, value);
            } else if (value > root.value) // Do the same but to the right
            {
                root.right = insertRecursion(root.right, value);
            }

            return root;
        }


        public void inOrder()
        {
            inOrderRecursion(this.root);
        }

        public void inOrderRecursion(Node root)
        {
            if (root != null)
            {
                inOrderRecursion(root.left);
                Console.WriteLine(root.value);
                inOrderRecursion(root.right);
            }
        }

    }
}
