using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab6Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(".\\GraphRepresentation.txt");

            var data = new int[lines.Length, 2];
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] cells = line.Split(',');
                int a = int.Parse(cells[0]);
                int b = int.Parse(cells[1]);
                data[i, 0] = a;
                data[i, 1] = b;
            }
        }

        void Foo(int vertex, int neighbour)
        {
            Dictionary<int,int> Graph = new Dictionary<int,int>();

        }

           
        }
        bool IsConnected ()
        {

        }
        struct Row
        {
            public int Item1;
            public int Item2;
        }
    }
}
