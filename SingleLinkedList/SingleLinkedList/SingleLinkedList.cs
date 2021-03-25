using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList { 
    class SingleLinkedList { 
        public class Node {
            public int value;
            public Node right;


            public Node(int value) {
                this.value = value;
                right = null;
            }
        }

        Node root;
        
        public SingleLinkedList() {
            root = null;
        }

        public void Add(int value) {
            root = AddRecursion(root, value);
        }

        public Node AddRecursion(Node root, int value) {
            // Link List is empty
            if (root == null) {
                root = new Node(value);
                return root;
            }

            // Link list already has an existing value in the Node.right so we use recursion to find an empty Node
            if (root != null) {
                root.right = AddRecursion(root.right, value);
            }
            // We return the new object that was created from this recursion
            return root;
        }

        public void Print() {
            RecursionPrint(root);
        }

        public void RecursionPrint(Node root) {
            if (root != null) {
                Console.WriteLine(root.value);
                RecursionPrint(root.right);
            }
        }

        



    }
}
