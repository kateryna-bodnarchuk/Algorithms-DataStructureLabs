using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
             Dictionary<int, HashSet<int>> ArrayToDict(int[,] data)
            {
                var result = new Dictionary<int, HashSet<int>>();
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    {
                        HashSet<int> links;
                        if (!result.TryGetValue(data[i, 0], out links))
                        {
                            links = new HashSet<int>();
                            result.Add(data[i, 0], links);
                        }
                        links.Add(data[i, 1]);
                    }
                    {
                        HashSet<int> links;
                        if (!result.TryGetValue(data[i, 1], out links))
                        {
                            links = new HashSet<int>();
                            result.Add(data[i, 1], links);
                        }
                        links.Add(data[i, 0]);
                    }
                }
                return result;
            }
        }
    }

    internal class Dictionary<T1, T2>
    {
        internal void Add(int v, HashSet<int> links)
        {
            throw new NotImplementedException();
        }

        internal bool TryGetValue(int v, out HashSet<int> links)
        {
            throw new NotImplementedException();
        }
    }
}
