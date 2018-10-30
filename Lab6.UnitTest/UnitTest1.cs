using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab6.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        static SortedDictionary<int, SortedSet<int>> PointPartsCollectionToMap(IEnumerable<(int a, int b)> collection)
        {
            var result = new SortedDictionary<int, SortedSet<int>>();

            void Add(int from, int to)
            {
                SortedSet<int> toCollection;
                if (!result.TryGetValue(from, out toCollection))
                {
                    toCollection = new SortedSet<int>();
                    result.Add(from, toCollection);
                }
                toCollection.Add(to);
            }

            foreach ((int a, int b) in collection)
            {
                Add(a, b);
                Add(b, a);
            }
            return result;
        }

        public IEnumerable<(int a, int b)> ArrayToPointPairsCollection(int[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                int a = data[i, 0];
                int b = data[i, 1];
                yield return (a, b);
            }
        }

        public SortedSet<int> GetAccessable(
            int from,
            SortedDictionary<int, SortedSet<int>> map
        )
        {
            var result = new SortedSet<int>();
            CollectNodes(from, map, result);
            return result;
        }

        private void CollectNodes(
            int from, 
            SortedDictionary<int, SortedSet<int>> map, 
            SortedSet<int> visited
        )
        {
            visited.Add(from);

            foreach (int to in map[from])
            {
                if (!visited.Contains(to))
                {
                    CollectNodes(to, map, visited);
                }
            }
        }

        public bool IfFullyLinked(SortedDictionary<int, SortedSet<int>> map)
        {
            foreach (int from in map.Keys)
            {
                SortedSet<int> accessible = GetAccessable(from, map);
                if (!map.Keys.SequenceEqual(accessible))
                {
                    return false;
                }
            }


            return true;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var map = PointPartsCollectionToMap(ArrayToPointPairsCollection(GetFileData()));
            Assert.IsTrue(IfFullyLinked(map));
        }

        private static int[,] GetFileData()
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
            return data;
        }
    }
}
