using System;
using System.Collections.Generic;
using System.Text;

namespace netcore_algo
{
    class NodeTree
    {
        Dictionary<int, Queue<Node>> nodeMaps = new Dictionary<int, Queue<Node>>(); 
        int level = 0;

        public class Node
        {
            public Node(string id)
            {
                this.Id = id;
                Children = new List<Node>();
            }
            public List<Node> Children;
            public Node Right;
            public string Id;
        }

        public void Test()
        {
            // Set up
            var nodeB1 = new Node("B1");
            var nodeB2 = new Node("B2");
            var nodeB3 = new Node("B3");

            var nodeA1 = new Node("A1");
            var nodeA2 = new Node("A2");
            var nodeA3 = new Node("A3");

            nodeA1.Children.Add(nodeB1);
            nodeA1.Children.Add(nodeB2);

            nodeA3.Children.Add(nodeB3);

            var root = new Node("ROOT");

            root.Children.Add(nodeA1);
            root.Children.Add(nodeA2);
            root.Children.Add(nodeA3);

            // processing 
            FillRightNode(root);

            // to print the result back out 
            Console.WriteLine("=========");

            List<Node> nodes = new List<Node> { root, nodeA1, nodeA2, nodeA3, nodeB1, nodeB2, nodeB3 };
            nodes.ForEach(n =>
            {
                if (n.Children.Count > 0)
                {
                    Console.WriteLine("Node " + n.Id + "'s " + (n.Children.Count == 1 ? "child is" : "children are") + "  :");
                    n.Children.ForEach(nc => { Console.WriteLine("\tNode " + nc.Id); });
                }
            });

            Console.WriteLine("=========");
            nodes.ForEach(n =>
            {
                Console.WriteLine("Node " + n.Id + "'s Right is " + (n.Right == null ? "NULL" : n.Right.Id));
            });

            Console.WriteLine("=========");
            Console.ReadKey();
        }

        private void FillRightNode(Node node)
        {
            Node rightNode = null;
            Queue<Node> nextLevelQueue = new Queue<Node>();

            if (node == null) { return; }
            if (!nodeMaps.ContainsKey(level)) { nodeMaps.Add(level, new Queue<Node>()); }

            // get current level queue and fetch the next node
            var q = nodeMaps[level];
            if (q.Count > 0)
            {
                rightNode = q.Dequeue();
                node.Right = rightNode;
            }

            // add children of current node to next level
            if (node.Children.Count > 0)
            {
                if (!nodeMaps.ContainsKey(level + 1)) { nodeMaps.Add(level + 1, new Queue<Node>()); }
                nextLevelQueue = nodeMaps[level + 1];
                for (var i = 0; i < node.Children.Count; i++)
                {
                    nextLevelQueue.Enqueue(node.Children[i]);
                }
            }

            // to move on processing of another node
            if (node.Right == null)
            {
                level++;
                if (nextLevelQueue.Count > 0)
                {
                    FillRightNode(nextLevelQueue.Dequeue());
                }
            }
            else
            {
                FillRightNode(node.Right);
            }
        }
    }
}