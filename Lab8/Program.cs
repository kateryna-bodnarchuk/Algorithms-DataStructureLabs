using System;
using System.Linq;

namespace Lab8
{
    class Program
    {
        static void PrintNode<TData>(Node<TData> node)
        {
            PrintNodeCore(node, level: 0, prefix: "Root");
        }

        static void PrintNodeCore<TData>(Node<TData> node, int level, string prefix)
        {
            var shift = string.Concat(Enumerable.Repeat('\t', level));
            Console.WriteLine($"{shift}{prefix} {node.Date}");

            if (node.Left != null)
            {
                PrintNodeCore(node.Left, level + 1, prefix: "Left"); 
            }

            if (node.Right != null)
            {
                PrintNodeCore(node.Right, level + 1, prefix: "Right");
            }
        }

        static void Main(string[] args)
        {
            var node1 = new Node<int>(1);
            var node2 = new Node<int>(2);
            var node3 = new Node<int>(3);
            var node4 = new Node<int>(4);
            var node5 = new Node<int>(5);
            var node6 = new Node<int>(6);
            var node7 = new Node<int>(7);
            node5.Left = node3;
            node5.Right = node6;
            node6.Right = node7;
            node3.Left = node2;
            node3.Right = node4;
            node2.Left = node1;

            PrintNode(node5);
            Console.ReadKey();
        }
    }
}
