using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab7.UnitTest
{
    /// <summary>
    /// Програма зчитує початковий граф з файлу у вигляді матриці суміжності.
    /// Перевіряє граф на зв'язність.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Numbers are separated by Tab symbol 
        /// ('\t'; https://en.wikipedia.org/wiki/Tab_key)
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<bool> StringToIntEnumerable(string line)
        {
            string[] cells = line.Split('\t');
            for (int i = 0; i < cells.Length; i++)
            {
                string cell = cells[i];
                if (cell == "+")
                    yield return true;
                else if (cell == "-")
                    yield return false;
                else
                    throw new FormatException(
                        "Only '+' and '-' symbols separated by tab char ('\t') are acceptable."
                    );
            }
        }

        public static IEnumerable<(int from, int to)> GetFileData()
        {
            string[] lines = File.ReadAllLines(".\\DirectedGraphRepresentation.txt");

            bool[] firstLine = StringToIntEnumerable(lines[0]).ToArray();
            int nodesCount = firstLine.Length;

            for (int fromIndex = 0; fromIndex < lines.Length; fromIndex++)
            {
                string line = lines[fromIndex];
                bool[] cells = StringToIntEnumerable(line).ToArray();

                if (cells.Length != nodesCount)
                    throw new FormatException("Count of rows and columns should be equal.");

                for (int toIndex = 0; toIndex < nodesCount; toIndex++)
                {
                    bool transitExists = cells[toIndex];
                    if (transitExists)
                    {
                        // Return item as tuple.
                        yield return (from: fromIndex + 1, to: toIndex + 1);
                    }
                }
            }
        }

        static SortedDictionary<int, SortedSet<int>> GetMap()
        {
            var result = new SortedDictionary<int, SortedSet<int>>();

            foreach ((int from, int to) in GetFileData())
            {
                SortedSet<int> toCollection;
                if (!result.TryGetValue(from, out toCollection))
                {
                    toCollection = new SortedSet<int>();
                    result.Add(from, toCollection);
                }
                toCollection.Add(to);
            }
            return result;
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
            var map = GetMap();
            Assert.IsTrue(IfFullyLinked(map));
        }
    }
}
