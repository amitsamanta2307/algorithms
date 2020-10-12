using Graphs.GraphTraversals;
using System;
using System.Collections.Generic;

namespace Graphs
{
    class Program
    {
        public static void AddUndirectedEdge(IList<IList<int>> graph, int from, int to)
        {
            graph[from].Add(to);
            graph[to].Add(from);
        }
        static void Main(string[] args)
        {
            // Create a Graph
            int count = 9;

            IList<IList<int>> graph = new List<IList<int>>();

            for (int i = 0; i < count; i++)
                graph.Add(new List<int>());

            // Add the undirected Edges
            AddUndirectedEdge(graph, 0, 1);
            AddUndirectedEdge(graph, 0, 8);
            AddUndirectedEdge(graph, 0, 3);
            AddUndirectedEdge(graph, 1, 7);
            AddUndirectedEdge(graph, 7, 2);
            AddUndirectedEdge(graph, 2, 3);
            AddUndirectedEdge(graph, 2, 5);
            AddUndirectedEdge(graph, 5, 6);
            AddUndirectedEdge(graph, 3, 4);
            AddUndirectedEdge(graph, 4, 8);

            BreadthFirstSearchRecursive ojb1 = new BreadthFirstSearchRecursive();

            Console.WriteLine("BFS depth: {0}", ojb1.BFS(graph, 0, 9));
        }
    }
}
