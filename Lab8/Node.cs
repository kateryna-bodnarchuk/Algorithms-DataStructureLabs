using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    public sealed class Node<TData>
    {
        public Node(TData data)
        {
            this.Date = data;
        }

        public TData Date { get; }

        public Node<TData> Left { get; set; }

        public Node<TData> Right { get; set; }
    }
}
