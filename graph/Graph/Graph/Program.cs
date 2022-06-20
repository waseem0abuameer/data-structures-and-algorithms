using System;
using System.Collections.Generic;

namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Graph graph = new Graph();
            graph.AddNode("10");
            graph.AddNode("20");
            graph.AddNode("30");


            Console.WriteLine($"Number of nodes in graph: {graph.Size()}");


            Vertex one = new Vertex("10");
            Vertex two = new Vertex("20");
            Vertex three = new Vertex("30");
            graph.AddEdge(one, two, 10);
            graph.AddEdge(one, three, 5);


            Console.WriteLine("Neb and weig of node one:");
            List<Edge> resultA = graph.GetNeighbors(one);
            foreach (Edge edge in resultA)
            {
                Console.Write($" {edge.Neighbor.Value} ");
                Console.Write($" {edge.Weight} ");
                Console.WriteLine();
            }
            Console.WriteLine("Neb and weig of node three:");
            List<Edge> resultC = graph.GetNeighbors(three);
            foreach (Edge edge in resultC)
            {
                Console.Write($" {edge.Neighbor.Value} ");
                Console.Write($" {edge.Weight} ");
                Console.WriteLine();
            }

            List<Vertex> nodes = graph.GetNodes();
            Console.Write("List of nodes in graph: ");
            foreach (Vertex node in nodes)
            {
                Console.Write($" {node.Value} ");
            }

        }
    }
}
