using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class BusinessTrips : Graph
    {
        public static int? BusinessTrip(Graph graph, string start, string end)
        {
            int x = 1;
            bool pathFound = false;
            List<Vertex> route = new List<Vertex>();
            int cost = 0;
            Vertex root = graph.Vertices.Find(v => v.Value.ToString() == start);

            if (!graph.Vertices.Exists(c => c.Value.ToString() == start) || !graph.Vertices.Exists(c => c.Value.ToString() == end))
            {
                route.Add(new Vertex("None"));
                return x;
            }
            else if (root.Edge.Exists(n => n.Neighbor.Value.ToString() == end))
            {
                route.Add(root.Edge.Find(n => n.Neighbor.Value.ToString() == end).Neighbor);
                route.Add(root.Edge.Find(n => n.Neighbor.Value.ToString() == start).Neighbor);
                cost += root.Edge.Find(n => n.Neighbor.Value.ToString() == end).Weight;
                return x;
            }
            else
            {
                Tuple<List<Vertex>, int, bool, Vertex> bestRoute = FindRoutes(graph, root, start, end, route, cost, pathFound);

                Console.WriteLine($"travels from using the root {start} to {end}:");
                for (int i = bestRoute.Item1.Count - 1; i >= 0; i--)
                {
                    Console.Write($"{bestRoute.Item1[i].Value.ToString()} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Cost: ${bestRoute.Item2}");
                return x;
            }
        }
        public static Tuple<List<Vertex>, int, bool, Vertex> FindRoutes(Graph graph, Vertex root, string start, string end, List<Vertex> route, int cost, bool pathFound)
        {
            root.Visited = true;
            if (root.Value.ToString() == end)
            {
                pathFound = true;
            }

            Vertex lastNode = null;

            foreach (Edge edge in root.Edge)
            {

                if (!edge.Neighbor.Visited)
                {
                    Tuple<List<Vertex>, int, bool, Vertex> path = FindRoutes(graph, edge.Neighbor, start, end, route, cost, pathFound);
                    if (path.Item3)
                    {
                        pathFound = true;
                        lastNode = path.Item4;
                        cost += path.Item2;
                    }
                }
                if (pathFound)
                {
                    route.Add(root);
                    if (lastNode == edge.Neighbor)
                    {
                        cost += edge.Weight;
                    }
                    return new Tuple<List<Vertex>, int, bool, Vertex>(route, cost, pathFound, root);
                }
            }
            return new Tuple<List<Vertex>, int, bool, Vertex>(route, cost, pathFound, root);
        }
    }
}
