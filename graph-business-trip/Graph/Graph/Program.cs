using System;
using System.Collections.Generic;

namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Graph graph = new Graph();
            //graph.AddNode("10");
            //graph.AddNode("20");
            //graph.AddNode("30");


            //Console.WriteLine($"Number of nodes in graph: {graph.Size()}");


            //Vertex one = new Vertex("10");
            //Vertex two = new Vertex("20");
            //Vertex three = new Vertex("30");
            //graph.AddEdge(one, two, 10);
            //graph.AddEdge(one, three, 5);


            //Console.WriteLine("Neb and weig of node one:");
            //List<Edge> resultA = graph.GetNeighbors(one);
            //foreach (Edge edge in resultA)
            //{
            //    Console.Write($" {edge.Neighbor.Value} ");
            //    Console.Write($" {edge.Weight} ");
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Neb and weig of node three:");
            //List<Edge> resultC = graph.GetNeighbors(three);
            //foreach (Edge edge in resultC)
            //{
            //    Console.Write($" {edge.Neighbor.Value} ");
            //    Console.Write($" {edge.Weight} ");
            //    Console.WriteLine();
            //}

            //List<Vertex> nodes = graph.GetNodes();
            //Console.Write("List of nodes in graph: ");
            //foreach (Vertex node in nodes)
            //{
            //    Console.Write($" {node.Value} ");
            //}
            //Console.WriteLine();

            //List<Vertex> path = graph.BreadthFirst(one);
            //Console.Write("Adjec list of node 1: ");
            //foreach (Vertex node in path)
            //{
            //    Console.Write($" {node.Value} ");
            //}
            //Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****************************************************");


            Console.WriteLine("BusinessTrip :");
            Graph travil = new Graph();
            travil.AddNode("Pandora");
            travil.AddNode("Arendelle");
            travil.AddNode("Metroville");
            travil.AddNode("Monstropolis");
            travil.AddNode("Naboo");
            travil.AddNode("Narnia");
            Vertex A = new Vertex("Pandora");
            Vertex B = new Vertex("Arendelle");
            Vertex C = new Vertex("Metroville");
            Vertex D = new Vertex("Monstropolis");
            Vertex E = new Vertex("Naboo");
            Vertex F = new Vertex("Narnia");
            travil.AddEdge(A, B,150);
            travil.AddEdge(A, C,82);
            travil.AddEdge(B, C,99);
            travil.AddEdge(C, F,37);
            travil.AddEdge(E, F,250);

            travil.AddEdge(B, D,42);
            travil.AddEdge(D, C,105);
            travil.AddEdge(C, E,26);
            travil.AddEdge(D, E,73);
            string start = "Metroville";
            string end = "Naboo";
            BusinessTrips.BusinessTrip(travil, start, end);
        }
       
    }
}
