using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph
    {
      
        public Graph()
        {
           
        }
        public List<Vertex> Vertices { get; set; } = new List<Vertex>();

        public Object AddNode(Object value)
        {
            Vertex node = new Vertex(value);
            Vertices.Add(node);
            return node;
        }

        public void AddEdge(Vertex vertA, Vertex vertB, int weight)
        {
            if (vertA == vertB)
            {
                Vertex point = Vertices.Find(v => v.Value == vertA.Value);
                Edge edge = new Edge(point, weight);
                Vertices.Find(v => v.Value == vertA.Value).Edge.Add(edge);
                return;
            }

            Vertex pointA = Vertices.Find(v => v.Value == vertA.Value);
            Vertex pointB = Vertices.Find(v => v.Value == vertB.Value);

            Edge edgeA = new Edge(pointB, weight);
            pointA.Edge.Add(edgeA);

            Edge edgeB = new Edge(pointA, weight);
            pointB.Edge.Add(edgeB);
        }

        public List<Vertex> GetNodes()
        {
            if (Vertices.Count == 0)
            {
                return null;
            }
            else
            {
                return Vertices;
            }
        }

        public List<Edge> GetNeighbors(Vertex node)
        {
            return Vertices.Find(v => v.Value == node.Value).Edge;
        }
        public List<Vertex> BreadthFirst(Vertex node)
        {
            Vertex root = Vertices.Find(n => n.Value == node.Value);
            List<Vertex> nodePath = new List<Vertex>();
            Queue<Vertex> nodeQueue = new Queue<Vertex>();

            root.Visited = true;
            nodeQueue.Enqueue(root);

            while (nodeQueue.Count > 0)
            {
                Vertex front = nodeQueue.Dequeue();
                nodePath.Add(front);

                foreach (Edge edge in front.Edge)
                {
                    if (!edge.Neighbor.Visited)
                    {
                        edge.Neighbor.Visited = true;
                        nodeQueue.Enqueue(edge.Neighbor);
                    }
                }
            }

            return nodePath;
        }

        public int Size()
        {
            return Vertices.Count;
        }
        public static List<Vertex> DepthFirst(Graph graph)
        {
            if (graph.Vertices.Count == 0)
            {
                return null;
            }

            List<Vertex> result = new List<Vertex>();
            Vertex root = graph.Vertices[0];

            result = DepthFirstHelper(graph, result, root);
            return result;
        }
        public static List<Vertex> DepthFirstHelper(Graph graph, List<Vertex> list, Vertex root)
        {
            root.Visited = true;
            list.Add(root);

            foreach (Edge edge in root.Edge)
            {
                if (!edge.Neighbor.Visited)
                {
                    DepthFirstHelper(graph, list, edge.Neighbor);
                }
            }

            return list;
        }


    }
}