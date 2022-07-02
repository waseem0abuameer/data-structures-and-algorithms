# Challenge Summary
<!-- Description of the challenge -->
Implement a breadth-first traversal on a graph.


## Whiteboard Process
<!-- Embedded whiteboard image -->
![](3.0.png)
## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
Big O Space = O(n)
Big O Time = O(n)
## Solution
<!-- Show how to run your code, and examples of it in action -->
![](1.0.png)
![](2.0.png)

## solve 
``` C#
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
```