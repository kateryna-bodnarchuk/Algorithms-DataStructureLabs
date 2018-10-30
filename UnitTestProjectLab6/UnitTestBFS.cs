using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProjectLab6
{
    [TestClass]
    public class Graph
    {
        static Dictionary<int, SortedSet<int>> ArrayToDict(int[,] data)
        {
            var result = new Dictionary<int, SortedSet<int>>();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                {
                    SortedSet<int> links;
                    if (!result.TryGetValue(data[i, 0], out links))
                    {
                        links = new SortedSet<int>();
                        result.Add(data[i, 0], links);
                    }
                    links.Add(data[i, 1]);
                }
                {
                    SortedSet<int> links;
                    if (!result.TryGetValue(data[i, 1], out links))
                    {
                        links = new SortedSet<int>();
                        result.Add(data[i, 1], links);
                    }
                    links.Add(data[i, 0]);
                }
            }
            return result;
        }

        [TestMethod]
        public void TestMethod1()
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
    }
}
