using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.GraphTraversals
{
    public class BreadthFirstSearchRecursive
    {
        public const int DEPTH_TOKEN = -1;

        public int BFS(IList<IList<int>> graph, int start, int count)
        {
            bool[] visited = new bool[count];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            queue.Enqueue(DEPTH_TOKEN);
            return BFS(visited, queue, graph);
        }

        private int BFS(bool[] visited, Queue<int> queue, IList<IList<int>> graph)
        {
            int current = queue.Dequeue();

            if (current == DEPTH_TOKEN)
            {
                queue.Enqueue(DEPTH_TOKEN);
                return 1;
            }

            // Node is visited
            if (visited[current]) 
                return 0;

            // Visit this node.
            visited[current] = true;

            // Add all neighbors to queue.
            IList<int> neighbors = graph[current];
            if (neighbors != null)
            {
                foreach (var next in neighbors)
                    if (!visited[next])
                        queue.Enqueue(next);
            }

            int depth = 0;

            while (true)
            {
                if (queue.Count == 1 && queue.Peek() == DEPTH_TOKEN)
                    break;

                // The depth is the sum of all DEPTH_TOKENS encountered.
                depth += BFS(visited, queue, graph);
            }

            return depth;
        }
    }
}
