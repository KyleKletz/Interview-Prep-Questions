using System;
#nullable enable

namespace test_C_ {
    class FixBST {

        public static void Run () {
            Node root = new Node(10);
            root.Left = new Node(5);
            root.Left.Left = new Node(2);
            root.Left.Right = new Node(20);
            root.Right = new Node(8);

            
            startFixBST(root);
            Console.WriteLine(root);
        }


        public static void startFixBST(Node node){
             Node? first = null; 
             Node? last = null;
             Node? prev = null;

            FindWrongNodes(node, ref first, ref last, ref prev);
            if(first != null && last != null){
                var temp = first.Data;
                first.Data = last.Data;
                last.Data = temp;
            }
        }

        public static void FindWrongNodes(Node? root, ref Node? first, ref Node? last, ref Node? prev){
            if (root != null){
                FindWrongNodes(root.Left, ref first, ref last, ref prev);
                if (prev != null && root.Data < prev.Data){
                    if(first == null){
                        first = prev;
                    }else{
                        last = root;
                    }
                }
                prev = root;
                FindWrongNodes(root.Right, ref first, ref last, ref prev);
            }
        }

       public class Node
        {
            public Node(){
                this.Data = null;
                this.Left = null;
                this.Right = null;
            }
            public Node(int data){
                this.Data = data;
                this.Left = null;
                this.Right = null;
            }
            public int? Data;
            public Node? Left;
            public Node? Right;
        }

    }
}