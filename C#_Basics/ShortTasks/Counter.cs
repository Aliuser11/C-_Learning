using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortPrepareTasks
{
    internal class Counter
    {
        private readonly List<List<int>> links = [[0, 1], [2, 3]];
        public int CounterSequence1(int n = 3)
        {
            List<int>[] graph = new List<int>[n];
            for (int i = 0; i < n; i++)
                graph[i] = new List<int>();

            foreach (var link in links)
            {
                int u = link[0];
                int v = link[1];
                graph[u].Add(v);
                graph[v].Add(u);
            }
            bool[] visited = new bool[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    DFS(i, graph, visited);
                    count++;
                }
            }

            return count;
        }

        static void DFS(int node, List<int>[] graph, bool[] visited)
        {
            visited[node] = true;
            foreach (var neighbor in graph[node])
            {
                if (!visited[neighbor])
                    DFS(neighbor, graph, visited);
            }
        }

        public string Profesor(int k, List<int> a)
        {
            var onTime = a.Where(x => x <= 0).Count();

            if (onTime >= k)
            {
                return "NO";
            }
            else
            {
                return "YES";
            }
        }
    }
}
